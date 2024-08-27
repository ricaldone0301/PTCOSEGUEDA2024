using PTC.Controller.Common;
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
        private int accion;
        private string rol;
        private int intentosFallidos;
        public ControllerCambiarAdminContra(ViewCambiarContra View)
        {
            ObjCambiarContra = View;
            ObjCambiarContra.BtnIngresar.Click += new EventHandler(Realizar);
        }

        public void Realizar(object sender, EventArgs e)
        {
            DAOUsuarios objUsuario = new DAOUsuarios();
            CommonClass common = new CommonClass();
            objUsuario.Usuario = ObjCambiarContra.TxtUsuario.Text;
            string cadenaencriptada = common.ComputeSha256Hash(ObjCambiarContra.TxtContra.Text);
            objUsuario.Contrasena = cadenaencriptada;


            bool answer = objUsuario.VerificarCredenciales();



            if (answer == true)
            {
                if (objUsuario.CambiarContra() == 1)
                {
                    MessageBox.Show("Las credenciales son correctas, contrasea cambiada.", "Cambio de contrasea exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjCambiarContra.Hide();
                }
                else
                {
                    MessageBox.Show("Las credenciales son correctas, pero la contrasea no pudo ser cambiada.", "Cambio de contrasea interrumpido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorectas, verifique que las credenciales pertenezcan a un administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
