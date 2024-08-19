using PTC.Controller.Common;
using PTC.Modelo.DAOLogin;
using PTC.Vista.Dashboard;
using PTC.Vista.RecuperarContra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.RecuperarContra
{
    internal class ControllerRecuperarContra
    {
        ViewRecuperarContra ObjViewRecuperarContra;

        int intentosFallidos;
        private void DataAccess(object sender, EventArgs e)
        {

            DAOLogin DAOData = new DAOLogin();
            CommonClass common = new CommonClass();
            string cadenaencriptada = common.ComputeSha256Hash(ObjViewRecuperarContra.TxtContra.Text);
            DAOData.Contrasena = cadenaencriptada;


            bool answer = DAOData.Login();


            if (answer == true)
            {
                intentosFallidos = 0;
                ViewDashboard viewDashboard = new ViewDashboard();
                viewDashboard.Show();
                ObjViewRecuperarContra.Hide();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Credenciales incorectas", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Ha superado el número máximo de intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IntroducirUsuario(object sender, EventArgs e)
        {
            if (ObjViewRecuperarContra.TxtUsuario.Text.Trim().Equals("Usuario"))
            {
                ObjViewRecuperarContra.TxtUsuario.Clear();
            }
        }

        private void LeaveUsuario(object sender, EventArgs e)
        {
            if (ObjViewRecuperarContra.TxtUsuario.Text.Trim().Equals(""))
            {
                ObjViewRecuperarContra.TxtUsuario.Text = "Usuario";
            }
        }

        private void IntroducirContrasena(object sender, EventArgs e)
        {
            if (ObjViewRecuperarContra.TxtContra.Text.Trim().Equals("Contraseña"))
            {
                ObjViewRecuperarContra.TxtContra.Clear();
                ObjViewRecuperarContra.TxtContra.PasswordChar = '*';
                ObjViewRecuperarContra.TxtContra.UseSystemPasswordChar = true;
            }
        }

        private void LeaveContrasena(object sender, EventArgs e)
        {
            if (ObjViewRecuperarContra.TxtContra.Text.Trim().Equals(""))
            {
                ObjViewRecuperarContra.TxtContra.Text = "Contraseña";
                ObjViewRecuperarContra.TxtContra.PasswordChar = '\0';
            }
        }
    }
}
