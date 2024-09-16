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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTC.Controller.PrimerUso
{
    internal class ControllerPrimerUso
    {
        ViewPrimerUso ObjRegistro;
        ViewPrimerUsoInfo ObjRegistroEmpresa;

        private string rol;

        //Vista para registrar Usuario
        public ControllerPrimerUso(ViewPrimerUso Vista)
        {
            ObjRegistro = Vista;
            ObjRegistro.Load += new EventHandler(CargoInicial);
            ObjRegistro.btnEnviar1.Click += new EventHandler(RegistrarUsuario);

        }

        //Vista para registrar empresa
        public ControllerPrimerUso(ViewPrimerUsoInfo Vista1)
        {
            ObjRegistroEmpresa = Vista1;
            ObjRegistroEmpresa.btnEnviar1.Click += new EventHandler(RegistrarEmpresa);
        }

        //Cargo inical cargan todooooslosc ombo box
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


                DataSet dsPreguntas = objAdmin.ComboBoxPreguntas();
                if (dsPreguntas != null && dsPreguntas.Tables.Contains("Preguntas"))
                {
                    DataTable dtPreguntas = dsPreguntas.Tables["Preguntas"];
                    ObjRegistro.cbPregunta.DataSource = dtPreguntas;
                    ObjRegistro.cbPregunta.ValueMember = "preguntaID";
                    ObjRegistro.cbPregunta.DisplayMember = "tituloPregunta";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#001: Error al conseguir el cargo inicial" + ex.Message);
            }
        }
        
        //Este metodo registra al usuario
        public void RegistrarUsuario(object sender, EventArgs e)
        {
            //Primero verifica que todos los campos no esten nulos
            try
            {
                if (!(string.IsNullOrEmpty(ObjRegistro.txtNombre.Text.Trim()) ||
    string.IsNullOrEmpty(ObjRegistro.txtTelefono.Text.Trim()) ||
    string.IsNullOrEmpty(ObjRegistro.txtUsuario.Text.Trim()) ||
    string.IsNullOrEmpty(ObjRegistro.txtUsuario.Text.Trim()) ||
    string.IsNullOrEmpty(ObjRegistro.txtEmail.Text.Trim())))
                {
                    ViewLogin viewLogin = new ViewLogin();
                    //Crea objetos del Dao y de la clase commun
                    //Y luego se los asigna a los campos y varaibles
                    DAORegistro daoRegistro = new DAORegistro();
                    CommonClass common = new CommonClass();
                    daoRegistro.Nombre = ObjRegistro.txtNombre.Text.Trim();
                    daoRegistro.EspecialidadId = (int)ObjRegistro.cbEsp.SelectedValue;
                    daoRegistro.Telefono = ObjRegistro.txtTelefono.Text.Trim();
                    daoRegistro.ConsultorioId = (int)ObjRegistro.cbConsul.SelectedValue;
                    daoRegistro.Usuario = ObjRegistro.txtUsuario.Text.Trim();
                    daoRegistro.Contrasena = common.ComputeSha256Hash(ObjRegistro.txtUsuario.Text.Trim() + "OSEGUEDA1");
                    daoRegistro.Rol = int.Parse(ObjRegistro.cbRol.SelectedValue.ToString());
                    daoRegistro.Email = ObjRegistro.txtEmail.Text.Trim();
                    daoRegistro.PreguntaID = int.Parse(ObjRegistro.cbPregunta.SelectedValue.ToString());
                    daoRegistro.Respuesta = ObjRegistro.txtRespuesta.Text.Trim();

                    //el metodo
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#002: Error al registrar usuario" + ex.Message);
            }
        }

        public void RegistrarEmpresa(object sender, EventArgs e)
        {
            //Primero verifica que todos los campos no esten nulos

            try
            {
                if (!(string.IsNullOrEmpty(ObjRegistroEmpresa.txtEmail.Text.Trim()) ||
string.IsNullOrEmpty(ObjRegistroEmpresa.txtNombre.Text.Trim()) ||
string.IsNullOrEmpty(ObjRegistroEmpresa.txtDireccion.Text.Trim()) ||
string.IsNullOrEmpty(ObjRegistroEmpresa.txtTelefono.Text.Trim())))
                {
                    //Crea objetos del Dao y de la clase commun
                    //Y luego se los asigna a los campos y varaibles
                    ViewPrimerUso viewPrimerUso = new ViewPrimerUso();
                    ViewPrimerUsoInfo viewEmpresa = new ViewPrimerUsoInfo();
                    DAOPrimerUso daoRegistro = new DAOPrimerUso();
                    CommonClass common = new CommonClass();
                    daoRegistro.EmailEmpresa = ObjRegistroEmpresa.txtEmail.Text.Trim();
                    daoRegistro.NombreEmpresa = ObjRegistroEmpresa.txtNombre.Text.Trim();
                    daoRegistro.Direccion = ObjRegistroEmpresa.txtDireccion.Text.Trim();
                    daoRegistro.TelefonoEmpresa = ObjRegistroEmpresa.txtTelefono.Text.Trim();
                    //Se ejecuta el metodo

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#008: Error al registrar empresa." + ex.Message);
            }
        }

    }
        
}