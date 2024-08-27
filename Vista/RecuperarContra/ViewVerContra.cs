//using PTC.Controller.RecuperarContra;
using PTC.Controller.Dasboard;
using PTC.Controller.Usuarios;
using PTC.Controller.VerPerfil;
using PTC.Modelo.DAOUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.RecuperarContra
{
    public partial class ViewVerContra : Form
    {

        public ViewVerContra()
        {
            InitializeComponent();
            ControllerVerPerfil objPerfil = new ControllerVerPerfil(this);
        }
    }
}


