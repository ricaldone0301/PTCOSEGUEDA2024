using PTC.Modelo.DAOProcedimiento;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
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
            ObjAdminProcedimiento.btnNuevo.Click += new EventHandler(NewUser);
                //ObjRegistro.btnEnviar.Click += new EventHandler(NewUser);
            ObjAdminProcedimiento.cmsActualizar.Click += new EventHandler(UpdateUser);
             ObjAdminProcedimiento.cmsEliminar.Click += new EventHandler(DeleteUser);
                // ObjAdminUsuario.dgvPersonas.CellContentClick += new DataGridViewCellEventHandler(dgvPersonas_CellContentClick);
            }

            private void DeleteUser(object sender, EventArgs e)
            {
                int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
                if (MessageBox.Show($"¿Esta seguro que desea eliminar a:\n{ObjAdminProcedimiento.dgvProcedimientos[2, pos].Value.ToString()}\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOProcedimiento daoDel = new DAOProcedimiento();
                    daoDel.ProcedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString());
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

            public void LoadData(object sender, EventArgs e)
            {
                RefrescarData();
            }

            private void UpdateUser(object sender, EventArgs e)
            {
                int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
                int procedimientoID;
                string nombreProcedimiento;
                decimal precioProcedimiento;

                nombreProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[0, pos].Value.ToString();
                precioProcedimiento = decimal.Parse(ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString());



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

            private void NewUser(object sender, EventArgs e)
            {
                ViewAgregarUsuario Vista = new ViewAgregarUsuario(1);
                Vista.ShowDialog();
                RefrescarData();
            }

        }
    }
