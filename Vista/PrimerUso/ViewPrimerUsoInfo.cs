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

namespace PTC.Vista.PrimerUso
{
    public partial class ViewPrimerUsoInfo : Form
    {
        public ViewPrimerUsoInfo()
        {
            InitializeComponent();
            ControllerPrimerUso control1 = new ControllerPrimerUso(this);
        }
        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtDireccion);
            ContextMenuEliminar(txtTelefono);
            ContextMenuEliminar(txtNombre);
            ContextMenuEliminar(txtEmail);
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            string text = txtDireccion.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(text))
            {
                txtDireccion.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());
                txtDireccion.SelectionStart = txtDireccion.Text.Length;
            }

            if (txtNombre.Text.Length > 50)
            {
                txtDireccion.Text = txtNombre.Text.Substring(0, 50);

                txtDireccion.SelectionStart = txtDireccion.Text.Length;
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


       
        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Ingresar correo valido", "Correo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
