using PTC.Controller.CambiarAdminContra;
using PTC.Controller.VerPerfil;
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
    public partial class ViewCambiarContra : Form
    {
        public ViewCambiarContra()
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerCambiarAdminContra objPerfil = new ControllerCambiarAdminContra(this);
        }


        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(TxtUsuario);
            ContextMenuEliminar(TxtContra);
        }

            private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
