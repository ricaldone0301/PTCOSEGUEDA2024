﻿using PTC.Controller.Common;
using PTC.Modelo.DAOContrasena;
using PTC.Vista.OlvidoContrasena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC.Vista.OlvidoPregunta;
using System.Data;
using PTC.Modelo.DAORegistro;
using PTC.Modelo.DAOPreguntaContra;

namespace PTC.Controller.PreguntaContra
{
    internal class ControllerPreguntaContra
    {
        ViewOlvidoPregunta ObjPregunta;

        //Se genera una variable solamente en el Controller 
        private string codigoVerificacion = string.Empty;

        public ControllerPreguntaContra(ViewOlvidoPregunta Vista)
        {
            ObjPregunta = Vista;
            ObjPregunta.Load += new EventHandler(CargoInicial);
            ObjPregunta.btnEnviar.Click += new EventHandler(ConseguirCorreo);
            ObjPregunta.btnEnviar1.Click += new EventHandler(ActualizarContrasena);
            //ObjContrasena.timevcode.Tick += new EventHandler(Tick);
        }

        //Se define un método ConseguirCorreo que envía un correo electrónico con un código de verificación
        public void ConseguirCorreo(object sender, EventArgs e)
        {
            string to, from, pass;

            //genera un código de verificación y lo asigna a la variable codigoVerificacion
            codigoVerificacion = GenerarCodigo();


            //configura los detalles del mensaje de correo
            to = ObjPregunta.txtEmail.Text;
            from = "clinicaosegueda02@gmail.com";
            pass = "vacr eukm hfxg xclp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = $"Tu código de verificación es: {codigoVerificacion}";
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

        public void ActualizarContrasena(object sender, EventArgs e)
        {
            string codigoIngresado = ObjPregunta.txtConfirm.Text.Trim();
            string pregunta = ObjPregunta.cbPregunta.SelectedValue.ToString();
            string respuesta = ObjPregunta.txtRespuesta.Text.Trim();
            string email = ObjPregunta.txtEmail.Text.Trim();
            string nuevaContrasena = ObjPregunta.txtContrasena.Text.Trim();

            if (codigoIngresado != codigoVerificacion)
            {
                MessageBox.Show("El código de verificación es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DAOPreguntaContra dAOContrasena = new DAOPreguntaContra();

                bool esValido = dAOContrasena.ValidarPreguntaRespuestaSeguridad(email, pregunta, respuesta);

                if (esValido == false)
                {
                    MessageBox.Show("La pregunta de seguridad o la respuesta son incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (esValido == true) {
                 CommonClass common = new CommonClass();
                string cadenaencriptada = common.ComputeSha256Hash(nuevaContrasena);

                dAOContrasena.Contrasena = cadenaencriptada;
                dAOContrasena.Email = email;

                int valorRetornado = dAOContrasena.ActualizarContra();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargoInicial(object sender, EventArgs e)
        {
            DAOPreguntaContra objAdmin = new DAOPreguntaContra();
            try
            {
                DataSet dsPreguntas = objAdmin.ComboBoxPreguntas();
                if (dsPreguntas != null && dsPreguntas.Tables.Contains("Preguntas"))
                {

                    DataTable dtPreguntas = dsPreguntas.Tables["Preguntas"];
                    ObjPregunta.cbPregunta.DataSource = dtPreguntas;
                    ObjPregunta.cbPregunta.ValueMember = "preguntaID";
                    ObjPregunta.cbPregunta.DisplayMember = "tituloPregunta";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    public String GenerarCodigo()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string sixDigitNumber = randNum.ToString("D6");

            return sixDigitNumber;
        }
    }
}
