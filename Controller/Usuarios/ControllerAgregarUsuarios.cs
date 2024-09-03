using PTC.Controller.Common;
using PTC.Modelo.DAORegistro;
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

        private int accion;
        private string rol;
        private int personalId;

        public ControllerAgregarusuario(ViewAgregarUsuario Vista, int accion)
        {
            //Se asocia la vista crea un parametro como objecto local
            ObjAgregarUsuario = Vista;
            //Se establece el tipo de accion a realizar.
            this.accion = accion;
            //llama al metodo para que verifica la accion.
            verificarAccion();
            //Es la carga inicial cuando se abre la vista
            ObjAgregarUsuario.Load += new EventHandler(CargoInicial);
            //Al dar click en el boton agregar se llama al evento nuevo.
            ObjAgregarUsuario.btnAgregar.Click += new EventHandler(Nuevo);
        }
        public ControllerAgregarusuario(ViewAgregarUsuario Vista, int accion, string Nombre, string PersonalID,int Rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email, int preguntaID, string respuesta)
        {
            ObjAgregarUsuario = Vista;
            this.accion = accion;
            //llena la vista con los valores del usuario que se va a actualizar.
            ObjAgregarUsuario.Load += new EventHandler(CargoInicial);
            verificarAccion();
            CargaValues(Vista, accion, Nombre, PersonalID, Rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email, preguntaID, respuesta);
            this.personalId = int.Parse(PersonalID.ToString());
            //Al dar click al botn de actualizar se llama al metodo actualizarregistro.
            ObjAgregarUsuario.btnActualizar.Click += new EventHandler(ActualizarRegistro);
        }

        //En este metodo se encarga de la configuracion inicial de la vista cuando se carga para llenar de informacion varios controles especificamente combobox.
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


                DataSet dsPreguntas = objAdmin.ComboBoxPreguntas();
                if (dsPreguntas != null && dsPreguntas.Tables.Contains("Preguntas"))
                {
                    DataTable dtPreguntas = dsPreguntas.Tables["Preguntas"];
                    ObjAgregarUsuario.cbPregunta.DataSource = dtPreguntas;
                    ObjAgregarUsuario.cbPregunta.ValueMember = "preguntaID";
                    ObjAgregarUsuario.cbPregunta.DisplayMember = "tituloPregunta";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
        }

        //Este metodo verifica las acciones especificas como agreggar o actualizar.
        public void verificarAccion()
        {
            //Si es 1 se hace el btn agregar se deshabilita el btn actualizar
            if (accion == 1)
            {
                ObjAgregarUsuario.btnAgregar.Enabled = true;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
            }// Viceversa
            else if (accion == 2)
            {
                ObjAgregarUsuario.btnAgregar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = true;
               // ObjAgregarUsuario.txtUsuario.Enabled = false;
            }
            else if (accion == 3)
            {
                ObjAgregarUsuario.btnAgregar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
                ObjAgregarUsuario.txtUsuario.Enabled = false;
                ObjAgregarUsuario.txtContrasena.Enabled = false;
                ObjAgregarUsuario.txtNombre.Enabled = false;
                ObjAgregarUsuario.txtTelefono.Enabled = false;
                ObjAgregarUsuario.txtEmail.Enabled = false;
                ObjAgregarUsuario.cbConsul.Enabled = false;
                ObjAgregarUsuario.cbEsp.Enabled = false;
                ObjAgregarUsuario.cbRol.Enabled = false;
            }
        }

        //En este metodo se utiliza cuando  hacemos click en registrar un usuario
        public void Nuevo(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(ObjAgregarUsuario.txtNombre.Text.Trim()) ||
       string.IsNullOrEmpty(ObjAgregarUsuario.txtTelefono.Text.Trim()) ||
       string.IsNullOrEmpty(ObjAgregarUsuario.txtUsuario.Text.Trim()) ||
       string.IsNullOrEmpty(ObjAgregarUsuario.txtContrasena.Text.Trim()) ||
       string.IsNullOrEmpty(ObjAgregarUsuario.txtEmail.Text.Trim())))

                {

                    //Se crea la instancia del dao para que interactue con la base de datows
                    DAOUsuarios daoAdmin = new DAOUsuarios();
                    //Extrae los datos del formulario.
                    CommonClass commonClass = new CommonClass();

                    daoAdmin.Nombre = ObjAgregarUsuario.txtNombre.Text.Trim();
                    daoAdmin.EspecialidadId = (int)ObjAgregarUsuario.cbEsp.SelectedValue;
                    daoAdmin.Telefono = ObjAgregarUsuario.txtTelefono.Text.Trim();
                    daoAdmin.ConsultorioId = (int)ObjAgregarUsuario.cbConsul.SelectedValue;
                    daoAdmin.Usuario = ObjAgregarUsuario.txtUsuario.Text.Trim();
                    daoAdmin.Contrasena = commonClass.ComputeSha256Hash(ObjAgregarUsuario.txtContrasena.Text.Trim());
                    daoAdmin.Rol = int.Parse(ObjAgregarUsuario.cbRol.SelectedValue.ToString());
                    daoAdmin.Email = ObjAgregarUsuario.txtEmail.Text.Trim();
                    daoAdmin.PreguntaID = (int)ObjAgregarUsuario.cbPregunta.SelectedValue;
                    daoAdmin.Respuesta = ObjAgregarUsuario.txtRespuesta.Text.Trim();

                    //Registra al usuario en la base de datos.
                    //Si fue exitoso retorana 1 cy si no retorna 2 que no fueron exitosos
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRU001: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        //Este metodo se activ cuan hemos dado click al botn actualizar
        public void ActualizarRegistro(object sender, EventArgs e)
        {

            CommonClass commonClass = new CommonClass();
            //Se crea la instancia del dao que gestiona las operaciones en la base 
            DAOUsuarios daoUpdate = new DAOUsuarios();
            //Asigna y captura los datos al dao
            daoUpdate.Nombre = ObjAgregarUsuario.txtNombre.Text.Trim();
            daoUpdate.PersonalId = personalId;
            daoUpdate.EspecialidadId = (int)ObjAgregarUsuario.cbEsp.SelectedValue;
            daoUpdate.Telefono = ObjAgregarUsuario.txtTelefono.Text.Trim();
            daoUpdate.ConsultorioId = (int)ObjAgregarUsuario.cbConsul.SelectedValue;
            daoUpdate.Usuario = ObjAgregarUsuario.txtUsuario.Text.Trim();
            daoUpdate.Contrasena = commonClass.ComputeSha256Hash(ObjAgregarUsuario.txtContrasena.Text.Trim());
            daoUpdate.Rol = int.Parse(ObjAgregarUsuario.cbRol.SelectedValue.ToString());
            daoUpdate.Email = ObjAgregarUsuario.txtEmail.Text.Trim();
            daoUpdate.PreguntaID = (int)ObjAgregarUsuario.cbPregunta.SelectedValue;
            daoUpdate.Respuesta = ObjAgregarUsuario.txtRespuesta.Text.Trim();
            //Envia la consulta al sql para que actualice los datos y si la accion es 1 es exitosa y si no es 2.
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

        //Este metodo carga los valores ya actualizados en la vista.
        public void CargaValues(ViewAgregarUsuario Vista, int accion, string Nombre, string PersonalID, int Rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email, int preguntaID, string respuesta)
        {
            ObjAgregarUsuario.txtNombre.Text = Nombre;
            ObjAgregarUsuario.txtEmail.Text = PersonalID.ToString();
            ObjAgregarUsuario.txtTelefono.Text = Telefono;
            ObjAgregarUsuario.txtUsuario.Text = UsuarioPersonal;
            ObjAgregarUsuario.txtContrasena.Text = contraseñaPersonal;
            ObjAgregarUsuario.txtEmail.Text = email;
            ObjAgregarUsuario.txtRespuesta.Text = respuesta;

        }
    }
}
