using PTC.Modelo.DAOOcupacion;
using PTC.Modelo.DAOPaciente;
using PTC.Modelo.DAOProcedimiento;
using PTC.Vista.AgendarOcupaciones;
using PTC.Vista.AgregarProcedimiento;
using PTC.Vista.Ocupaciones;
using PTC.Vista.Padecimientos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Ocupacion
{
    internal class ControllerAdminOcupacion
    {
        ViewOcupaciones ObjAdminOcupacion;

        //Maneja la interacion con la vista de administrador de ocupaciones
        
        public ControllerAdminOcupacion(ViewOcupaciones Vista)
        {
            ObjAdminOcupacion = Vista;
            ObjAdminOcupacion.Load += new EventHandler(CargarData);
            ObjAdminOcupacion.cmsVerPaciente.Click += new EventHandler(Ver);
            ObjAdminOcupacion.btnNuevo.Click += new EventHandler(Nuevo);
            ObjAdminOcupacion.cmsActualizar.Click += new EventHandler(Actualizar);
            ObjAdminOcupacion.cmsEliminar.Click += new EventHandler(Eliminar);
            ObjAdminOcupacion.btnBuscar.Click += new EventHandler(BuscarPersonas);
        }

        public void CargarData(object sender, EventArgs e)
        {
            RefrescarData();
        }
        private void BuscarPersonas(object sender, EventArgs e)
        {
            DAOOcupacion ObjAdmin = new DAOOcupacion();
            DataSet ds = ObjAdmin.BuscarOcupacion(ObjAdminOcupacion.txtBuscar.Text.Trim());
            ObjAdminOcupacion.dgvOcupaciones.DataSource = ds.Tables["ViewOcupaciones"];
        }

        private void Eliminar(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminOcupacion.dgvOcupaciones.CurrentCell.RowIndex;
            int pos = ObjAdminOcupacion.dgvOcupaciones.CurrentRow.Index;
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro? Considere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DAOOcupacion daoDel = new DAOOcupacion();
                daoDel.OcupacionID = int.Parse(ObjAdminOcupacion.dgvOcupaciones[1, pos].Value.ToString());
                int valorRetornado = daoDel.EliminarOcupacion();
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

        private void Actualizar(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminOcupacion.dgvOcupaciones.CurrentCell.RowIndex;
            int pos = ObjAdminOcupacion.dgvOcupaciones.CurrentRow.Index;
            int ocupacionID;
            string nombreOcupacion;


            ocupacionID = int.Parse(ObjAdminOcupacion.dgvOcupaciones[0, pos].Value.ToString());
            nombreOcupacion = ObjAdminOcupacion.dgvOcupaciones[1, pos].Value.ToString();


            ViewAgregarOcupacion openForm = new ViewAgregarOcupacion(2, nombreOcupacion, ocupacionID);
            openForm.ShowDialog();
            RefrescarData();

        }
        private void Ver(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminOcupacion.dgvOcupaciones.CurrentCell.RowIndex;
            int pos = ObjAdminOcupacion.dgvOcupaciones.CurrentRow.Index;
            int ocupacionID;
            string nombreOcupacion;


            ocupacionID = int.Parse(ObjAdminOcupacion.dgvOcupaciones[1, pos].Value.ToString());
            nombreOcupacion = ObjAdminOcupacion.dgvOcupaciones[0, pos].Value.ToString();


            ViewAgregarOcupacion openForm = new ViewAgregarOcupacion(3, nombreOcupacion, ocupacionID);
            openForm.ShowDialog();
            RefrescarData();

        }
        public void RefrescarData()
        {
            DAOOcupacion objAdmin = new DAOOcupacion();
            DataSet ds = objAdmin.ObtenerOcupacion();
            ObjAdminOcupacion.dgvOcupaciones.DataSource = ds.Tables["ViewOcupaciones"];
        }

        private void Nuevo(object sender, EventArgs e)
        {
            ViewAgregarOcupacion Vista = new ViewAgregarOcupacion(1);
            Vista.ShowDialog();
            RefrescarData();
        }
    }
}
