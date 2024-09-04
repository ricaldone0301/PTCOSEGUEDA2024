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
            TextBoxMenuEliminar();
            dtpFechaNac.MaxDate = DateTime.Today;
        }

        private void ViewAgregarPaciente_Load(object sender, EventArgs e)
        {
            dtpFechaNac.MaxDate = DateTime.Today;
        }
        public ViewAgregarPaciente(int accion, int pacienteID, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string recuperacionoperacion)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarPaciente ObjAgregarPaciente = new ControllerAgregarPaciente(this, accion, pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtCorreoPaciente);
            ContextMenuEliminar(txtDireccionPaciente);
            ContextMenuEliminar(txtDUI);
            ContextMenuEliminar(txtEdadPaciente);
            ContextMenuEliminar(txtMedicoCabeceraNombre);
            ContextMenuEliminar(txtMotivoConsulta);
            ContextMenuEliminar(txtNombreAlergiaMedicamento);
            ContextMenuEliminar(txtNombreEmergencia);
            ContextMenuEliminar(txtNombreMedicamento);
            ContextMenuEliminar(txtNombreOcupacion);
            ContextMenuEliminar(txtNombrePaciente);
            ContextMenuEliminar(txtNumEmergencia);
            ContextMenuEliminar(txtNumMedicoCabecera);
            ContextMenuEliminar(txtPadecimientos);
            ContextMenuEliminar(txtRecuperacionOperacion);
            ContextMenuEliminar(txtReferencia);
            ContextMenuEliminar(txtTelefonoPaciente);
            ContextMenuEliminar(txtTipoOperacion);
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

            if (txtRecuperacionOperacion.Text.Length > 300)
            {
                txtRecuperacionOperacion.Text = txtRecuperacionOperacion.Text.Substring(0, 300);

                txtRecuperacionOperacion.SelectionStart = txtRecuperacionOperacion.Text.Length;
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
            if (txtNombreMedicamento.Text.Length > 300)
            {
                txtNombreAlergiaMedicamento.Text = txtNombreAlergiaMedicamento.Text.Substring(0, 300);

                txtNombreAlergiaMedicamento.SelectionStart = txtNombreAlergiaMedicamento.Text.Length;
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
            if (txtMotivoConsulta.Text.Length > 300)
            {
                txtMotivoConsulta.Text = txtMotivoConsulta.Text.Substring(0, 300);

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
            if (txtNombreMedicamento.Text.Length > 300)
            {
                txtNombreMedicamento.Text = txtNombreMedicamento.Text.Substring(0, 300);

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
            if (txtTipoOperacion.Text.Length > 100)
            {
                txtTipoOperacion.Text = txtTipoOperacion.Text.Substring(0, 100);

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
            string text = txtNumMedicoCabecera .Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtNumMedicoCabecera.Text = filteredText;
                txtNumMedicoCabecera.SelectionStart = txtTelefonoPaciente.Text.Length;
            }
            if (txtNumMedicoCabecera.Text.Length > 20)
            {
                txtNumMedicoCabecera.Text = txtNumMedicoCabecera.Text.Substring(0, 20);

                txtNumMedicoCabecera.SelectionStart = txtNumMedicoCabecera.Text.Length;
            }
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
            if (txtMedicoCabeceraNombre.Text.Length > 100)
            {
                txtMedicoCabeceraNombre.Text = txtMedicoCabeceraNombre.Text.Substring(0, 100);

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
            if (txtNumEmergencia.Text.Length > 20)
            {
                txtNumEmergencia.Text = txtNumEmergencia.Text.Substring(0, 20);

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
            if (txtNombreEmergencia.Text.Length > 20)
            {
                txtNombreEmergencia.Text = txtNombreEmergencia.Text.Substring(0, 20);

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
            if (txtReferencia.Text.Length > 50)
            {
                txtReferencia.Text = txtReferencia.Text.Substring(0, 50);

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
            if (txtDUI.Text.Length > 12)
            {
                txtDUI.Text = txtDUI.Text.Substring(0, 12);

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
            if (txtDireccionPaciente.Text.Length > 200)
            {
                txtDireccionPaciente.Text = txtDireccionPaciente.Text.Substring(0, 200);

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
            if (txtCorreoPaciente.Text.Length > 50)
            {
                txtCorreoPaciente.Text = txtCorreoPaciente.Text.Substring(0, 50);

                txtCorreoPaciente.SelectionStart = txtCorreoPaciente.Text.Length;
            }
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
            if (txtTelefonoPaciente.Text.Length > 20)
            {
                txtTelefonoPaciente.Text = txtTelefonoPaciente.Text.Substring(0, 20);

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
                }

                if (text != filteredText)
                {
                    txtEdadPaciente.Text = filteredText;
                    txtEdadPaciente.SelectionStart = txtEdadPaciente.Text.Length;

                }

            if (txtEdadPaciente.Text.Length > 2)
            {
                txtEdadPaciente.Text = txtEdadPaciente.Text.Substring(0, 2);

                txtEdadPaciente.SelectionStart = txtEdadPaciente.Text.Length;
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
            if (txtNombrePaciente.Text.Length > 100)
            {
                txtNombrePaciente.Text = txtNombrePaciente.Text.Substring(0, 100);

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
            if (txtPadecimientos.Text.Length > 300)
            {
                txtPadecimientos.Text = txtPadecimientos.Text.Substring(0, 300);

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
            if (txtNombreOcupacion.Text.Length > 70)
            {
                txtNombreOcupacion.Text = txtNombreOcupacion.Text.Substring(0, 70);

                txtNombreOcupacion.SelectionStart = txtNombreOcupacion.Text.Length;
            }
        }

    }
    
}
