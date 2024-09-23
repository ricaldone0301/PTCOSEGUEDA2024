using PTC.Controller.Cita;
using PTC.Controller.Ocupacion;
using PTC.Controller.Paciente;
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
            ControllerAgendarCita ObjAgendarCita = new ControllerAgendarCita(this, accion);
            Fecha.MinDate = DateTime.Today;
        }

        public ViewAgendarcita(int accion, int citaID, int pacienteID, string personalID, int consultorioID, string hora, DateTime fecha, int procedimientoID, string paciente, string personal, string consultorio, string procedimiento)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgendarCita ObjAgregarPaciente = new ControllerAgendarCita(this, accion, citaID, pacienteID, personalID, consultorioID, hora, fecha, procedimientoID, paciente, personal, consultorio, procedimiento);
        }

        private void ContextMenuEliminar(System.Windows.Forms.TextBox textBox)
        {
            // Crear una nueva instancia de ContextMenuStrip (menú contextual).
            var menuContexto = new ContextMenuStrip();

            // Se le asigna el menú contextual creado al TextBox especificado.
            textBox.ContextMenuStrip = menuContexto;
        }
        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtHora);
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            if (txtHora.Text.Length > 5)
            {
                txtHora.Text = txtHora.Text.Substring(0, 5);
                txtHora.SelectionStart = txtHora.Text.Length;
            }

            string text = txtHora.Text;
            string validChars = "0123456789:";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtHora.Text = filteredText;
                txtHora.SelectionStart = txtHora.Text.Length;

            }
        }
    }
}
