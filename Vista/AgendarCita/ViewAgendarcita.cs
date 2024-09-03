using BunifuAnimatorNS;
using PTC.Controller.Cita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgendarCita
{
    public partial class ViewAgendarcita : Form
    {
        public ViewAgendarcita(int accion)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            ControllerAgendarCita objAgendarCita = new ControllerAgendarCita(this, accion);
        }
        public ViewAgendarcita(int accion, int citaID, int pacienteID, string personalID, int consultorioID, string hora, DateTime fecha, int procedimientoID)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            ControllerAgendarCita objAgendarCita = new ControllerAgendarCita(this,  accion, citaID, pacienteID, personalID, consultorioID, hora, fecha, procedimientoID);

        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtHora);
        }
        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPaciente_Keypress(object sender, EventArgs e)
        {

        }

        private void cbPaciente_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbProcedimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            if (Fecha == null) return;

            DateTime today = DateTime.Today;

            Fecha.MinDate = today;

            if (Fecha.Value < today)
            {
                Fecha.Value = today;
            }
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            string text = txtHora.Text;
            string validChars = "0123456789/";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtHora.Text = filteredText;
                txtHora.SelectionStart = txtHora.Text.Length;
            }

        }
    }
}
