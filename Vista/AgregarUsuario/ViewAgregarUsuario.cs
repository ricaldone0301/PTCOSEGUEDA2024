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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTC.Vista.AgregarDoctores
{
    public partial class ViewAgregarUsuario : Form
    {

        public ViewAgregarUsuario(int accion)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarusuario objAgregarUsuario = new ControllerAgregarusuario(this, accion);
        }

        public ViewAgregarUsuario(int accion, string Nombre, string PersonalID, int rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email, int preguntaID, string respuesta)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarusuario objActualiarUsuario = new ControllerAgregarusuario(this, accion, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email, preguntaID, respuesta);
        }



        private void ContextMenuEliminar(System.Windows.Forms.TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtContrasena);
            ContextMenuEliminar(txtEmail);
            ContextMenuEliminar(txtNombre);
            ContextMenuEliminar(txtTelefono);
            ContextMenuEliminar(txtUsuario);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

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

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length > 256)
            {
                txtContrasena.Text = txtEmail.Text.Substring(0, 256);

                txtContrasena.SelectionStart = txtContrasena.Text.Length;
            }
        }
    }

    }

   
