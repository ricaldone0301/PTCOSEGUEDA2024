using PTC.Controller.Common;
using PTC.Modelo.DAOLogin;
using PTC.Modelo.DAOVerPerfil;
using PTC.Vista.Dashboard;
using PTC.Vista.Login;
using PTC.Vista.OlvidoContrasena;
using PTC.Vista.OlvidoPregunta;
using PTC.Vista.RecuperarContra;


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
        private ViewInicio ObjLogin;
        ViewCambiar ObjCambiar;
        private int intentosFallidos = 0;

        public ControllerLogin(ViewInicio Vista)
        {
            ObjLogin = Vista;
            ObjLogin.TxtUsuario.Enter += new EventHandler(IntroducirUsuario);
            ObjLogin.TxtUsuario.Leave += new EventHandler(LeaveUsuario);

            ObjLogin.TxtContra.Enter += new EventHandler(IntroducirContrasena);
            ObjLogin.TxtContra.Leave += new EventHandler(LeaveContrasena);
            ObjLogin.BtnRegistro.Click += new EventHandler(Registro);
            ObjLogin.btnOlvido.Click += new EventHandler(ContrasenaOlvidada);
            ObjLogin.linkLabel1.Click += new EventHandler(ContraPregunta);
            ObjLogin.BtnIngresar.Click += (sender, e) => DataAccess(sender, e);
            ObjCambiar = new ViewCambiar();
            ObjCambiar.BtnIngresar.Click += new EventHandler(CambiarContra);

            //ObjLogin.TxtUsuario.Text = "test2";
            //ObjLogin.TxtContra.Text = "test2";
        }

        public ControllerLogin(ViewCambiar Vista1)
        {
            ObjCambiar = Vista1;
            
            ObjCambiar = new ViewCambiar();
            ObjCambiar.BtnIngresar.Click += new EventHandler(CambiarContra);

            //ObjLogin.TxtUsuario.Text = "test2";
            //ObjLogin.TxtContra.Text = "test2";
        }
            //ObjLogin.TxtUsuario.Text = "test2";
            //ObjLogin.TxtContra.Text = "test2";
        }
        private void ContraPregunta(object sender, EventArgs e)
        {
            ViewOlvidoPregunta viewPregunta = new ViewOlvidoPregunta();
            viewPregunta.ShowDialog();

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

        private void CambiarContra(object sender, EventArgs e)
        {
            try
            {
                DAOLogin DAOData = new DAOLogin();
                CommonClass common = new CommonClass();

                // Asigna el usuario y la nueva contraseña en el DAO
                DAOData.Usuario = ObjLogin.TxtUsuario.Text;
                string cadenaEncriptada = common.ComputeSha256Hash(ObjCambiar.TxtContra.Text);
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

        private void DataAccess(object sender, EventArgs e)
        {
            DAOLogin DAOData = new DAOLogin();
            CommonClass common = new CommonClass();
            DAOData.Usuario = ObjLogin.TxtUsuario.Text;
            DAOData.UsuarioNormal = DAOData.Usuario;
            string cadenaencriptada = common.ComputeSha256Hash(ObjLogin.TxtContra.Text);
            DAOData.Contrasena = cadenaencriptada;


            bool answer = DAOData.Login();
            int respuesta = DAOData.Identificar();
            bool primerLoginStatus = DAOData.PrimerLogin(ObjLogin.TxtUsuario.Text);
            if (primerLoginStatus == false)
            {
                // Show the change password form
                ViewCambiar viewChangePassword = new ViewCambiar();
                viewChangePassword.Show();
            }
            else if (primerLoginStatus == true)
            {
                // Proceed with the login process
                if (answer)
                {
                    intentosFallidos = 0;
                    ViewDashboard viewDashboard = new ViewDashboard();
                    viewDashboard.Show();
                    ObjLogin.Hide();
                }
                else
                {
                    intentosFallidos++;
                    MessageBox.Show("Credenciales incorrectas", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (intentosFallidos >= 3)
                    {
                        ObjLogin.TxtUsuario.Enabled = false;
                        ObjLogin.TxtContra.Enabled = false;
                        ObjLogin.BtnIngresar.Enabled = false;
                        MessageBox.Show("Ha superado el número máximo de intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al obtener el estado del primer login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



    }



    private void IntroducirUsuario(object sender, EventArgs e)
        {
            if (ObjLogin.TxtUsuario.Text.Trim().Equals("Usuario"))
            {
                ObjLogin.TxtUsuario.Clear();
            }
        }

        private void LeaveUsuario(object sender, EventArgs e)
        {
            if (ObjLogin.TxtUsuario.Text.Trim().Equals(""))
            {
                ObjLogin.TxtUsuario.Text = "Usuario";
            }
        }

        private void IntroducirContrasena(object sender, EventArgs e)
        {
            if (ObjLogin.TxtContra.Text.Trim().Equals("Contraseña"))
            {
                ObjLogin.TxtContra.Clear();
                ObjLogin.TxtContra.PasswordChar = '*';
                ObjLogin.TxtContra.UseSystemPasswordChar = true;
            }
        }

        private void LeaveContrasena(object sender, EventArgs e)
        {
            if (ObjLogin.TxtContra.Text.Trim().Equals(""))
            {
                ObjLogin.TxtContra.Text = "Contraseña";
                ObjLogin.TxtContra.PasswordChar = '\0';
            }
        }
    }
}


