using PTC.Controller.Common;
using PTC.Modelo.DAOLogin;
using PTC.Vista.ContraLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.LoginContra
{
    internal class ControllerLoginContra
    {
        ViewContraLogin ObjContraLogin;
        public ControllerLoginContra(ViewContraLogin Vista1)
        {
            ObjContraLogin = Vista1;

            ObjContraLogin = Vista1;
            ObjContraLogin.BtnIngresar.Click += new EventHandler(CambiarContra);
        }

        private void CambiarContra(object sender, EventArgs e)
        {
            try
            {
                DAOLogin DAOData = new DAOLogin();
                CommonClass common = new CommonClass();

                // Asigna el usuario y la nueva contraseña en el DAO
                DAOData.Usuario = ObjContraLogin.TxtUsuario.Text;
                string cadenaEncriptada = common.ComputeSha256Hash(ObjContraLogin.TxtContra.Text);
                DAOData.Contrasena = cadenaEncriptada;

                // Llama al método CambiarContra pasando la nueva contraseña y el usuario
                int cambiarContra = DAOData.CambiarContra();

                // Verifica el resultado y proporciona retroalimentación al usuario
                if (cambiarContra == 1)
                {
                    MessageBox.Show("La contraseña se ha cambiado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al cambiar la contraseña. Por favor, inténtelo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones para cualquier error inesperado
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }
    }
}
