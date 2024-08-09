using PTC.Modelo.DAOPaciente;
using PTC.Vista.AgregarPaciente;
using PTC.Vista.Paciente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Paciente
{
    internal class ControllerAdminPaciente
    {

        ViewPaciente objVistaPacientes;

        public ControllerAdminPaciente(ViewPaciente vistaPacientes)
        {
            objVistaPacientes = vistaPacientes;
            objVistaPacientes.btnNuevoPaciente.Click += new EventHandler(NuevoPaciente);
            objVistaPacientes.cmsActualizarPaciente.Click += new EventHandler(ActualizarPaciente);
            objVistaPacientes.cmsEliminarPaciente.Click += new EventHandler(EliminarPaciente);
            objVistaPacientes.cmsVerPaciente.Click += new EventHandler(VerDatos);
            objVistaPacientes.btnBuscar.Click += new EventHandler(Buscar);
        }

        public void RefrescarDatos()
        {
            DAOPaciente objDAO = new DAOPaciente();
            DataSet dataSet = objDAO.ObtenerPacientes();
            objVistaPacientes.dgvPacientes.DataSource = dataSet.Tables["PacientesVista"];
        }

        private void NuevoPaciente(object sender, EventArgs e)
        {
            ViewAgregarPaciente agregarPaciente = new ViewAgregarPaciente(1);
            agregarPaciente.ShowDialog();
            RefrescarDatos();
        }

        private void ActualizarPaciente(object sender, EventArgs e)
        {
            int pos = objVistaPacientes.dgvPacientes.CurrentRow.Index;

            ViewAgregarPaciente agregarPaciente = new ViewAgregarPaciente(2,
                int.Parse(objVistaPacientes.dgvPacientes[0, pos].Value.ToString()),
                objVistaPacientes.dgvPacientes[1, pos].Value.ToString(),
                int.Parse(objVistaPacientes.dgvPacientes[2, pos].Value.ToString()),
                objVistaPacientes.dgvPacientes[3, pos].Value.ToString(),
                DateTime.Parse(objVistaPacientes.dgvPacientes[4, pos].Value.ToString()),
                objVistaPacientes.dgvPacientes[5, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[6, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[7, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[8, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[9, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[10, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[11, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[12, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[13, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[14, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[15, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[16, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[17, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[18, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[19, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[20, pos].Value.ToString(),
                objVistaPacientes.dgvPacientes[21, pos].Value.ToString());

            agregarPaciente.ShowDialog();
            RefrescarDatos();
        }

        private void VerDatos(object sender, EventArgs e)
        {
            int pos = objVistaPacientes.dgvPacientes.CurrentRow.Index;
            string nombrepaciente, telefonopaciente, correopaciente, nombreocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamentos, operacion, tipooperacion, recuperacionoperacion;
            int edadpaciente, id;
            DateTime fechanac;

            id = int.Parse(objVistaPacientes.dgvPacientes[0, pos].Value.ToString());
            nombrepaciente = objVistaPacientes.dgvPacientes[1, pos].Value.ToString();
            edadpaciente = int.Parse(objVistaPacientes.dgvPacientes[2, pos].Value.ToString());
            telefonopaciente = objVistaPacientes.dgvPacientes[3, pos].Value.ToString();
            fechanac = DateTime.Parse(objVistaPacientes.dgvPacientes[4, pos].Value.ToString());
            correopaciente = objVistaPacientes.dgvPacientes[5, pos].Value.ToString();
            nombreocupacion = objVistaPacientes.dgvPacientes[6, pos].Value.ToString();
            direccionpaciente = objVistaPacientes.dgvPacientes[7, pos].Value.ToString();
            dui = objVistaPacientes.dgvPacientes[8, pos].Value.ToString();
            referencia = objVistaPacientes.dgvPacientes[9, pos].Value.ToString();
            nombreemergencia = objVistaPacientes.dgvPacientes[10, pos].Value.ToString();
            numemergencia = objVistaPacientes.dgvPacientes[11, pos].Value.ToString();
            motivoconsulta = objVistaPacientes.dgvPacientes[12, pos].Value.ToString();
            padecimientos = objVistaPacientes.dgvPacientes[13, pos].Value.ToString();
            controlmedico = objVistaPacientes.dgvPacientes[14, pos].Value.ToString();
            medicocabeceranombre = objVistaPacientes.dgvPacientes[15, pos].Value.ToString();
            nummedicocabecera = objVistaPacientes.dgvPacientes[16, pos].Value.ToString();
            alergiamedicamentos = objVistaPacientes.dgvPacientes[17, pos].Value.ToString();
            medicamentos = objVistaPacientes.dgvPacientes[18, pos].Value.ToString();
            operacion = objVistaPacientes.dgvPacientes[19, pos].Value.ToString();
            tipooperacion = objVistaPacientes.dgvPacientes[20, pos].Value.ToString();
            recuperacionoperacion = objVistaPacientes.dgvPacientes[21, pos].Value.ToString();

            ViewAgregarPaciente agregarPaciente = new ViewAgregarPaciente(3, id, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, nombreocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamentos, operacion, tipooperacion, recuperacionoperacion);
            agregarPaciente.ShowDialog();
            RefrescarDatos();
        }

        private void EliminarPaciente(object sender, EventArgs e)
        {
            int pos = objVistaPacientes.dgvPacientes.CurrentRow.Index;

            if (MessageBox.Show($"¿Está seguro que desea eliminar el expediente de {objVistaPacientes.dgvPacientes[1, pos].Value.ToString()}? La acción no puede ser revertida.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPaciente objdao = new DAOPaciente();
                objdao.PacienteID = int.Parse(objVistaPacientes.dgvPacientes[0, pos].Value.ToString());
                objdao.NombrePaciente = objVistaPacientes.dgvPacientes[1, pos].Value.ToString();
                int valor = objdao.EliminarPaciente();
                if (valor == 2)
                {
                    MessageBox.Show("Expediente eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDatos();
                }
                else
                {
                    MessageBox.Show("El expediente no pudo ser eliminado.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefrescarDatos();
                }
            }
        }

        void ControladorBuscarPacientes()
        {
            DAOPaciente objdao = new DAOPaciente();
            DataSet dataset = objdao.BuscarPacientes(objVistaPacientes.txtBuscar.Text.Trim());
            objVistaPacientes.dgvPacientes.DataSource = dataset.Tables["PacientesVista"];
        }

        public void Buscar(object sender, EventArgs e)
        {
            ControladorBuscarPacientes();
        }
    }
}

