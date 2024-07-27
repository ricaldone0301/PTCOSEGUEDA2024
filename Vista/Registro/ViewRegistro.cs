using PTC.Controller.Login;
using PTC.Controller.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.Registro
{
    public partial class ViewRegistro : Form
    {
        public ViewRegistro()
        {
            InitializeComponent();
            ControllerRegistro control = new ControllerRegistro(this);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timevcode_Tick(object sender, EventArgs e)
        {
        }
    }
}
