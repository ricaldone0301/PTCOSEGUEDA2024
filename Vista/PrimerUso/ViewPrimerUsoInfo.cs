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

namespace PTC.Vista.PrimerUso
{
    public partial class ViewPrimerUsoInfo : Form
    {
        public ViewPrimerUsoInfo()
        {
            InitializeComponent();
            ControllerPrimerUso control1 = new ControllerPrimerUso(this);
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
