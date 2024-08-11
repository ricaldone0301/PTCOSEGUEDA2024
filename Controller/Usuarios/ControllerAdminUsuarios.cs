using Microsoft.VisualBasic.ApplicationServices;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgregarUsuario;
using PTC.Vista.Doctores;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Usuarios
{
    class ControllerAdminUsuarios
    {
        ViewUsuarios ObjAdminUsuario;
        public ControllerAdminUsuarios(ViewUsuarios Vista)
        {
            ObjAdminUsuario = Vista;
            ObjAdminUsuario.Load += new EventHandler(CargarData);
            ObjAdminUsuario.btnNuevo.Click += new EventHandler(NuevoUsuario);
            ObjAdminUsuario.cmsActualizar.Click += new EventHandler(ActualizarUsuario);
            ObjAdminUsuario.cmsEliminar.Click += new EventHandler(EliminarUsuario);
            ObjAdminUsuario.btnBuscar.Click += new EventHandler(BuscarPersonas);
        }
        private void BuscarPersonas(object sender, EventArgs e)
        {
            DAOUsuarios ObjAdmin = new DAOUsuarios();
            DataSet ds = ObjAdmin.BuscarPersonas(ObjAdminUsuario.txtBuscar.Text.Trim());
            ObjAdminUsuario.dgvPersonas.DataSource = ds.Tables["viewPersonal"];
        }
        private void EliminarUsuario(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminUsuario.dgvPersonas.CurrentCell.RowIndex;
            int pos = ObjAdminUsuario.dgvPersonas.CurrentRow.Index;
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOUsuarios daoDel = new DAOUsuarios();
                daoDel.PersonalId = int.Parse(ObjAdminUsuario.dgvPersonas[1, pos].Value.ToString());
                int valorRetornado = daoDel.EliminarUsuario();
                if (valorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarData();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CargarData(object sender, EventArgs e)
        {
           RefrescarData();
        }


        private void ActualizarUsuario(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminUsuario.dgvPersonas.CurrentCell.RowIndex;
            int pos = ObjAdminUsuario.dgvPersonas.CurrentRow.Index;
            int rol, EspecialidadID, consultorioID;
            string PersonalID, Nombre, Telefono, UsuarioPersonal, contraseñaPersonal, email;

            Nombre = ObjAdminUsuario.dgvPersonas[0, pos].Value.ToString();
            PersonalID = ObjAdminUsuario.dgvPersonas[1, pos].Value.ToString();
            EspecialidadID = int.Parse(ObjAdminUsuario.dgvPersonas[2, pos].Value.ToString());
            Telefono = ObjAdminUsuario.dgvPersonas[3, pos].Value.ToString();
            consultorioID = int.Parse(ObjAdminUsuario.dgvPersonas[4, pos].Value.ToString());
            UsuarioPersonal = ObjAdminUsuario.dgvPersonas[5, pos].Value.ToString();
            contraseñaPersonal = ObjAdminUsuario.dgvPersonas[6, pos].Value.ToString();
            rol = int.Parse(ObjAdminUsuario.dgvPersonas[7, pos].Value.ToString());
            email = ObjAdminUsuario.dgvPersonas[8, pos].Value.ToString();


            ViewAgregarUsuario openForm = new ViewAgregarUsuario(2, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email);
            openForm.ShowDialog();
            RefrescarData();

        }
       
        public void RefrescarData()
        {
            DAOUsuarios objAdmin = new DAOUsuarios();
            DataSet ds = objAdmin.ObtenerPersonas();
            ObjAdminUsuario.dgvPersonas.DataSource = ds.Tables["Personal"];
        }

        private void NuevoUsuario(object sender, EventArgs e)
        {
            ViewAgregarUsuario Vista = new ViewAgregarUsuario(1);
            Vista.ShowDialog();
            RefrescarData();
        }
     
    }
}
