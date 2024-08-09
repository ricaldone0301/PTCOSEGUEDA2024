using PTC.Modelo.DAOPaciente;
using PTC.Vista.AgregarPaciente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Paciente
{
    internal class ControllerAgregarPaciente
    {
        ViewAgregarPaciente objAgregarPaciente;
        public bool hipertensionarterial, diabetes, autismo, antecedentespsiquiatricos, vih, cancer, tiroides, ronquidos, artritis, vph, migraña, hemofilia, lupus, parkinson, hemorragias, lentacicatrizacion, gastritis, colitis, otro;
        private int accion;
        private string ocupacion;


        public ControllerAgregarPaciente(ViewAgregarPaciente vista, int accion)
        {
            objAgregarPaciente = vista;
            this.accion = accion;

            objAgregarPaciente.bcPadecimientos.Hide();
            objAgregarPaciente.gbAgregarOcupacion.Hide();

            VerificarAccion();
            objAgregarPaciente.Load += new EventHandler(RefrescarCombobox);
            objAgregarPaciente.btnSeleccionarPadecimientos.Click += new EventHandler(MostrarPadecimientos);
            objAgregarPaciente.btnAgregarOcupacion.Click += new EventHandler(MostrarAgregarOcupacion);

            if (accion == 1)
            {
                objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(NuevoExpediente);
            }
        }

        public ControllerAgregarPaciente(ViewAgregarPaciente vista, int p_accion, int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion, string otropadecimiento)
        {
            objAgregarPaciente = vista;
            this.accion = p_accion;
            this.ocupacion = ocupacion;
            VerificarAccion();
            CargarValores(id, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion, otropadecimiento);

            if (accion == 2)
            {
                objAgregarPaciente.btnGuardarPaciente.Click += new EventHandler(ActualizarExpediente);
            }
        }

        public void RefrescarCombobox(object sender, EventArgs e)
        {
            DAOPaciente objdao = new DAOPaciente();
            DataSet dataset = objdao.LlenarComboOcupaciones();
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

        public void MostrarPadecimientos(object sender, EventArgs e)
        {
            objAgregarPaciente.bcPadecimientos.Show();
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
                objAgregarPaciente.btnSeleccionarPadecimientos.Enabled = false;
                objAgregarPaciente.cbHipertensionArterial.Enabled = false;
                objAgregarPaciente.cbDiabetes.Enabled = false;
                objAgregarPaciente.cbAutismo.Enabled = false;
                objAgregarPaciente.cbAntecedentesPsiquiatricos.Enabled = false;
                objAgregarPaciente.cbVIH.Enabled = false;
                objAgregarPaciente.cbCancer.Enabled = false;
                objAgregarPaciente.cbTiroides.Enabled = false;
                objAgregarPaciente.cbRonquidos.Enabled = false;
                objAgregarPaciente.cbArtritis.Enabled = false;
                objAgregarPaciente.cbVPH.Enabled = false;
                objAgregarPaciente.cbMigrana.Enabled = false;
                objAgregarPaciente.cbHemofilia.Enabled = false;
                objAgregarPaciente.cbLupus.Enabled = false;
                objAgregarPaciente.cbParkinson.Enabled = false;
                objAgregarPaciente.cbHemorragias.Enabled = false;
                objAgregarPaciente.cbLentaCicatrizacion.Enabled = false;
                objAgregarPaciente.cbGastritis.Enabled = false;
                objAgregarPaciente.cbColitis.Enabled = false;
                objAgregarPaciente.cbOtros.Enabled = false;
                objAgregarPaciente.txtOtroPadecimiento.Enabled = false;
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
            }
        }

        public ControllerAgregarPaciente()
        {
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
            if (objAgregarPaciente.cbHipertensionArterial.Checked == true)
            {
                hipertensionarterial = true;
            }
            if (objAgregarPaciente.cbDiabetes.Checked == true)
            {
                diabetes = true;
            }
            if (objAgregarPaciente.cbAutismo.Checked == true)
            {
                autismo = true;
            }
            if (objAgregarPaciente.cbAntecedentesPsiquiatricos.Checked == true)
            {
                antecedentespsiquiatricos = true;
            }
            if (objAgregarPaciente.cbVIH.Checked == true)
            {
                vih = true;
            }
            if (objAgregarPaciente.cbCancer.Checked == true)
            {
                cancer = true;
            }
            if (objAgregarPaciente.cbTiroides.Checked == true)
            {
                tiroides = true;
            }
            if (objAgregarPaciente.cbRonquidos.Checked == true)
            {
                ronquidos = true;
            }
            if (objAgregarPaciente.cbArtritis.Checked == true)
            {
                artritis = true;
            }
            if (objAgregarPaciente.cbVPH.Checked == true)
            {
                vph = true;
            }
            if (objAgregarPaciente.cbMigrana.Checked == true)
            {
                migraña = true;
            }
            if (objAgregarPaciente.cbHemofilia.Checked == true)
            {
                hemofilia = true;
            }
            if (objAgregarPaciente.cbLupus.Checked == true)
            {
                lupus = true;
            }
            if (objAgregarPaciente.cbParkinson.Checked == true)
            {
                parkinson = true;
            }
            if (objAgregarPaciente.cbHemorragias.Checked == true)
            {
                hemorragias = true;
            }
            if (objAgregarPaciente.cbLentaCicatrizacion.Checked == true)
            {
                lentacicatrizacion = true;
            }
            if (objAgregarPaciente.cbGastritis.Checked == true)
            {
                gastritis = true;
            }
            if (objAgregarPaciente.cbColitis.Checked == true)
            {
                colitis = true;
            }
            if (objAgregarPaciente.cbOtros.Checked == true)
            {
                otro = true;
            }
            objdao.Padecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();
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
            objdao.OtrosPadecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();

            int valor = objdao.AgregarPaciente();

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
            objdao.OtrosPadecimientos = objAgregarPaciente.txtOtroPadecimiento.Text.Trim();

            int valor = objdao.ActualizarPacientes();
            if (valor == 2)
            {
                MessageBox.Show("Los datos fueron actualizados exitosamente.", "Actualización exitosa", MessageBoxButtons.OK);
            }
            else if (valor == 1)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados completamente.", "Actualización interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarValores(int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion, string otropadecimiento)
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
                objAgregarPaciente.txtOtroPadecimiento.Text = otropadecimiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

