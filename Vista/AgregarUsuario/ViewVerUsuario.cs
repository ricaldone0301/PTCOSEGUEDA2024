using PTC.Vista.AgregarDoctores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgregarUsuario
{
    public partial class ViewVerUsuario : Form
    {
        public ViewVerUsuario(ViewVerUsuario Vista, int accion, string nombre, int rol, int especialidadID, string telefono, int consultorioID, string usuarioPersonal, string contraseñaPersonal, string email)
        {
                 InitializeComponent();
                txtNombre.Text = nombre;
                //txtPersonalID.Text = personalID;
                cbRol.SelectedValue = rol;
                cbEsp.SelectedValue = especialidadID;
                txtTelefono.Text = telefono;
                cbConsul.SelectedValue = consultorioID;
                txtUsuario.Text = usuarioPersonal;
                txtContrasena.Text = contraseñaPersonal;
                txtEmail.Text = email;

                txtNombre.ReadOnly = true;
                //txtPersonalID.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtContrasena.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbRol.Enabled = false;
                cbEsp.Enabled = false;
                cbConsul.Enabled = false;
            }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

