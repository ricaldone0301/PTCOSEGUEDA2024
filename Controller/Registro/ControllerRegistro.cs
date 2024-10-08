﻿using PTC.Controller.Common;
using PTC.Modelo.DAOContrasena;
using PTC.Modelo.DAORegistro;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Registro
{
    class ControllerRegistro
    {
        ViewRegistro ObjRegistro;

        private string rol;


        private string verificationCode = string.Empty;
        //private ViewRegistro viewRegistro;
        public ControllerRegistro(ViewRegistro Vista)
        {
            ObjRegistro = Vista;
            ObjRegistro.Load += new EventHandler(CargoInicial);
            ObjRegistro.btnEnviar.Click += new EventHandler(ConseguirCorreo);
            ObjRegistro.btnEnviar1.Click += new EventHandler(VerificarCodigoYRegistrar);
            //ObjRegistro.timevcode.Tick  += new EventHandler(Tick);
        }

   

        public void CargoInicial(object sender, EventArgs e)
        {
            try
            {
                DAORegistro objAdmin = new DAORegistro();

                DataSet dsRoles = objAdmin.ComboBoxRoles();
                if (dsRoles != null && dsRoles.Tables.Contains("Roles"))
                {
                    DataTable dtRoles = dsRoles.Tables["Roles"];
                    ObjRegistro.cbRol.DataSource = dtRoles;
                    ObjRegistro.cbRol.ValueMember = "roleID";
                    ObjRegistro.cbRol.DisplayMember = "nombreRol";

                    
                    DataRow[] rows = dtRoles.Select($"nombreRol = '{rol}'");
                    if (rows.Length > 0)
                    {
                        ObjRegistro.cbRol.Text = rows[0]["nombreRol"].ToString();
                    }
                    
                }
                DataSet dsEspecialidad = objAdmin.ComboBoxEspecialidad();
                if (dsEspecialidad != null && dsEspecialidad.Tables.Contains("Especialidad"))
                {
                    DataTable dtEspecialidad = dsEspecialidad.Tables["Especialidad"];
                    ObjRegistro.cbEsp.DataSource = dtEspecialidad;
                    ObjRegistro.cbEsp.ValueMember = "especialidadID";
                    ObjRegistro.cbEsp.DisplayMember = "nombreEspecialidad";
                }

                DataSet dsConsultorio = objAdmin.ComboBoxConsultorio();
                if (dsConsultorio != null && dsConsultorio.Tables.Contains("Consultorio"))
                {
                    DataTable dtConsultorio = dsConsultorio.Tables["Consultorio"];
                    ObjRegistro.cbConsul.DataSource = dtConsultorio;
                    ObjRegistro.cbConsul.ValueMember = "consultorioID";
                    ObjRegistro.cbConsul.DisplayMember = "nombreConsultorio";

                }

                DataSet dsPreguntas = objAdmin.ComboBoxPreguntas();
                if (dsPreguntas != null && dsPreguntas.Tables.Contains("Preguntas"))
                {
                    DataTable dtPreguntas = dsPreguntas.Tables["Preguntas"];
                    ObjRegistro.cbPregunta.DataSource = dtPreguntas;
                    ObjRegistro.cbPregunta.ValueMember = "preguntaID";
                    ObjRegistro.cbPregunta.DisplayMember = "tituloPregunta";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#001: Error al cargar valores" + ex.Message);
            }
        }



        public void ConseguirCorreo(object sender, EventArgs e)
        {
            string password = ObjRegistro.txtUsuario.Text.Trim() + "OS1@";
            if (!ValidatePassword(password))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir al menos un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string to, from, pass;

            verificationCode = generateCode();

            to = ObjRegistro.txtEmail.Text;
            from = "clinicaosegueda02@gmail.com";
            pass = "vacr eukm hfxg xclp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = $"Tu código de verificación es: {verificationCode}";
            message.Subject = "Clinica Dental Osegueda - Codigo de verificacion";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Código de verificación enviado exitosamente. Revise su bandeja.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#005: No se pudo enviar el codigo de verificación." + ex.Message);
            }
        }

        public void VerificarCodigoYRegistrar(object sender, EventArgs e)
        {
            //Asigna la variavle inputCode al campo donde se mete el codigo
            string inputCode = ObjRegistro.txtConfirm.Text.Trim();

            //Si el codigo no es igual al de verfificacion retorna un mensaje de error
            if (inputCode != verificationCode)
            {
                MessageBox.Show("El código de verificación es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            //Si e igual entonces intent registrarlo
            try
            {
                //Se crea un objeto del DAO y la clase CommonClasss
                DAORegistro daoRegistro = new DAORegistro();
                CommonClass common = new CommonClass();

                string password = common.ComputeSha256Hash(ObjRegistro.txtUsuario.Text.Trim() + "OS1@");

                string cadenaencriptada = common.ComputeSha256Hash(password);

                //Se le asigna  los campos variables del Dao
                daoRegistro.Nombre = ObjRegistro.txtNombre.Text.Trim();
                daoRegistro.EspecialidadId = (int)ObjRegistro.cbEsp.SelectedValue;
                daoRegistro.Telefono = ObjRegistro.txtTelefono.Text.Trim();
                daoRegistro.ConsultorioId = (int)ObjRegistro.cbConsul.SelectedValue;
                daoRegistro.Usuario = ObjRegistro.txtUsuario.Text.Trim();
                daoRegistro.Contrasena = common.ComputeSha256Hash(ObjRegistro.txtUsuario.Text.Trim() + "OS1@");
                daoRegistro.Rol = int.Parse(ObjRegistro.cbRol.SelectedValue.ToString());
                daoRegistro.Email = ObjRegistro.txtEmail.Text.Trim();
                daoRegistro.PreguntaID = (int)ObjRegistro.cbPregunta.SelectedValue;
                daoRegistro.Respuesta = ObjRegistro.txtRespuesta.Text.Trim();
                daoRegistro.Status = false;

                // Intenta registrar el usaurio
                int valorRetornado = daoRegistro.RegistrarUsuario();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Contraseña de usuario: {ObjRegistro.txtUsuario.Text.Trim()}OS1",
"Credenciales de acceso",
MessageBoxButtons.OK,
MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#002: Error al registrar usuario." + ex.Message);
            }
        }

        //Este metodo valida la contrasena verificando que tenga todos los requerimientos necesarios
        private bool ValidatePassword(string password)
        {

            if (password.Length < 8)
            {
                return false;
            }

            bool hasNumber = password.Any(char.IsDigit);
            if (!hasNumber)
            {
                return false;
            }
            bool hasSpecialChar = password.Any(ch => "!@#$%^&*()_+[]{}|;:',.<>?/~`".Contains(ch));
            if (!hasSpecialChar)
            {
                return false;
            }

            return true;
        }
        //public void Tick(object sender, EventArgs e)
        //{
        //    int vCode = 1000;

        //    vCode += 10;
        //    if (vCode == 9999)
        //    {
        //        vCode = 1000;
        //    }

        //}

        //Este metodo genera el codigo por medio de un random
        //el cual es de 6 digitos
        public String generateCode()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string sixDigitNumber = randNum.ToString("D6");

            return sixDigitNumber;
        }

    }
}
