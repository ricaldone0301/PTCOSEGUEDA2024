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

        public ViewVerContra()
        {
            InitializeComponent();
        }

        public void Initialize(int personalId)
        {
            this.personalId = personalId;
            LoadUserData();
        }

        private void LoadUserData()
        {

            DAOUsuarios dao = new DAOUsuarios();
            var usuario = dao.GetUsuarioById(personalId);


            txtNombre.Text = usuario.Nombre;
            txtEmail.Text = usuario.Email;
            txtTelefono.Text = usuario.Telefono;
            txtUsuario.Text = usuario.Usuario;
            cbEsp.SelectedValue = usuario.EspecialidadId;
            cbConsul.SelectedValue = usuario.ConsultorioId;
            cbRol.SelectedValue = usuario.Rol;

        }
    }
}


