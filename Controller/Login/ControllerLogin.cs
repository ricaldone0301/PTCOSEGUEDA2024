using PTC.Controller.Common;
using PTC.Modelo.DAOLogin;
using PTC.Vista.Dashboard;
using PTC.Vista.Login;
using PTC.Vista.OlvidoContrasena;
//using PTC.Vista.Pacientes;
using PTC.Vista.Registro;
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
        private int intentosFallidos = 0;

        public ControllerLogin(ViewLogin Vista)
        {
            ObjLogin = Vista;
            ObjLogin.TxtUsuario.Enter += new EventHandler(EnterUsername);
            ObjLogin.TxtUsuario.Leave += new EventHandler(LeaveUsername);

            ObjLogin.TxtContra.Enter += new EventHandler(EnterPassword);
            ObjLogin.TxtContra.Leave += new EventHandler(LeavePassword);
            ObjLogin.BtnRegistro.Click += new EventHandler(Registro);
            ObjLogin.btnOlvido.Click += new EventHandler(ContrasenaOlvidada);

            ObjLogin.BtnIngresar.Click += (sender, e) => DataAccess(sender, e);

            //ObjLogin.TxtUsuario.Text = "test2";
            //ObjLogin.TxtContra.Text = "test2";
        }

        private void Registro(object sender, EventArgs e)
        {
            ViewRegistro viewRegistro = new ViewRegistro();
            viewRegistro.ShowDialog();

        }

        private void ContrasenaOlvidada(object sender, EventArgs e)
        {
            ViewOlvidoContrasena viewOlvidoContrasena = new ViewOlvidoContrasena();
            viewOlvidoContrasena.ShowDialog();

        }
        private void DataAccess(object sender, EventArgs e)
        {

            DAOLogin DAOData = new DAOLogin();
            CommonClass common = new CommonClass();
            DAOData.Usuario = ObjLogin.TxtUsuario.Text;
            string cadenaencriptada = common.ComputeSha256Hash(ObjLogin.TxtContra.Text);
            DAOData.Contrasena = cadenaencriptada;


            bool answer = DAOData.Login();


            if (answer == true)
            {
                intentosFallidos = 0;
                ViewDashboard viewDashboard = new ViewDashboard();
                viewDashboard.Show();
                ObjLogin.Hide();
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


