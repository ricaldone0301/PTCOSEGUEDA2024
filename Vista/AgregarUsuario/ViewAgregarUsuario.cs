using PTC.Controller.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PTC.Vista.AgregarDoctores
{
    public partial class ViewAgregarUsuario : Form
    {

            public ViewAgregarUsuario(int accion)
            {
                InitializeComponent();
                ControllerAgregarusuario objAgregarUsuario = new ControllerAgregarusuario(this, accion);
            }

            public ViewAgregarUsuario(int accion, string Nombre, string PersonalID, int rol, int EspecialidadID, string Telefono, int consultorioID, string UsuarioPersonal, string contraseñaPersonal, string email)
            {
                InitializeComponent();
                ControllerAgregarusuario objAgregarUsuario = new ControllerAgregarusuario(this, accion, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email);
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txtNombre.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Text.Remove(txtNombre.Text.Length - 1);
                    txtNombre.Clear();
                    txtNombre.Focus();
                }
            }
        }
    }


    }
   
