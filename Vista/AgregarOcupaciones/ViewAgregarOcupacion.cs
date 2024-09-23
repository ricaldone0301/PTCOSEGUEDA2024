using PTC.Controller.Ocupacion;
using PTC.Controller.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgendarOcupaciones
{
    public partial class ViewAgregarOcupacion : Form
    {
        public ViewAgregarOcupacion(int accion)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarOcupacion ObjAgregarOcupacion = new ControllerAgregarOcupacion(this, accion);

        }

        public ViewAgregarOcupacion(int accion, string nombreOcupacion, int ocupacionID)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarOcupacion ObjAgregarOcupacion = new ControllerAgregarOcupacion(this, accion, nombreOcupacion, ocupacionID);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtNombre);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombre.Text;
            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombre.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
            if (txtNombre.Text.Length > 70)
            {
                txtNombre.Text = txtNombre.Text.Substring(0, 70);

                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void ViewAgregarOcupacion_Load(object sender, EventArgs e)
        {

        }
    }
    
}
