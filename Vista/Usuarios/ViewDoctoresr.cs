using PTC.Controller.Usuarios;
using PTC.Vista.AgregarDoctores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgregarDoctor
{
    public partial class ViewAgregarUsuario : Form
    {
        public ViewAgregarUsuario()
        {
            InitializeComponent();
            ControllerAdminUsuarios ObjAdminUser = new ControllerAdminUsuarios(this);
        }
    }
}
