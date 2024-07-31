using PTC.Modelo.DAOProcedimiento;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgregarProcedimiento;
using PTC.Vista.Doctores;
using PTC.Vista.Padecimientos;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Procedimiento
{

        class ControllerAdminProcedimientos
        {
            ViewProcedimiento ObjAdminProcedimiento;

            public ControllerAdminProcedimientos(ViewProcedimiento Vista)
            {
            ObjAdminProcedimiento = Vista;
            ObjAdminProcedimiento.Load += new EventHandler(LoadData);
            ObjAdminProcedimiento.btnNuevo.Click += new EventHandler(Nuevo);
                //ObjRegistro.btnEnviar.Click += new EventHandler(NewUser);
            ObjAdminProcedimiento.cmsActualizar.Click += new EventHandler(Actualizar);
             ObjAdminProcedimiento.cmsEliminar.Click += new EventHandler(Eliminar);
                // ObjAdminUsuario.dgvPersonas.CellContentClick += new DataGridViewCellEventHandler(dgvPersonas_CellContentClick);
            }

            private void Eliminar(object sender, EventArgs e)
            {
                int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
                if (MessageBox.Show($"¿Esta seguro que desea eliminar a:\n{ObjAdminProcedimiento.dgvProcedimientos[2, pos].Value.ToString()}\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOProcedimiento daoDel = new DAOProcedimiento();
                    daoDel.ProcedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString());
                    int valorRetornado = daoDel.EliminarProcedimiento();
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

            public void LoadData(object sender, EventArgs e)
            {
                RefrescarData();
            }

            private void Actualizar(object sender, EventArgs e)
            {
                int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
                int procedimientoID;
                string nombreProcedimiento, descProcedimiento;
                decimal precioProcedimiento;
                
                procedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[0,pos].Value.ToString());
                nombreProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString();
                precioProcedimiento = decimal.Parse(ObjAdminProcedimiento.dgvProcedimientos[2, pos].Value.ToString());
                descProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[3, pos].Value.ToString();



            //ViewProcedimiento openForm = new ViewProcedimiento(2, nombreProcedimiento, precioProcedimiento);
            //openForm.ShowDialog();
            RefrescarData();

            }

            public void RefrescarData()
            {
                DAOProcedimiento objAdmin = new DAOProcedimiento();
                DataSet ds = objAdmin.ObtenerProcedimiento();
                ObjAdminProcedimiento.dgvProcedimientos.DataSource = ds.Tables["Procedimientos"];
            }

            private void Nuevo(object sender, EventArgs e)
            {
                ViewAgregarProcedimiento Vista = new ViewAgregarProcedimiento(1);
                Vista.ShowDialog();
                RefrescarData();
            }

        }
    }
