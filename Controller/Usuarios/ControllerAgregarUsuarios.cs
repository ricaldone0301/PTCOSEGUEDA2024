using PTC.Controller.Common;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Usuarios
{
    class ControllerAgregarusuario
    {
        ViewAgregarUsuario ObjAgregarUsuario;
        ViewRegistro ObjRegistro;

        private int accion;
        private string rol;
        private int personalId;

        public ControllerAgregarusuario(ViewAgregarUsuario Vista, int accion)
        {
            ObjAgregarUsuario = Vista;
            this.accion = accion;
            verificarAccion();
            ObjAgregarUsuario.Load += new EventHandler(InitialCharge);
            ObjAgregarUsuario.btnAgregar.Click += new EventHandler(NewRegister);
            //ObjRegistro.btnEnviar.Click += new EventHandler(NewRegister);
        }
        public ControllerAgregarusuario(ViewAgregarUsuario Vista, int accion, string Nombre, string PersonalID,int Rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email)
        {
            ObjAgregarUsuario = Vista;
            this.accion = accion;
            ObjAgregarUsuario.Load += new EventHandler(InitialCharge);
            verificarAccion();
            ChargeValues(Vista, accion, Nombre, PersonalID, Rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email);
            this.personalId = int.Parse(PersonalID);
            ObjAgregarUsuario.btnActualizar.Click += new EventHandler(UpdateRegister);
        }

        public void InitialCharge(object sender, EventArgs e)
        {
            try
            {
                DAOUsuarios objAdmin = new DAOUsuarios();

                DataSet dsRoles = objAdmin.ComboBoxRoles();
                if (dsRoles != null && dsRoles.Tables.Contains("Roles"))
                {
                    DataTable dtRoles = dsRoles.Tables["Roles"];
                    ObjAgregarUsuario.cbRol.DataSource = dtRoles;
                    ObjAgregarUsuario.cbRol.ValueMember = "roleID";
                    ObjAgregarUsuario.cbRol.DisplayMember = "nombreRol";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtRoles.Select($"nombreRol = '{rol}'");
                        if (rows.Length > 0)
                        {
                            ObjAgregarUsuario.cbRol.Text = rows[0]["nombreRol"].ToString();
                        }
                    }
                }
                DataSet dsEspecialidad = objAdmin.ComboBoxEspecialidad();
                if (dsEspecialidad != null && dsEspecialidad.Tables.Contains("Especialidad"))
                {
                    DataTable dtEspecialidad = dsEspecialidad.Tables["Especialidad"];
                    ObjAgregarUsuario.cbEsp.DataSource = dtEspecialidad;
                    ObjAgregarUsuario.cbEsp.ValueMember = "especialidadID";
                    ObjAgregarUsuario.cbEsp.DisplayMember = "nombreEspecialidad";
                }

                DataSet dsConsultorio = objAdmin.ComboBoxConsultorio();
                if (dsConsultorio != null && dsConsultorio.Tables.Contains("Consultorio"))
                {
                    DataTable dtConsultorio = dsConsultorio.Tables["Consultorio"];
                    ObjAgregarUsuario.cbConsul.DataSource = dtConsultorio;
                    ObjAgregarUsuario.cbConsul.ValueMember = "consultorioID";
                    ObjAgregarUsuario.cbConsul.DisplayMember = "nombreConsultorio";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    }

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAgregarUsuario.btnAgregar.Enabled = true;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAgregarUsuario.btnAgregar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = true;
                ObjAgregarUsuario.txtUsuario.Enabled = false;
            }
        }

        public void NewRegister(object sender, EventArgs e)
        {
            try
            {
                DAOUsuarios daoAdmin = new DAOUsuarios();
                CommonClass commonClass = new CommonClass();

                daoAdmin.Nombre = ObjAgregarUsuario.txtNombre.Text.Trim();
                daoAdmin.EspecialidadId = (int)ObjAgregarUsuario.cbEsp.SelectedValue;
                daoAdmin.Telefono = ObjAgregarUsuario.txtTelefono.Text.Trim();
                daoAdmin.ConsultorioId = (int)ObjAgregarUsuario.cbConsul.SelectedValue;
                daoAdmin.Usuario = ObjAgregarUsuario.txtUsuario.Text.Trim();
                daoAdmin.Contrasena = commonClass.ComputeSha256Hash(ObjAgregarUsuario.txtContrasena.Text.Trim());
                daoAdmin.Rol = int.Parse(ObjAgregarUsuario.cbRol.SelectedValue.ToString());
                daoAdmin.Email = ObjAgregarUsuario.txtEmail.Text.Trim();

                int valorRetornado = daoAdmin.RegistrarUsuario();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        public void UpdateRegister(object sender, EventArgs e)
        {
            DAOUsuarios daoUpdate = new DAOUsuarios();
            daoUpdate.Nombre = ObjAgregarUsuario.txtNombre.Text.Trim();
            daoUpdate.PersonalId = personalId;
            daoUpdate.EspecialidadId = (int)ObjAgregarUsuario.cbEsp.SelectedValue;
            daoUpdate.Telefono = ObjAgregarUsuario.txtTelefono.Text.Trim();
            daoUpdate.ConsultorioId = (int)ObjAgregarUsuario.cbConsul.SelectedValue;
            daoUpdate.Usuario = ObjAgregarUsuario.txtUsuario.Text.Trim();
            daoUpdate.Contrasena = ObjAgregarUsuario.txtContrasena.Text.Trim();
            daoUpdate.Rol = int.Parse(ObjAgregarUsuario.cbRol.SelectedValue.ToString());
            daoUpdate.Email = ObjAgregarUsuario.txtEmail.Text.Trim();

            int valorRetornado = daoUpdate.ActualizarUsuario();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void ChargeValues(ViewAgregarUsuario Vista, int accion, string Nombre, string PersonalID, int Rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email)
        {
            ObjAgregarUsuario.txtNombre.Text = Nombre;
            ObjAgregarUsuario.txtEmail.Text = PersonalID.ToString();
            ObjAgregarUsuario.txtTelefono.Text = Telefono;
            ObjAgregarUsuario.txtUsuario.Text = UsuarioPersonal;
            ObjAgregarUsuario.txtContrasena.Text = contraseñaPersonal;
            ObjAgregarUsuario.txtEmail.Text = email;


        }
    }
}
