using PTC.Controller.Servidor;
using PTC.Vista.Login;
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
            TextBoxMenuEliminar();
            ControllerServidor Control = new ControllerServidor(this, origen);

        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtDatabase);
            ContextMenuEliminar(txtServer);
            ContextMenuEliminar(txtSqlAuth);
            ContextMenuEliminar(txtSqlPass);
        }
        private void ViewConexion_Load(object sender, EventArgs e)
        {

        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConf_Click(object sender, EventArgs e)
        {

        }
    }
}
