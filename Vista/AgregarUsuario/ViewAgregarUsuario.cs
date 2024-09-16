using PTC.Controller.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
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

        public ViewAgregarUsuario(int accion, string Nombre, string PersonalID, string rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email, int preguntaID, string respuesta, string pregunta, string consultorio,string Especialidad, int rolID)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarusuario objActualiarUsuario = new ControllerAgregarusuario(this, accion, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email, preguntaID, respuesta, pregunta, consultorio, Especialidad, rolID);
        }



        // Método privado que asigna un menú contextual vacío a un TextBox específico.
        // El TextBox al que se le asigna el menú contextual se pasa como argumento al método.
        private void ContextMenuEliminar(System.Windows.Forms.TextBox textBox)
        {
            // Crear una nueva instancia de ContextMenuStrip (menú contextual).
            var menuContexto = new ContextMenuStrip();

            // Se le asigna el menú contextual creado al TextBox especificado.
            textBox.ContextMenuStrip = menuContexto;
        }

        // Se le asigna un menú contextual vacío a varios TextBox.
        // Se llama al método ContextMenuEliminar para cada uno de los TextBox especificados.
        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtEmail);      
            ContextMenuEliminar(txtNombre);    
            ContextMenuEliminar(txtTelefono);   
            ContextMenuEliminar(txtUsuario);    
            ContextMenuEliminar(txtRespuesta);  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // Obteniene el texto actual del TextBox
            string text = txtTelefono.Text;

            // definimos los caracteres válidos que se permiten en el textbox
            string validChars = "0123456789-";

            // filtramos el texto para que contenga solo los caracteres validos
            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            // Si el texto introducido es diferente del texto filtrado este actualiza el textbox.
            if (text != filteredText)
            {
                txtTelefono.Text = filteredText;
                // se mueve el cursor al final del texto en el textbox
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
            // Obtenemos el texto actual del TextBox txtNombre
            string text = txtNombre.Text;

            // definimos el patrón  que solo permite letras y espacios
            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);

            // si no coincide con los caracteres permitidos se filtra el texto para que contenga solo letras y espacios
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
    }

    }

   
