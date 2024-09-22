using PTC.Controller.Common;
using PTC.Vista.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Servidor
{
    internal class ControllerContraServidor
    {

        ViewContraConexion ObjViewContra;
        private string usuario;
        public ControllerContraServidor(ViewContraConexion vista)
        {
            ObjViewContra = vista;
            
            ObjViewContra.btnConfirmar.Click += new EventHandler(VerificarPassword);
        }

        public void VerificarPassword(object sender, EventArgs e)
        {
            CommonClass common = new CommonClass();
            string usuario = SessionVar.Usuario;
            string cadenaencriptada = common.ComputeSha256Hash(ObjViewContra.txtPassword.Text);
            if (cadenaencriptada == SessionVar.Contrasena)
            {
                ViewConexion ObjViewConexion = new ViewConexion(2);
                ObjViewConexion.ShowDialog();
                ObjViewContra.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado, las credenciales no tienen los permisos suficientes.", "Error al validar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
