using PTC.Controller.PrimerUso;
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

namespace PTC.Vista
{
    public partial class ViewPrimerUso : Form
    {
        public ViewPrimerUso()
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerPrimerUso control = new ControllerPrimerUso(this);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtUsuario);
            ContextMenuEliminar(txtTelefono);
            ContextMenuEliminar(txtNombre);
            ContextMenuEliminar(txtEmail);
            ContextMenuEliminar(txtRespuesta);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelefono.Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {

                txtTelefono.Text = filteredText;
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }

            if (txtTelefono.Text.Length > 20)
            {
                txtTelefono.Text = txtTelefono.Text.Substring(0, 20);

                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
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

            if (txtNombre.Text.Length > 50)
            {
                txtNombre.Text = txtNombre.Text.Substring(0, 50);

                txtNombre.SelectionStart = txtNombre.Text.Length;
            }


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 255)
            {
                txtEmail.Text = txtEmail.Text.Substring(0, 255);

                txtEmail.SelectionStart = txtEmail.Text.Length;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 30)
            {
                txtUsuario.Text = txtUsuario.Text.Substring(0, 30);

                txtUsuario.SelectionStart = txtUsuario.Text.Length;
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            string text = txtRespuesta.Text;
            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtRespuesta.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '.' || c == ',').ToArray());
                txtRespuesta.SelectionStart = txtRespuesta.Text.Length;
            }
            if (txtRespuesta.Text.Length > 300)
            {
                txtRespuesta.Text = txtRespuesta.Text.Substring(0, 300);

                txtRespuesta.SelectionStart = txtRespuesta.Text.Length;
            }
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
