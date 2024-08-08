using PTC.Modelo.DAORegistro;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC.Vista.OlvidoContrasena;
using PTC.Modelo.DAOContrasena;
using PTC.Modelo.DTORegistro;
using PTC.Controller.Common;

namespace PTC.Controller
{
    class ControllerContrasena
    {
        ViewOlvidoContrasena ObjContrasena;


        private string verificationCode = string.Empty;

        public ControllerContrasena(ViewOlvidoContrasena Vista)
        {
            ObjContrasena = Vista;
            ObjContrasena.btnEnviar.Click += new EventHandler(ConseguirCorreo);
            ObjContrasena.btnEnviar1.Click += new EventHandler(ActualizarContrasena);
            ObjContrasena.timevcode.Tick += new EventHandler(Tick);
        }

        public void ConseguirCorreo(object sender, EventArgs e)
        {
            string to, from, pass;

            verificationCode = generateCode();

            to = ObjContrasena.txtEmail.Text;
            from = "clinicadentalosegueda01@gmail.com";
            pass = "aops ysuj qrda jfkm";
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

        public void ActualizarContrasena(object sender, EventArgs e)
        {
            string inputCode = ObjContrasena.txtConfirm.Text.Trim();

            if (inputCode == verificationCode)
            {
                try
                {
                    DAOContrasena dAOContrasena = new DAOContrasena();
                    CommonClass common = new CommonClass();
                    string cadenaencriptada = common.ComputeSha256Hash(ObjContrasena.txtContrasena.Text);
                    dAOContrasena.Contrasena = cadenaencriptada;
                    dAOContrasena.Email = ObjContrasena.txtEmail.Text.Trim();

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

        public void Tick(object sender, EventArgs e)
        {
            int vCode = 1000;

            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }

        }

        public String generateCode()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string sixDigitNumber = randNum.ToString("D6");

            return sixDigitNumber;
        }

    }
}
