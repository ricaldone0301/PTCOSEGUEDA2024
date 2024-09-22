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

namespace PTC.Vista.Login
{
    public partial class ViewCambiar : Form
    {
        public ViewCambiar()
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerLogin cambiarController = new ControllerLogin(this);
        }
        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(TxtContra);
            ContextMenuEliminar(TxtUsuario);
        }
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
