using PTC.Controller;
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

namespace PTC.Vista.OlvidoContrasena
{
    public partial class ViewOlvidoContrasena : Form
    {
        public ViewOlvidoContrasena()
        {
            InitializeComponent();
            ControllerContrasena control = new ControllerContrasena(this);
            TextBoxMenuEliminar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtEmail);
            ContextMenuEliminar(txtContrasena);
            ContextMenuEliminar(txtConfirm);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
