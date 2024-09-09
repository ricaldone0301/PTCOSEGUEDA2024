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
            // Verifica que su longitud sea al menos de 8 caracteres
            if (password.Length < 8)
            {
                return false;
            }
            // Verifica si la contraseña contiene al menos un numero.
            bool tieneNumeros = password.Any(char.IsDigit);
            if (!tieneNumeros)
            {
                return false;
            }
            // Verifica si la contraseña contiene al menos un caracter especial.
            bool tieneCaracterEsp = password.Any(ch => "!@#$%^&*()_+[]{}|;:',.<>?/~`".Contains(ch));
            if (!tieneCaracterEsp)
            {
                // Si la contraseña no contiene ningún carácter especial, no es válida.
                return false;
            }
            // Si la contraseña cumple con todos los requisitos entonces devuelve verdadero.
            return true;
        }

        public void Realizar(object sender, EventArgs e)
        {
            //Se obtiene la contraseña desde un TextBox.
            string password = ObjCambiarContra.TxtContra.Text;
            //Se valida la contraseña para asegurarse de que cumpla conlos  requisitos.
            if (!ValidatePassword(password))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir al menos un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Si la contraseña es válida se verifica si el usuario y la contraseña no están vacíos.
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
                    //Si las credenciales son correctas, se cambia la contraseña.
                    if (!(string.IsNullOrEmpty(objUsuario.Contrasena = SessionVar.NuevaContra)))
                    {
                        objUsuario.Usuario = SessionVar.Usuario;
                        objUsuario.Contrasena = SessionVar.NuevaContra;

                        objUsuario.CambiarContra();
                        MessageBox.Show("Las credenciales son correctas, contrasea cambiada.", "Cambio de contrasea exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObjCambiarContra.Hide();
                    }
                    //Si la contraseña no pudo ser cambiada, se muestra una advertencia.
                    else if (answer == false)
                    {
                        MessageBox.Show("Las credenciales son correctas, pero la contrasea no pudo ser cambiada.", "Cambio de contrasea interrumpido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        //Si las credenciales son incorrectas, se muestra un mensaje de error.
                        MessageBox.Show("Credenciales incorectas, verifique que las credenciales pertenezcan a un administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
        }
    }
}
