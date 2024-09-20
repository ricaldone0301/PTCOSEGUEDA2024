using PTC.Controller.Servidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.Conexion
{
    public partial class ViewConexion : Form
    {
        public ViewConexion(int origen)
        {
            InitializeComponent();
            ControllerServidor control = new ControllerServidor(this, origen);
        }
    }
}
