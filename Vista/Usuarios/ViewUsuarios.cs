using PTC.Controller.Dasboard;
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

namespace PTC.Vista.Doctores
{
    public partial class ViewUsuarios : Form
    {
        ViewUsuarios ObjAdminUsuario;
        public ViewUsuarios()
        {
            InitializeComponent();
            ControllerAdminUsuarios ObjAdminUsuario = new ControllerAdminUsuarios(this);
        }

        public void ViewUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cmsVerPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
