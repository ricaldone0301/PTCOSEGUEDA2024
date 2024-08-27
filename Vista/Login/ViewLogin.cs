using PTC.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PTC.Vista.Login
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
            ControllerLogin control = new ControllerLogin(this);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
