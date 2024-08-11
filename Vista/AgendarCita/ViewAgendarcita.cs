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
            ControllerAgendarCita objAgendarCita = new ControllerAgendarCita(this, accion);
        }

        
        public ViewAgendarcita(int accion, int pacienteID, string personalID, int consultorioID, string hora, DateTime fecha, int procedimientoID)
        {
            InitializeComponent();
            ControllerAgendarCita objAgendarCita = new ControllerAgendarCita(this, accion, pacienteID, personalID, consultorioID, hora, fecha, procedimientoID);

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
    }
}
