using PTC.Controller.Dasboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.Dashboard
{
    public partial class ViewDashboard : Form
    {
        public ViewDashboard()
        {
            InitializeComponent();
            ControllerDashboard objDash = new ControllerDashboard(this);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ViewDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ok_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
