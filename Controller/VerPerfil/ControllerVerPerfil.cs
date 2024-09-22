using PTC.Controller.Common;
using PTC.Modelo.DAOLogin;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.Dashboard;
using PTC.Vista.RecuperarContra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.VerPerfil
{
    internal class ControllerVerPerfil
    {
        ViewVerContra ObjVerContra;
        private int accion;
        private string rol;

        public ControllerVerPerfil(ViewVerContra View)
        {
            ObjVerContra = View;
            ObjVerContra.Load += new EventHandler(CargoInicial);
            ObjVerContra.txtNombre.Text = SessionVar.Nombre;
            ObjVerContra.txtUsuario.Text = SessionVar.Usuario;
            ObjVerContra.txtEmail.Text = SessionVar.Email;
            ObjVerContra.cbConsul.Text = SessionVar.NombreConsul;
            ObjVerContra.cbEsp.Text = SessionVar.NombreEsp;
            ObjVerContra.cbRol.Text = SessionVar.Rol;
            ObjVerContra.txtTelefono.Text = SessionVar.Telefono;

            ObjVerContra.txtUsuario.Enabled = false;
            ObjVerContra.txtNombre.Enabled = false;
            ObjVerContra.txtTelefono.Enabled = false;
            ObjVerContra.txtEmail.Enabled = false;
            ObjVerContra.cbConsul.Enabled = false;
            ObjVerContra.cbEsp.Enabled = false;
            ObjVerContra.cbRol.Enabled = false;

            ObjVerContra.btnActualizar.Click += new EventHandler(CambiarContra);
        }


        public void CargoInicial(object sender, EventArgs e)
        {
            try
            {
                //Se crea la instancia  del daousuarios para manejar la interaccion con la base de datos.
                //Se cargan todos los DataSet.
                DAOUsuarios objAdmin = new DAOUsuarios();

                DataSet dsRoles = objAdmin.ComboBoxRoles();
                if (dsRoles != null && dsRoles.Tables.Contains("Roles"))
                {
                    DataTable dtRoles = dsRoles.Tables["Roles"];
                    ObjVerContra.cbRol.DataSource = dtRoles;
                    ObjVerContra.cbRol.ValueMember = "roleID";
                    ObjVerContra.cbRol.DisplayMember = "nombreRol";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtRoles.Select($"nombreRol = '{rol}'");
                        if (rows.Length > 0)
                        {
                            ObjVerContra.cbRol.Text = rows[0]["nombreRol"].ToString();
                        }
                    }
                }
                DataSet dsEspecialidad = objAdmin.ComboBoxEspecialidad();
                if (dsEspecialidad != null && dsEspecialidad.Tables.Contains("Especialidad"))
                {
                    DataTable dtEspecialidad = dsEspecialidad.Tables["Especialidad"];
                    ObjVerContra.cbEsp.DataSource = dtEspecialidad;
                    ObjVerContra.cbEsp.ValueMember = "especialidadID";
                    ObjVerContra.cbEsp.DisplayMember = "nombreEspecialidad";
                }

                DataSet dsConsultorio = objAdmin.ComboBoxConsultorio();
                if (dsConsultorio != null && dsConsultorio.Tables.Contains("Consultorio"))
                {
                    DataTable dtConsultorio = dsConsultorio.Tables["Consultorio"];
                    ObjVerContra.cbConsul.DataSource = dtConsultorio;
                    ObjVerContra.cbConsul.ValueMember = "consultorioID";
                    ObjVerContra.cbConsul.DisplayMember = "nombreConsultorio";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#001: Error al cargar valores" + ex.Message);
            }
        }

        //Se hace la validacion de contra si no cumple con los tres requisitos
        //Retorna falso
        private bool ValidarContra(string password)
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

        //Este metodo sirve para cambiar la contrasena
        public void CambiarContra(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(ObjVerContra.txtContrasenaNueva.Text.Trim())))

            {
                string contrasena = ObjVerContra.txtContrasenaNueva.Text;
                if (!ValidarContra(contrasena))
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir al menos un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                try
                {
                    DAOLogin DAOData = new DAOLogin();
                    DAOUsuarios dAOUsuarios = new DAOUsuarios();

                    CommonClass common = new CommonClass();


                    DAOData.Usuario = ObjVerContra.txtUsuario.Text;
                    DAOData.Contrasena = ObjVerContra.txtContrasenaNueva.Text;

                    string cadenaencriptada = common.ComputeSha256Hash(ObjVerContra.txtContrasenaNueva.Text);
                    DAOData.Contrasena = cadenaencriptada;

                    SessionVar.NuevaContra = cadenaencriptada;


                    ViewCambiarContra vistacambiarcontra = new ViewCambiarContra();
                    vistacambiarcontra.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error OS#004: No se pudo actualizar la contraseña" + ex.Message);

                }
            }

        } 
    }
} 



