using PTC.Modelo.DAOLogin;
using PTC.Vista.Dashboard;
using PTC.Vista.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PTC.Controller.Login.ControllerLogin;


namespace PTC.Controller.Login
{
    public class ControllerLogin
    {
            private ViewLogin ObjLogin;

        public ControllerLogin(ViewLogin Vista)
        {
            ObjLogin = Vista;
            ObjLogin.TxtUsuario.Enter += new EventHandler(EnterUsername);
            ObjLogin.TxtUsuario.Leave += new EventHandler(LeaveUsername);

            ObjLogin.TxtContra.Enter += new EventHandler(EnterPassword);
            ObjLogin.TxtContra.Leave += new EventHandler(LeavePassword);

            ObjLogin.BtnIngresar.Click += (sender, e) => DataAccess(sender, e);
        }
        private void DataAccess(object sender, EventArgs e)
        {
            DAOLogin DAOData = new DAOLogin();
            DAOData.Usuario = ObjLogin.TxtUsuario.Text;
            DAOData.Contraseña = ObjLogin.TxtContra.Text;

            int answer = DAOData.Login();

            if (answer == 1)
            {
                ViewDashboard viewDashboard = new ViewDashboard();
                viewDashboard.Show();
                ObjLogin.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorectas", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnterUsername(object sender, EventArgs e)
        {
            if (ObjLogin.TxtUsuario.Text.Trim().Equals("Usuario"))
            {
                ObjLogin.TxtUsuario.Clear();
            }
        }

        private void LeaveUsername(object sender, EventArgs e)
        {
            if (ObjLogin.TxtUsuario.Text.Trim().Equals(""))
            {
                ObjLogin.TxtUsuario.Text = "Usuario";
            }
        }

        private void EnterPassword(object sender, EventArgs e)
        {
            if (ObjLogin.TxtContra.Text.Trim().Equals("Contraseña"))
            {
                ObjLogin.TxtContra.Clear();
                ObjLogin.TxtContra.PasswordChar = '*';
                ObjLogin.TxtContra.UseSystemPasswordChar = true;
            }
        }

        private void LeavePassword(object sender, EventArgs e)
        {
            if (ObjLogin.TxtContra.Text.Trim().Equals(""))
            {
                ObjLogin.TxtContra.Text = "Contraseña";
                ObjLogin.TxtContra.PasswordChar = '\0';
            }
        }
    }
}
  

