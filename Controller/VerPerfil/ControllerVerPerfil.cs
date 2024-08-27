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
        ViewCambiarContra ObjCambiarContra;
        private int accion;
        private string rol;
        private int intentosFallidos;

        public ControllerVerPerfil(ViewVerContra View)
        {
            ObjVerContra = View;
            ObjVerContra.Load += new EventHandler(CargoInicial);
            ObjVerContra.txtNombre.Text = SessionVar.Nombre;
            ObjVerContra.txtUsuario.Text = SessionVar.Usuario;
            ObjVerContra.txtContrasena.Text = SessionVar.Contrasena;
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CambiarContra(object sender, EventArgs e)
        {
            DAOLogin DAOData = new DAOLogin();
            CommonClass common = new CommonClass();
            DAOData.Usuario = ObjVerContra.txtUsuario.Text;
            DAOData.UsuarioNormal = DAOData.Usuario;
            string cadenaencriptada = common.ComputeSha256Hash(ObjVerContra.txtContrasena.Text);
            DAOData.Contrasena = cadenaencriptada;
            ViewCambiarContra vistacambiarcontra = new ViewCambiarContra();
            vistacambiarcontra.ShowDialog();

        }
    }
}


