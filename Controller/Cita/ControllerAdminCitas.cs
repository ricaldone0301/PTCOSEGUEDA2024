using PTC.Modelo.DAOCitas;
using PTC.Modelo.DAOProcedimiento;
using PTC.Vista.AgendarCita;
using PTC.Vista.Cita;
using PTC.Vista.Doctores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Cita
{
    class ControllerAdminCitas
    {
        ViewCitas ObjAdminCitas;
        public ControllerAdminCitas(ViewCitas Vista)
        {
            ObjAdminCitas = Vista;
            ObjAdminCitas.Load += new EventHandler(LoadData);
            ObjAdminCitas.btnNuevo.Click += new EventHandler(NewUser);
            ObjAdminCitas.cmsActualizar.Click += new EventHandler(UpdateUser);
            ObjAdminCitas.cmsEliminar.Click += new EventHandler(DeleteUser);
            ObjAdminCitas.btnBuscar.Click += new EventHandler(BuscarPersonas);
        }

        private void BuscarPersonas(object sender, EventArgs e)
        {
            DAOProcedimiento ObjAdmin = new DAOProcedimiento();
            DataSet ds = ObjAdmin.BuscarPersonas(ObjAdminCitas.txtBuscar.Text.Trim());
            ObjAdminCitas.dgvCitas.DataSource = ds.Tables["ViewProcedimientos"];
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminCitas.dgvCitas.CurrentCell.RowIndex;
            int pos = ObjAdminCitas.dgvCitas.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que quiere eliminar esta cita?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOCitas daoDel = new DAOCitas();
                daoDel.CitaID = int.Parse(ObjAdminCitas.dgvCitas[1, pos].Value.ToString());
                int valorRetornado = daoDel.EliminarCita();
                if (valorRetornado == 1)
                {
                    MessageBox.Show("Cita eliminada", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int rowIndex = ObjAdminCitas.dgvCitas.CurrentCell.RowIndex;
            int pos = ObjAdminCitas.dgvCitas.CurrentRow.Index;
            int pacienteID, consultorioID, citaID, procedimientoID;
            string personalID;
            DateTime hora, fecha;

            citaID = int.Parse(ObjAdminCitas.dgvCitas[1, pos].Value.ToString());
            pacienteID = int.Parse(ObjAdminCitas.dgvCitas[2, pos].Value.ToString());
            personalID = ObjAdminCitas.dgvCitas[3, pos].Value.ToString();
            consultorioID = int.Parse(ObjAdminCitas.dgvCitas[4, pos].Value.ToString());
            hora = DateTime.Parse(ObjAdminCitas.dgvCitas[5, pos].Value.ToString());
            fecha = DateTime.Parse(ObjAdminCitas.dgvCitas[6, pos].Value.ToString());
            procedimientoID = int.Parse(ObjAdminCitas.dgvCitas[7, pos].Value.ToString());


            ViewAgendarcita openForm = new ViewAgendarcita(2, pacienteID, personalID, consultorioID, hora, fecha, citaID, procedimientoID);
            openForm.ShowDialog();
            RefrescarData();
        }

        public void RefrescarData()
        {
            DAOCitas objAdmin = new DAOCitas();
            DataSet ds = objAdmin.ComboBoxDoctor();
            ObjAdminCitas.dgvCitas.DataSource = ds.Tables["Citas"];
        }

        private void NewUser(object sender, EventArgs e)
        {
            ViewAgendarcita Vista = new ViewAgendarcita(1);
            Vista.ShowDialog();
            RefrescarData();
        }

    }
}
