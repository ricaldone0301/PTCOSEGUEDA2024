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

        private int accion;
        private string rol;

        public ControllerRegistro(ViewRegistro Vista, int accion)
        {
            ObjRegistro = Vista;
            this.accion = accion;
            ObjRegistro.Load += new EventHandler(InitialCharge);
            ObjRegistro.btnEnviar.Click += new EventHandler(ConseguirCorreo);
            ObjRegistro.btnEnviar1.Click += new EventHandler(VerificarCodigoYRegistrar);
        }

        public void InitialCharge(object sender, EventArgs e)
        {
            try
            {
                DAOUsuarios objAdmin = new DAOUsuarios();

                DataSet dsRoles = objAdmin.ComboBoxRoles();
                if (dsRoles != null && dsRoles.Tables.Contains("Roles"))
                {
                    DataTable dtRoles = dsRoles.Tables["Roles"];
                    ObjRegistro.cbRol.DataSource = dtRoles;
                    ObjRegistro.cbRol.ValueMember = "roleID";
                    ObjRegistro.cbRol.DisplayMember = "nombreRol";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtRoles.Select($"nombreRol = '{rol}'");
                        if (rows.Length > 0)
                        {
                            ObjRegistro.cbRol.Text = rows[0]["nombreRol"].ToString();
                        }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string verificationCode = string.Empty;
        public void ConseguirCorreo(object sender, EventArgs e)
        {
            string to, from, email, pass;
            int vCode = 1000;

            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }

            verificationCode = vCode.ToString();

            to = ObjRegistro.txtEmail.Text;
            from = "clinicadentalosegueda01@gmail.com";
            pass = "aops ysuj qrda jfkm";
            email = verificationCode;
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
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VerificarCodigoYRegistrar(object sender, EventArgs e)
        {
            string inputCode = ObjRegistro.txtConfirm.Text.Trim();

            if (inputCode == verificationCode)
            {
                try
                {
                    DAORegistro daoRegistro = new DAORegistro();

                    daoRegistro.Nombre = ObjRegistro.txtNombre.Text.Trim();
                    daoRegistro.PersonalId = ObjRegistro.txtEmail.Text.Trim();
                    daoRegistro.EspecialidadId = (int)ObjRegistro.cbEsp.SelectedValue;
                    daoRegistro.Telefono = ObjRegistro.txtTelefono.Text.Trim();
                    daoRegistro.ConsultorioId = (int)ObjRegistro.cbConsul.SelectedValue;
                    daoRegistro.Usuario = ObjRegistro.txtUsuario.Text.Trim();
                    daoRegistro.Contrasena = ObjRegistro.txtContrasena.Text.Trim();
                    daoRegistro.Rol = int.Parse(ObjRegistro.cbRol.SelectedValue.ToString());
                    daoRegistro.Email = ObjRegistro.txtEmail.Text.Trim();

                    int valorRetornado = daoRegistro.RegistrarUsuario();

                    if (valorRetornado == 1)
                    {
                        MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los datos no pudieron ser registrados", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El código de verificación es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
