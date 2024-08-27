using PTC.Controller.Common;
using PTC.Modelo.DAORegistro;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC.Modelo.DAOPrimerUso;
using PTC.Vista;
using PTC.Vista.Login;
using PTC.Vista.PrimerUso;

namespace PTC.Controller.PrimerUso
{
    internal class ControllerPrimerUso
    {
        ViewPrimerUso ObjRegistro;
        ViewPrimerUsoInfo ObjRegistroEmpresa;

        private string rol;

        //private ViewRegistro viewRegistro;
        public ControllerPrimerUso(ViewPrimerUso Vista)
        {
            ObjRegistro = Vista;
            ObjRegistro.Load += new EventHandler(CargoInicial);
            ObjRegistro.btnEnviar1.Click += new EventHandler(VerificarCodigoYRegistrar);

        }

        public ControllerPrimerUso(ViewPrimerUsoInfo Vista1)
        {
            ObjRegistroEmpresa = Vista1;
            ObjRegistroEmpresa.btnEnviar1.Click += new EventHandler(RegistrarEmpresa);
        }


        public void CargoInicial(object sender, EventArgs e)
        {
            try
            {
                DAOPrimerUso objAdmin = new DAOPrimerUso();

                DataSet dsRoles = objAdmin.ComboBoxRoles();
                if (dsRoles != null && dsRoles.Tables.Contains("ViewPrimer"))
                {
                    DataTable dtRoles = dsRoles.Tables["ViewPrimer"];
                    ObjRegistro.cbRol.DataSource = dtRoles;
                    ObjRegistro.cbRol.ValueMember = "roleID";
                    ObjRegistro.cbRol.DisplayMember = "nombreRol";


                    DataRow[] rows = dtRoles.Select($"nombreRol = '{rol}'");
                    if (rows.Length > 0)
                    {
                        ObjRegistro.cbRol.Text = rows[0]["nombreRol"].ToString();
                    }

                }
                DataSet dsEspecialidad = objAdmin.ComboBoxEspecialidad();
                if (dsEspecialidad != null && dsEspecialidad.Tables.Contains("Especialidad"))
                {
                    DataTable dtEspecialidad = dsEspecialidad.Tables["Especialidad"];
                    ObjRegistro.cbEsp.DataSource = dtEspecialidad;
                    ObjRegistro.cbEsp.ValueMember = "especialidadID";
                    ObjRegistro.cbEsp.DisplayMember = "nombreEspecialidad";
                }

                DataSet dsConsultorio = objAdmin.ComboBoxConsultorio();
                if (dsConsultorio != null && dsConsultorio.Tables.Contains("Consultorio"))
                {
                    DataTable dtConsultorio = dsConsultorio.Tables["Consultorio"];
                    ObjRegistro.cbConsul.DataSource = dtConsultorio;
                    ObjRegistro.cbConsul.ValueMember = "consultorioID";
                    ObjRegistro.cbConsul.DisplayMember = "nombreConsultorio";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void VerificarCodigoYRegistrar(object sender, EventArgs e)
        {

            try
            {
                ViewLogin viewLogin = new ViewLogin();
                DAORegistro daoRegistro = new DAORegistro();
                CommonClass common = new CommonClass();
                daoRegistro.Nombre = ObjRegistro.txtNombre.Text.Trim();
                daoRegistro.EspecialidadId = (int)ObjRegistro.cbEsp.SelectedValue;
                daoRegistro.Telefono = ObjRegistro.txtTelefono.Text.Trim();
                daoRegistro.ConsultorioId = (int)ObjRegistro.cbConsul.SelectedValue;
                daoRegistro.Usuario = ObjRegistro.txtUsuario.Text.Trim();
                daoRegistro.Contrasena = common.ComputeSha256Hash(ObjRegistro.txtUsuario.Text.Trim() + "OS1");
                daoRegistro.Rol = int.Parse(ObjRegistro.cbRol.SelectedValue.ToString());
                daoRegistro.Email = ObjRegistro.txtEmail.Text.Trim();

                int valorRetornado = daoRegistro.RegistrarUsuario();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Usuario administrador: {ObjRegistro.txtUsuario.Text.Trim()}\nContraseña de usuario: {ObjRegistro.txtUsuario.Text.Trim()}OS1",
                "Credenciales de acceso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                    viewLogin.Show();
                    ObjRegistro.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegistrarEmpresa(object sender, EventArgs e)
        {

            try
            {
                ViewPrimerUso viewPrimerUso = new ViewPrimerUso();
                ViewPrimerUsoInfo viewEmpresa = new ViewPrimerUsoInfo();
                DAOPrimerUso daoRegistro = new DAOPrimerUso();
                CommonClass common = new CommonClass();
                daoRegistro.EmailEmpresa = ObjRegistroEmpresa.txtEmail.Text.Trim();
                daoRegistro.NombreEmpresa = ObjRegistroEmpresa.txtNombre.Text.Trim();
                daoRegistro.Direccion = ObjRegistroEmpresa.txtDireccion.Text.Trim();
                daoRegistro.TelefonoEmpresa = ObjRegistroEmpresa.txtTelefono.Text.Trim();

                int valorRetornado = daoRegistro.RegistrarEmpresa();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewPrimerUso.Show();
                    ObjRegistroEmpresa.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
        
}