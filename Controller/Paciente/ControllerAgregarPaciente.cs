using Microsoft.Win32;
using PTC.Controller.Common;
using PTC.Modelo.DAOOcupacion;
using PTC.Modelo.DAOPaciente;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgregarPaciente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTC.Controller.Paciente
{
    class ControllerAgregarPaciente
    {
        //Objeto de la vista
        ViewAgregarPaciente objAgregarPaciente;

        private int accion;
        private int pacienteID;
        private string ocupacion;

        public ControllerAgregarPaciente(ViewAgregarPaciente Vista, int accion)
        {
            //Eventos
            objAgregarPaciente = Vista;
            this.accion = accion;
            //VerificarAccion();
            //Mientras se carga el formulario, se ejecuta el metodo CargaInicial
            objAgregarPaciente.Load += new EventHandler(CargaInicial);
            //Cuando se le da clic al boton de agregar ocupacion, se ejecuta el metodo MotrarAgregarOcupacion
            objAgregarPaciente.btnAgregarOcupacion.Click += new EventHandler(MostrarAgregarOcupacion);
            //Cuando se le da clic al boton de guardar ocupacion, se ejecuta el metodo NuevaOcupacion
            objAgregarPaciente.btnGuardarOcupacion.Click += new EventHandler(NuevaOcupacion);
            //Cuando se le da clic al ComboBox de ocupacion, se ejecura el metodo RefrescarCombobox
            objAgregarPaciente.cmbOcupacion.Click += new EventHandler(CargaInicial);
            //Cuando se le da clic al boton de guardar paciente, se ejecuta el metodo NuevoExpediente
            objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(NuevoExpediente);
        }


        public ControllerAgregarPaciente(ViewAgregarPaciente vista, int accion, int pacienteID, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
        {
            //Se crea un objeto de la vista
            objAgregarPaciente = vista;
            this.accion = accion;
            this.ocupacion = ocupacion;
            //Mientras el formulario carga, se ejecuta el metodo CargaInicial
            objAgregarPaciente.Load += new EventHandler(CargaInicial);
            //VerificarAccion();
            //Se ejecuta el metodo CargarValores con las variables que se reciben de la vista
            CargarValores(pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
            this.pacienteID = pacienteID;
            if (operacion.Equals("Sí"))
            {
                objAgregarPaciente.cbOperacionSi.Checked = true;
            }
            else
            {
                objAgregarPaciente.cbOperacionNo.Checked = true;
            }

            if (controlmedico.Equals("Sí"))
            {
                objAgregarPaciente.cbControlMedicoSi.Checked = true;
            }
            else
            {
                objAgregarPaciente.cbControlMedicoNo.Checked = true;
            }

            //Cuando se da clic en el boton de guardar paciente, se ejecuta el metodo ActualizarExpediente
            objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(ActualizarExpediente);

        }
        public void NuevaOcupacion(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(objAgregarPaciente.txtNombreOcupacion.Text.Trim())))
                {
                //Se crea un objeto del DAO
                DAOOcupacion daoAdmin = new DAOOcupacion();

                //La variable NombreOcupacion se llena con el texto del txtNombreOcupacion
                daoAdmin.NombreOcupacion = objAgregarPaciente.txtNombreOcupacion.Text.Trim();

                //Se obtiene el resultado que devuelve la clase RegistrarOcupacion del DAO
                int valorRetornado = daoAdmin.RegistrarOcupacion();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("La ocupacion ha sido registrada exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error OS#006: Error al registrar ocupación." + ex.Message);
            }
        }

        public void MostrarAgregarOcupacion(object sender, EventArgs e)
        {
            //Se muetra el groupBox AgregarOcupacion
            objAgregarPaciente.gbAgregarOcupacion.Show();
        }

        public void CargaInicial(object sender, EventArgs e)
        {
            try
            {
                //Se crea un objeto de DAO Ocupaciones
                DAOOcupacion objdao = new DAOOcupacion();

                //Se obtienen los datos del metodo ComboBoxOcupacion
                DataSet dataset = objdao.ComboBoxOcupacion();
                //Se llena el combobox con los datos de la tabla Ocupaciones
                objAgregarPaciente.cmbOcupacion.DataSource = dataset.Tables["Ocupaciones"];
                objAgregarPaciente.cmbOcupacion.ValueMember = "ocupacionID";
                objAgregarPaciente.cmbOcupacion.DisplayMember = "nombreOcupacion";

                if (accion == 2)
                {
                    //Si la accion es 2, el texto de la opcion del combobox seleccionada sera guardada en su variable respectiva
                    objAgregarPaciente.cmbOcupacion.Text = ocupacion;
                }
                else if (accion == 3)
                {
                    objAgregarPaciente.txtCorreoPaciente.Enabled = false;
                    objAgregarPaciente.txtNombrePaciente.Enabled = false;
                    objAgregarPaciente.dtpFechaNac.Enabled = false;
                    objAgregarPaciente.txtDireccionPaciente.Enabled = false;
                    objAgregarPaciente.txtDUI.Enabled = false;
                    objAgregarPaciente.txtMotivoConsulta.Enabled = false;
                    objAgregarPaciente.txtEdadPaciente.Enabled = false;
                    objAgregarPaciente.txtMedicoCabeceraNombre.Enabled = false;
                    objAgregarPaciente.txtNombreAlergiaMedicamento.Enabled = false;
                    objAgregarPaciente.txtNombreEmergencia.Enabled = false;
                    objAgregarPaciente.txtNombreMedicamento.Enabled = false;
                    objAgregarPaciente.txtNombreOcupacion.Enabled = false;
                    objAgregarPaciente.txtPadecimientos.Enabled = false;
                    objAgregarPaciente.txtNumMedicoCabecera.Enabled = false;
                    objAgregarPaciente.txtNumEmergencia.Enabled = false;
                    objAgregarPaciente.txtRecuperacionOperacion.Enabled = false;
                    objAgregarPaciente.txtReferencia.Enabled = false;
                    objAgregarPaciente.txtTelefonoPaciente.Enabled = false;
                    objAgregarPaciente.txtTipoOperacion.Enabled = false;
                    objAgregarPaciente.cbControlMedicoNo.Enabled = false;
                    objAgregarPaciente.cbControlMedicoSi.Enabled = false;
                    objAgregarPaciente.cbOperacionNo.Enabled = false;
                    objAgregarPaciente.cbOperacionSi.Enabled = false;
                    objAgregarPaciente.cmbOcupacion.Enabled = false;


                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error OS#001: Error al hacer el cargo inicial" + ex.Message);
            }

        }
        public void NuevoExpediente(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objAgregarPaciente.txtNombrePaciente.Text.Trim()) ||
      string.IsNullOrEmpty(objAgregarPaciente.txtTelefonoPaciente.Text.Trim()) ||
      string.IsNullOrEmpty(objAgregarPaciente.txtCorreoPaciente.Text.Trim()) ||
            string.IsNullOrEmpty(objAgregarPaciente.txtTelefonoPaciente.Text.Trim()) ||
      string.IsNullOrEmpty(objAgregarPaciente.txtDireccionPaciente.Text.Trim()) ||
            string.IsNullOrEmpty(objAgregarPaciente.txtDUI.Text.Trim()) ||
                  string.IsNullOrEmpty(objAgregarPaciente.txtNombreEmergencia.Text.Trim()) ||
      string.IsNullOrEmpty(objAgregarPaciente.txtNumEmergencia.Text.Trim())))
            {
                //Se crea un objeto del DAO
                DAOPaciente objdao = new DAOPaciente();

                //Se guarda los textos de los textos en sus variables respectivas
                objdao.NombrePaciente = objAgregarPaciente.txtNombrePaciente.Text.Trim();
                objdao.EdadPaciente = int.Parse(objAgregarPaciente.txtEdadPaciente.Text);
                objdao.TelefonoPaciente = objAgregarPaciente.txtTelefonoPaciente.Text.Trim();
                objdao.FechaNac = objAgregarPaciente.dtpFechaNac.Value.Date;
                objdao.CorreoPaciente = objAgregarPaciente.txtCorreoPaciente.Text.Trim();
                objdao.OcupacionID = int.Parse(objAgregarPaciente.cmbOcupacion.SelectedValue.ToString());
                objdao.DireccionPaciente = objAgregarPaciente.txtDireccionPaciente.Text.Trim();
                objdao.DUI1 = objAgregarPaciente.txtDUI.Text.Trim();
                objdao.Referencia = objAgregarPaciente.txtReferencia.Text.Trim();
                objdao.NombreEmergencia = objAgregarPaciente.txtNombreEmergencia.Text.Trim();
                objdao.NumEmergencia = objAgregarPaciente.txtNumEmergencia.Text.Trim();
                objdao.MotivoConsulta = objAgregarPaciente.txtMotivoConsulta.Text.Trim();
                objdao.Padecimientos = objAgregarPaciente.txtPadecimientos.Text.Trim();

                if (objAgregarPaciente.cbControlMedicoSi.Checked == true)
                {
                    objdao.ControlMedico = objAgregarPaciente.cbControlMedicoSi.Text;
                }
                else if (objAgregarPaciente.cbControlMedicoNo.Checked == true)
                {
                    objdao.ControlMedico = objAgregarPaciente.cbControlMedicoNo.Text;
                }
                objdao.MedicoCabeceraNombre = objAgregarPaciente.txtMedicoCabeceraNombre.Text.Trim();
                objdao.NumMedicoCabecera = objAgregarPaciente.txtNumMedicoCabecera.Text.Trim();
                objdao.AlergiaMedicamentos = objAgregarPaciente.txtNombreAlergiaMedicamento.Text.Trim();
                objdao.Medicamentos = objAgregarPaciente.txtNombreMedicamento.Text.Trim();
                if (objAgregarPaciente.cbOperacionSi.Checked == true)
                {
                    objdao.Operacion = objAgregarPaciente.cbOperacionSi.Text;
                }
                else if (objAgregarPaciente.cbOperacionNo.Checked == true)
                {
                    objdao.Operacion = objAgregarPaciente.cbOperacionNo.Text;
                }
                objdao.TipoOperacion = objAgregarPaciente.txtTipoOperacion.Text.Trim();
                objdao.RecuperacionOperacion = objAgregarPaciente.txtRecuperacionOperacion.Text.Trim();


                int valor = objdao.RegistrarPaciente();

                if (valor == 1)
                {
                    MessageBox.Show("Los datos fueron ingresados correctamente.", "Registro exitoso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ActualizarExpediente(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objAgregarPaciente.txtNombrePaciente.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtTelefonoPaciente.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtCorreoPaciente.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtTelefonoPaciente.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtDireccionPaciente.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtDUI.Text.Trim()) ||
      string.IsNullOrEmpty(objAgregarPaciente.txtNombreEmergencia.Text.Trim()) ||
string.IsNullOrEmpty(objAgregarPaciente.txtNumEmergencia.Text.Trim())))
            {
                //Se crea un objeto del DAO
                DAOPaciente objdao = new DAOPaciente();
                //Se guardan los datos en sus variables respectivas
                objdao.PacienteID = this.pacienteID;
                objdao.NombrePaciente = objAgregarPaciente.txtNombrePaciente.Text.Trim();
                objdao.EdadPaciente = int.Parse(objAgregarPaciente.txtEdadPaciente.Text);
                objdao.TelefonoPaciente = objAgregarPaciente.txtTelefonoPaciente.Text.Trim();
                objdao.FechaNac = objAgregarPaciente.dtpFechaNac.Value.Date;
                objdao.CorreoPaciente = objAgregarPaciente.txtCorreoPaciente.Text.Trim();
                objdao.OcupacionID = (int)objAgregarPaciente.cmbOcupacion.SelectedValue;
                objdao.DireccionPaciente = objAgregarPaciente.txtDireccionPaciente.Text.Trim();
                objdao.DUI1 = objAgregarPaciente.txtDUI.Text.Trim();
                objdao.Referencia = objAgregarPaciente.txtReferencia.Text.Trim();
                objdao.NombreEmergencia = objAgregarPaciente.txtNombreEmergencia.Text.Trim();
                objdao.NumEmergencia = objAgregarPaciente.txtNumEmergencia.Text.Trim();
                objdao.MotivoConsulta = objAgregarPaciente.txtMotivoConsulta.Text.Trim();
                objdao.Padecimientos = objAgregarPaciente.txtPadecimientos.Text.Trim();

                if (objAgregarPaciente.cbControlMedicoSi.Checked)
                {
                    objdao.ControlMedico = objAgregarPaciente.cbControlMedicoSi.Text;
                }
                else if (!objAgregarPaciente.cbControlMedicoNo.Checked)
                {
                    objdao.ControlMedico = objAgregarPaciente.cbControlMedicoNo.Text;
                }
                else
                {
                    objdao.ControlMedico = "No";
                }
                objdao.MedicoCabeceraNombre = objAgregarPaciente.txtMedicoCabeceraNombre.Text.Trim();
                objdao.NumMedicoCabecera = objAgregarPaciente.txtNumMedicoCabecera.Text.Trim();
                objdao.AlergiaMedicamentos = objAgregarPaciente.txtNombreAlergiaMedicamento.Text.Trim();
                objdao.Medicamentos = objAgregarPaciente.txtNombreMedicamento.Text.Trim();

                objAgregarPaciente.cbOperacionSi.Checked = true;
                if (objAgregarPaciente.cbOperacionSi.Checked == (objdao.Operacion == "Sí"))
                {
                    objdao.Operacion = objAgregarPaciente.cbOperacionSi.Text;
                }
                else if (objAgregarPaciente.cbOperacionNo.Checked == (objdao.Operacion == "No"))
                {
                    objdao.Operacion = objAgregarPaciente.cbOperacionNo.Text;
                }
                objdao.TipoOperacion = objAgregarPaciente.txtTipoOperacion.Text.Trim();
                objdao.RecuperacionOperacion = objAgregarPaciente.txtRecuperacionOperacion.Text.Trim();

                int valor = objdao.ActualizarUsuario();
                if (valor == 1)
                {
                    MessageBox.Show("Los datos fueron actualizados exitosamente.", "Actualización exitosa", MessageBoxButtons.OK);
                }
                else if (valor == 2)
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados completamente.", "Actualización interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            public void CargarValores(int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
            {
                try
                {
                    //Se cargan los valores de las variables en los textbox correspondientes
                    objAgregarPaciente.txtNombrePaciente.Text = nombrepaciente;
                    objAgregarPaciente.txtEdadPaciente.Text = edadpaciente.ToString();
                    objAgregarPaciente.txtTelefonoPaciente.Text = telefonopaciente;
                    objAgregarPaciente.dtpFechaNac.Text = fechanac.ToString();
                    objAgregarPaciente.txtCorreoPaciente.Text = correopaciente;
                    objAgregarPaciente.cmbOcupacion.Text = ocupacion.ToString();
                    objAgregarPaciente.txtDireccionPaciente.Text = direccionpaciente;
                    objAgregarPaciente.txtDUI.Text = dui;
                    objAgregarPaciente.txtReferencia.Text = referencia;
                    objAgregarPaciente.txtNombreEmergencia.Text = nombreemergencia;
                    objAgregarPaciente.txtNumEmergencia.Text = numemergencia;
                    objAgregarPaciente.txtMotivoConsulta.Text = motivoconsulta;
                    objAgregarPaciente.txtPadecimientos.Text = padecimientos;
                    if (objAgregarPaciente.cbControlMedicoSi.Checked == true)
                    {
                        controlmedico = objAgregarPaciente.cbControlMedicoSi.Text;
                    }
                    else if (objAgregarPaciente.cbControlMedicoNo.Checked == true)
                    {
                        controlmedico = objAgregarPaciente.cbControlMedicoNo.Text;
                    }
                    objAgregarPaciente.txtMedicoCabeceraNombre.Text = medicocabeceranombre;
                    objAgregarPaciente.txtNumMedicoCabecera.Text = nummedicocabecera;
                    objAgregarPaciente.txtNombreAlergiaMedicamento.Text = alergiamedicamentos;
                    objAgregarPaciente.txtNombreMedicamento.Text = medicamento;
                    if (objAgregarPaciente.cbOperacionSi.Checked == true)
                    {
                        operacion = objAgregarPaciente.cbOperacionSi.Text;
                    }
                    else if (objAgregarPaciente.cbOperacionNo.Checked == true)
                    {
                        operacion = objAgregarPaciente.cbOperacionNo.Text;
                    }
                    objAgregarPaciente.txtTipoOperacion.Text = tipooperacion;
                    objAgregarPaciente.txtRecuperacionOperacion.Text = recuperacionoperacion;
                }
                catch (Exception ex)
                {
                     MessageBox.Show("Error OS#007: Error al cargar valores." + ex.Message);
                 }
            }
        }
    }

