using PTC.Controller.Common;
using PTC.Modelo.DAOContrasena;
using PTC.Modelo.DAOLogin;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.RecuperarContra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.CambiarAdminContra
{
    internal class ControllerCambiarAdminContra
    {
        ViewCambiarContra ObjCambiarContra;
        public ControllerCambiarAdminContra(ViewCambiarContra View)
        {
            ObjCambiarContra = View;
            ObjCambiarContra.BtnIngresar.Click += new EventHandler(Realizar);
        }

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

        public void Realizar(object sender, EventArgs e)
        {
            string password = ObjCambiarContra.TxtContra.Text;
            if (!ValidatePassword(password))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir al menos un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(string.IsNullOrEmpty(ObjCambiarContra.TxtUsuario.Text)) ||
    string.IsNullOrEmpty(ObjCambiarContra.TxtContra.Text))
            {

                DAOUsuarios objUsuario = new DAOUsuarios();
                DAOLogin objUsuarioLogin = new DAOLogin();
                CommonClass common = new CommonClass();
                objUsuario.Usuario = ObjCambiarContra.TxtUsuario.Text;
                string cadenaencriptada = common.ComputeSha256Hash(ObjCambiarContra.TxtContra.Text);
                objUsuario.Contrasena = cadenaencriptada;


                bool answer = objUsuario.VerificarCredenciales();



                if (answer == true)
                {
                    if (!(string.IsNullOrEmpty(objUsuario.Contrasena = SessionVar.NuevaContra)))
                    {
                        objUsuario.Usuario = SessionVar.Usuario;
                        objUsuario.Contrasena = SessionVar.NuevaContra;

                        objUsuario.CambiarContra();
                        MessageBox.Show("Las credenciales son correctas, contrasea cambiada.", "Cambio de contrasea exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObjCambiarContra.Hide();
                    }
                    else if (answer == false)
                    {
                        MessageBox.Show("Las credenciales son correctas, pero la contrasea no pudo ser cambiada.", "Cambio de contrasea interrumpido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorectas, verifique que las credenciales pertenezcan a un administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
        }
    }
}
