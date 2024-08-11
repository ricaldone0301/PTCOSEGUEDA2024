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
        ViewAgregarPaciente objAgregarPaciente;

        public bool hipertensionarterial, diabetes, autismo, antecedentespsiquiatricos, vih, cancer, tiroides, ronquidos, artritis, vph, migraña, hemofilia, lupus, parkinson, hemorragias, lentacicatrizacion, gastritis, colitis, otro;
        private int accion;
        private int pacienteID;
        private string ocupacion;

        public ControllerAgregarPaciente(ViewAgregarPaciente Vista, int accion)
        {
            objAgregarPaciente = Vista;
            this.accion = accion;
            VerificarAccion();
            objAgregarPaciente.Load += new EventHandler(CargaInicial);
            objAgregarPaciente.btnAgregarOcupacion.Click += new EventHandler(MostrarAgregarOcupacion);
            objAgregarPaciente.btnGuardarOcupacion.Click += new EventHandler(NuevaOcupacion);
            objAgregarPaciente.cmbOcupacion.Click += new EventHandler(RefrescarCombobox);
            objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(NuevoExpediente);
        }

    
        public ControllerAgregarPaciente(ViewAgregarPaciente vista, int accion, int pacienteID, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
        {
            objAgregarPaciente = vista;
            this.accion = accion;
            this.ocupacion = ocupacion;
            objAgregarPaciente.Load += new EventHandler(CargaInicial);
            VerificarAccion();
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

            objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(ActualizarExpediente);
            
        }

        public void CargoInicial(object sender, EventArgs e)
        {
            try
            {
                DAOPaciente objAdmin = new DAOPaciente();

                DataSet dsOcupaciones = objAdmin.ComboBoxOcupacion();
                if (dsOcupaciones != null && dsOcupaciones.Tables.Contains("Ocupaciones"))
                {
                    DataTable dtOcupaciones = dsOcupaciones.Tables["Roles"];
                    objAgregarPaciente.cmbOcupacion.DataSource = dtOcupaciones;
                    objAgregarPaciente.cmbOcupacion.ValueMember = "OcupacionID";
                    objAgregarPaciente.cmbOcupacion.DisplayMember = "nombreOcupacion";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtOcupaciones.Select($"nombreOcupacion = '{ocupacion}'");
                        if (rows.Length > 0)
                        {
                            objAgregarPaciente.cmbOcupacion.Text = rows[0]["nombreOcupacion"].ToString();
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void NuevaOcupacion(object sender, EventArgs e)
        {
            try
            {
                DAOOcupacion daoAdmin = new DAOOcupacion();
                CommonClass commonClass = new CommonClass();

                daoAdmin.NombreOcupacion = objAgregarPaciente.txtNombreOcupacion.Text.Trim();

                int valorRetornado = daoAdmin.RegistrarOcupacion();

                if (valorRetornado == 1 )
                {
                    //objAgregarPaciente.btnAgregarOcupacion.Click += new EventHandler();
                    MessageBox.Show("La ocupacion ha sido registrada exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

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



        public void RefrescarCombobox(object sender, EventArgs e)
        {
            DAOOcupacion objdao = new DAOOcupacion();
            DataSet dataset = objdao.ComboBoxOcupacion();
            objAgregarPaciente.cmbOcupacion.DataSource = dataset.Tables["Ocupaciones"];
            objAgregarPaciente.cmbOcupacion.ValueMember = "ocupacionID";
            objAgregarPaciente.cmbOcupacion.DisplayMember = "nombreOcupacion";

            if (accion == 2)
            {
                objAgregarPaciente.cmbOcupacion.Text = ocupacion;
            }
        }
        public void MostrarAgregarOcupacion(object sender, EventArgs e)
        {
            objAgregarPaciente.gbAgregarOcupacion.Show();
        }

        public void VerificarAccion()
        {
            if (accion == 3)
            {
                objAgregarPaciente.btnGuardarPaciente.Enabled = false;
                objAgregarPaciente.txtNombrePaciente.Enabled = false;
                objAgregarPaciente.txtEdadPaciente.Enabled = false;
                objAgregarPaciente.txtTelefonoPaciente.Enabled = false;
                objAgregarPaciente.dtpFechaNac.Enabled = false;
                objAgregarPaciente.txtCorreoPaciente.Enabled = false;
                objAgregarPaciente.cmbOcupacion.Enabled = false;
                objAgregarPaciente.txtDireccionPaciente.Enabled = false;
                objAgregarPaciente.txtDUI.Enabled = false;
                objAgregarPaciente.txtReferencia.Enabled = false;
                objAgregarPaciente.txtNombreEmergencia.Enabled = false;
                objAgregarPaciente.txtNumEmergencia.Enabled = false;
                objAgregarPaciente.txtMotivoConsulta.Enabled = false;
                //objAgregarPaciente.txtOtroPadecimiento.Enabled = false;
                objAgregarPaciente.cbControlMedicoSi.Enabled = false;
                objAgregarPaciente.cbControlMedicoNo.Enabled = false;
                objAgregarPaciente.txtMedicoCabeceraNombre.Enabled = false;
                objAgregarPaciente.txtNumMedicoCabecera.Enabled = false;
                objAgregarPaciente.txtNombreAlergiaMedicamento.Enabled = false;
                objAgregarPaciente.txtNombreMedicamento.Enabled = false;
                objAgregarPaciente.cbOperacionSi.Enabled = false;
                objAgregarPaciente.cbOperacionNo.Enabled = false;
                objAgregarPaciente.txtTipoOperacion.Enabled = false;
                objAgregarPaciente.txtRecuperacionOperacion.Enabled = false;
                objAgregarPaciente.txtPadecimientos.Enabled = false;
            }
        }

        public void CargaInicial(object sender, EventArgs e)
        {
            try
            {
                DAOOcupacion objAdmin = new DAOOcupacion();

                DataSet dsOcupacion = objAdmin.ComboBoxOcupacion();

                DAOOcupacion objdao = new DAOOcupacion();
                DataSet dataset = objdao.ComboBoxOcupacion();
                objAgregarPaciente.cmbOcupacion.DataSource = dataset.Tables["Ocupaciones"];
                objAgregarPaciente.cmbOcupacion.ValueMember = "ocupacionID";
                objAgregarPaciente.cmbOcupacion.DisplayMember = "nombreOcupacion";

                if (accion == 2)
                {
                    objAgregarPaciente.cmbOcupacion.Text = ocupacion;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
            public void NuevoExpediente(object sender, EventArgs e)
            {
            hipertensionarterial = false;
            diabetes = false;
            autismo = false;
            antecedentespsiquiatricos = false;
            vih = false;
            cancer = false;
            tiroides = false;
            ronquidos = false;
            artritis = false;
            vph = false;
            migraña = false;
            hemofilia = false;
            lupus = false;
            parkinson = false;
            hemorragias = false;
            lentacicatrizacion = false;
            gastritis = false;
            colitis = false;
            otro = false;

            DAOPaciente objdao = new DAOPaciente();
            CommonClass commonClass = new CommonClass();

            //objdao.PacienteID = int.Parse(objAgregarPaciente.txtId.Text.Trim());
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

            //objdao.Padecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();
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
            //objdao.OtrosPadecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();
            

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

        public void ActualizarExpediente(object sender, EventArgs e)
        {
            DAOPaciente objdao = new DAOPaciente();
            objdao.PacienteID = this.pacienteID;
            //objdao.PacienteID = int.Parse(objAgregarPaciente.txtId.Text.Trim());
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

            /*
            if (objAgregarPaciente.cbControlMedicoSi.Checked == true)
            {
                objdao.ControlMedico = objAgregarPaciente.cbControlMedicoSi.Text;
            }
            else if (objAgregarPaciente.cbControlMedicoNo.Checked == true)
            {
                objdao.ControlMedico = objAgregarPaciente.cbControlMedicoNo.Text;
            }*/
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
            //objdao.OtrosPadecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();

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

        public void CargarValores(int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
        {
            try
            {
                //objAgregarPaciente.txtId.Text = id.ToString();
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
                //objAgregarPaciente.txtOtroPadecimiento.Text = otropadecimiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

