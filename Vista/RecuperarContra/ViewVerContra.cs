//using PTC.Controller.RecuperarContra;
using PTC.Controller.Usuarios;
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
        private int personalId;

        // Parameterless constructor
        public ViewVerContra()
        {
            InitializeComponent();
        }

        // Method to set the personalId and load user data
        public void Initialize(int personalId)
        {
            this.personalId = personalId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Crear instancia del DAO para obtener la información del usuario
            DAOUsuarios dao = new DAOUsuarios();
            var usuario = dao.GetUsuarioById(personalId);

            // Mostrar la información en los controles del formulario
            txtNombre.Text = usuario.Nombre;
            txtEmail.Text = usuario.Email;
            txtTelefono.Text = usuario.Telefono;
            txtUsuario.Text = usuario.Usuario;
            cbEsp.SelectedValue = usuario.EspecialidadId;
            cbConsul.SelectedValue = usuario.ConsultorioId;
            cbRol.SelectedValue = usuario.Rol;
            // Completa con otros campos que tengas
        }
    }
}


