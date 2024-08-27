using PTC.Controller.PrimerUso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista
{
    public partial class ViewPrimerUso : Form
    {
        public ViewPrimerUso()
        {
            InitializeComponent();
            ControllerPrimerUso control = new ControllerPrimerUso(this);
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
