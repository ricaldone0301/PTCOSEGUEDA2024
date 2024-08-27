using PTC.Controller.PreguntaContra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.OlvidoPregunta
{
    public partial class ViewOlvidoPregunta : Form
    {
        public ViewOlvidoPregunta()
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerPreguntaContra control = new ControllerPreguntaContra(this);

        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtEmail);
            ContextMenuEliminar(txtContrasena);
            ContextMenuEliminar(txtConfirm);
        }
    }
}
