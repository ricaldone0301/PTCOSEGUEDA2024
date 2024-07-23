using PTC.Controller.Cita;
using PTC.Controller.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.Cita
{
    public partial class ViewCitas : Form
    {
        public ViewCitas()
        {
            InitializeComponent();
            ControllerAdminCitas Objadmincitas = new ControllerAdminCitas(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
