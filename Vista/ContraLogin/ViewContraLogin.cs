using PTC.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.ContraLogin
{
    public partial class ViewContraLogin : Form
    {
        public ViewContraLogin()
        {
            InitializeComponent();
            ControllerLogin control = new ControllerLogin(this);
        }
    }
}
