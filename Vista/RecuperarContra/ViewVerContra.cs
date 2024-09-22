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
            TextBoxMenuEliminar();
            ControllerVerPerfil objPerfil = new ControllerVerPerfil(this);
        }
        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtContrasenaNueva);
        }
        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


