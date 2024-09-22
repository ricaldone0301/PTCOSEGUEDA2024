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
    public partial class ViewContraConexion : Form
    {
        public ViewContraConexion()
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerContraServidor objConnection = new ControllerContraServidor(this);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtPassword);
        }
    }
}
