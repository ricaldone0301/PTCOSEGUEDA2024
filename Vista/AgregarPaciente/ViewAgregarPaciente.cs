using PTC.Controller.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PTC.Vista.AgregarPaciente
{
    public partial class ViewAgregarPaciente : Form
    {
      
        public ViewAgregarPaciente(int accion)
        {
            InitializeComponent();
            ControllerAgregarPaciente ObjAgregarPaciente = new ControllerAgregarPaciente(this, accion);
        }

        public ViewAgregarPaciente(int accion, int pacienteID, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
        {
            InitializeComponent();
            ControllerAgregarPaciente ObjAgregarPaciente = new ControllerAgregarPaciente(this, accion, pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
        }

        private void txtRecuperacionOperacion_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombreMedicamento.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombreMedicamento.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtNombreMedicamento.SelectionStart = txtNombreMedicamento.Text.Length;
            }
        }
    

        private void gbAgregarOcupacion_Enter(object sender, EventArgs e)
        {

        }

        private void bcPadecimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarPadecimientos_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAlergiaMedicamento_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombreAlergiaMedicamento.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombreAlergiaMedicamento.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtNombreAlergiaMedicamento.SelectionStart = txtNombreMedicamento.Text.Length;
            }
        }

        private void btnAgregarOcupacion_Click(object sender, EventArgs e)
        {

        }

        private void txtMotivoConsulta_TextChanged(object sender, EventArgs e)
        {
            string text = txtMotivoConsulta.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtMotivoConsulta.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtMotivoConsulta.SelectionStart = txtMotivoConsulta.Text.Length;
            }
        }

        private void txtNombreMedicamento_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombreMedicamento.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombreMedicamento.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtNombreMedicamento.SelectionStart = txtNombreMedicamento.Text.Length;
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            if (!this.txtCorreoPaciente.Text.Contains('@') || !this.txtCorreoPaciente.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuCustomLabel22_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel21_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoOperacion_TextChanged(object sender, EventArgs e)
        {
            string text = txtTipoOperacion.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtTipoOperacion.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtTipoOperacion.SelectionStart = txtTipoOperacion.Text.Length;
            }
        }
    

        private void bunifuCustomLabel20_Click(object sender, EventArgs e)
        {

        }

        private void cbOperacionNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOperacionSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void txtNumMedicoCabecera_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtMedicoCabeceraNombre_TextChanged(object sender, EventArgs e)
        {
            string text = txtMedicoCabeceraNombre.Text;

            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);


            if (!regex.IsMatch(text))
            {
                txtMedicoCabeceraNombre.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtMedicoCabeceraNombre.SelectionStart = txtMedicoCabeceraNombre.Text.Length;
            }
        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void cbControlMedicoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbControlMedicoSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void txtNumEmergencia_TextChanged(object sender, EventArgs e)
        {
            string text = txtNumEmergencia.Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtNumEmergencia.Text = filteredText;
                txtNumEmergencia.SelectionStart = txtNumEmergencia.Text.Length;
            }
        }

        private void txtNombreEmergencia_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombreEmergencia.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombreEmergencia.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtNombreEmergencia.SelectionStart = txtNombreEmergencia.Text.Length;
            }
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            string text = txtReferencia.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtReferencia.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtReferencia.SelectionStart = txtReferencia.Text.Length;
            }
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            string text = txtDUI.Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtDUI.Text = filteredText;
                txtDUI.SelectionStart = txtDUI.Text.Length;
            }
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccionPaciente_TextChanged(object sender, EventArgs e)
        {
            string text = txtDireccionPaciente.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtDireccionPaciente.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtDireccionPaciente.SelectionStart = txtDireccionPaciente.Text.Length;
            }
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cmbOcupacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoPaciente_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelefonoPaciente.Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtTelefonoPaciente.Text = filteredText;
                txtTelefonoPaciente.SelectionStart = txtTelefonoPaciente.Text.Length;
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEdadPaciente_TextChanged(object sender, EventArgs e)
        {

                string text = txtEdadPaciente.Text;

                string validChars = "0123456789";
                string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());
                int digitCount = filteredText.Count(c => char.IsDigit(c));

                if (digitCount > 2)
                {
                    filteredText = new string(filteredText.TakeWhile(c => !char.IsDigit(c) || digitCount-- > 0).ToArray());

                if (text != filteredText)
                {
                    txtEdadPaciente.Text = filteredText;
                    txtEdadPaciente.SelectionStart = txtEdadPaciente.Text.Length;
                }
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombrePaciente.Text;

            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);

  
            if (!regex.IsMatch(text))
            {
                txtNombrePaciente.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtNombrePaciente.SelectionStart = txtNombrePaciente.Text.Length;
            }
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtPadecimientos_TextChanged(object sender, EventArgs e)
        {
            string text = txtPadecimientos.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtPadecimientos.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtPadecimientos.SelectionStart = txtPadecimientos.Text.Length;
            }
        }

        private void txtNombreOcupacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreOcupacion_TextChanged_1(object sender, EventArgs e)
        {
            string text = txtNombreOcupacion.Text;

            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);


            if (!regex.IsMatch(text))
            {
                txtNombreOcupacion.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtNombreOcupacion.SelectionStart = txtNombreOcupacion.Text.Length;
            }
        }
    }
    
}
