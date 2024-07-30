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
    }
    }
