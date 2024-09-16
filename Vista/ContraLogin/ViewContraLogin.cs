using PTC.Controller.CambiarAdminContra;
using PTC.Controller.Login;
using PTC.Controller.LoginContra;
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
            ControllerLoginContra control = new ControllerLoginContra(this);
        }
    }
}
