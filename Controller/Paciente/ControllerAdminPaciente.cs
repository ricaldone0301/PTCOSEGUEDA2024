using PTC.Modelo.DAOPaciente;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
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
        //Objeto de la vista
        ViewPaciente ObjAdminPaciente;

        public ControllerAdminPaciente(ViewPaciente vistaPacientes)
        {
            //Eventos
            ObjAdminPaciente = vistaPacientes;
            //Mientras el formulario carga, se ejecua el metodo Load
            ObjAdminPaciente.Load += new EventHandler(Load);
            ObjAdminPaciente.cmsVerPaciente.Click += new EventHandler(Ver);
            //Cuando se le da clic al boton de agregar paciente se ejecuta el metodo NuevoPaciente
            ObjAdminPaciente.btnNuevo.Click += new EventHandler(NuevoPaciente);
            //Cuando se le da clic al boton de actualizar se ejecuta el metodo ActualizarPaciente
            ObjAdminPaciente.cmsActualizar.Click += new EventHandler(ActualizarPaciente);
            //Cuando se le da clic al boton de Eliminar, se ejecuta el metodo EliminarPaciente
            ObjAdminPaciente.cmsEliminar.Click += new EventHandler(EliminarPaciente);
            //Cuando se le da clic al boton de buscar, se ejecuta el metodo Buscar
            ObjAdminPaciente.btnBuscar.Click += new EventHandler(Buscar);
        }
        private void Buscar(object sender, EventArgs e)
        {
            //Se crea un objeto del DAO
            DAOPaciente ObjAdminBuscar = new DAOPaciente();
            //Se ejecuta el metodo BuscarPersonas del DAO y se envia el texto del txtBuscar para que lo tome como el valor requerido
            DataSet ds = ObjAdminBuscar.BuscarPersonas(ObjAdminPaciente.textBox1.Text.Trim());
            //Se muestran las opciones que devuelve el metodo del DAO
            ObjAdminPaciente.dgvPacientes.DataSource = ds.Tables["ViewPacientes"];
        }
        private void EliminarPaciente(object sender, EventArgs e)
        {
            //Se declara la variable pos, esta indica la fila seleccionada
            int pos = ObjAdminPaciente.dgvPacientes.CurrentRow.Index;
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Se crea un objeto del DAO
                DAOPaciente daoDel = new DAOPaciente();
                //Se toma el id del paciente que se encuentra en la columna 0 de la fila seleccionada
                daoDel.PacienteID = int.Parse(ObjAdminPaciente.dgvPacientes[0, pos].Value.ToString());
                //Se ejecuta el metodo EliminarUsuario del DAO
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

        public void Load(object sender, EventArgs e)
        {
            RefrescarData();
        }

        private void Ver(object sender, EventArgs e)
        {
            //Se declara la variable pos, esta indica la fila seleccionada
            int pos = ObjAdminPaciente.dgvPacientes.CurrentRow.Index;
            //Se declaran las variables necesarias para almacenar todos los datos de la fila
            int edadpaciente;
            int pacienteID;
            DateTime fechaNac;
            string nombrepaciente, telefonopaciente, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion;
            //Se almacena cada columna en su respectiva variable
            pacienteID = int.Parse(ObjAdminPaciente.dgvPacientes[0, pos].Value.ToString());
            nombrepaciente = ObjAdminPaciente.dgvPacientes[1, pos].Value.ToString();
            edadpaciente = int.Parse(ObjAdminPaciente.dgvPacientes[2, pos].Value.ToString());
            telefonopaciente = ObjAdminPaciente.dgvPacientes[3, pos].Value.ToString();
            fechaNac = DateTime.Parse(ObjAdminPaciente.dgvPacientes[4, pos].Value.ToString());
            correopaciente = ObjAdminPaciente.dgvPacientes[5, pos].Value.ToString();
            ocupacion = ObjAdminPaciente.dgvPacientes[6, pos].Value.ToString();
            direccionpaciente = ObjAdminPaciente.dgvPacientes[7, pos].Value.ToString();
            dui = ObjAdminPaciente.dgvPacientes[8, pos].Value.ToString();
            referencia = ObjAdminPaciente.dgvPacientes[9, pos].Value.ToString();
            nombreemergencia = ObjAdminPaciente.dgvPacientes[10, pos].Value.ToString();
            numemergencia = ObjAdminPaciente.dgvPacientes[11, pos].Value.ToString();
            motivoconsulta = ObjAdminPaciente.dgvPacientes[12, pos].Value.ToString();
            controlmedico = ObjAdminPaciente.dgvPacientes[13, pos].Value.ToString();
            medicocabeceranombre = ObjAdminPaciente.dgvPacientes[14, pos].Value.ToString();
            medicamento = ObjAdminPaciente.dgvPacientes[17, pos].Value.ToString();
            nummedicocabecera = ObjAdminPaciente.dgvPacientes[15, pos].Value.ToString();
            alergiamedicamentos = ObjAdminPaciente.dgvPacientes[16, pos].Value.ToString();
            operacion = ObjAdminPaciente.dgvPacientes[18, pos].Value.ToString();
            tipooperacion = ObjAdminPaciente.dgvPacientes[19, pos].Value.ToString();
            recuperacionoperacion = ObjAdminPaciente.dgvPacientes[20, pos].Value.ToString();
            padecimientos = ObjAdminPaciente.dgvPacientes[21, pos].Value.ToString();

            //Se ejecuta el formulario de Agregar Pacientes y se manda con accion siendo 2 y todas las variables a la vista para que se muestren y poder actualizarlos
            ViewAgregarPaciente openForm = new ViewAgregarPaciente(3, pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechaNac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
            openForm.ShowDialog();
            RefrescarData();

        }
        private void ActualizarPaciente(object sender, EventArgs e)
        {
            //Se declara la variable pos, esta indica la fila seleccionada
            int pos = ObjAdminPaciente.dgvPacientes.CurrentRow.Index;
            //Se declaran las variables necesarias para almacenar todos los datos de la fila
            int edadpaciente;
            int pacienteID;
            DateTime fechaNac;
            string nombrepaciente, telefonopaciente, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion;
            //Se almacena cada columna en su respectiva variable
            pacienteID = int.Parse(ObjAdminPaciente.dgvPacientes[0, pos].Value.ToString());
              nombrepaciente= ObjAdminPaciente.dgvPacientes[1, pos].Value.ToString();
              edadpaciente = int.Parse(ObjAdminPaciente.dgvPacientes[2, pos].Value.ToString());
              telefonopaciente =  ObjAdminPaciente.dgvPacientes[3, pos].Value.ToString();
              fechaNac =  DateTime.Parse(ObjAdminPaciente.dgvPacientes[4, pos].Value.ToString());
            correopaciente =  ObjAdminPaciente.dgvPacientes[5, pos].Value.ToString();
             ocupacion = ObjAdminPaciente.dgvPacientes[6, pos].Value.ToString();
           direccionpaciente = ObjAdminPaciente.dgvPacientes[7, pos].Value.ToString();
           dui = ObjAdminPaciente.dgvPacientes[8, pos].Value.ToString();
           referencia = ObjAdminPaciente.dgvPacientes[9, pos].Value.ToString();
           nombreemergencia= ObjAdminPaciente.dgvPacientes[10, pos].Value.ToString();
           numemergencia= ObjAdminPaciente.dgvPacientes[11, pos].Value.ToString();
           motivoconsulta=  ObjAdminPaciente.dgvPacientes[12, pos].Value.ToString();
            controlmedico = ObjAdminPaciente.dgvPacientes[13, pos].Value.ToString();
            medicocabeceranombre= ObjAdminPaciente.dgvPacientes[14, pos].Value.ToString();
            medicamento = ObjAdminPaciente.dgvPacientes[17, pos].Value.ToString();
            nummedicocabecera =   ObjAdminPaciente.dgvPacientes[15, pos].Value.ToString();
               alergiamedicamentos= ObjAdminPaciente.dgvPacientes[16, pos].Value.ToString();
            operacion = ObjAdminPaciente.dgvPacientes[18, pos].Value.ToString();
              tipooperacion =  ObjAdminPaciente.dgvPacientes[19, pos].Value.ToString();
            recuperacionoperacion = ObjAdminPaciente.dgvPacientes[20, pos].Value.ToString();
            padecimientos = ObjAdminPaciente.dgvPacientes[21, pos].Value.ToString();

            //Se ejecuta el formulario de Agregar Pacientes y se manda con accion siendo 2 y todas las variables a la vista para que se muestren y poder actualizarlos
            ViewAgregarPaciente openForm = new ViewAgregarPaciente(2, pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechaNac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
            openForm.ShowDialog();
            RefrescarData();

        }

        public void RefrescarData()
        {
            //Se crea un objeto del DAO
            DAOPaciente objAdmin = new DAOPaciente();
            //Se obtiene lo que retorna el metodo ObtenerPersonas del DAO
            DataSet ds = objAdmin.ObtenerPersonas();
            //Se muestran los datos que devuelve el metodo del DAO 
            ObjAdminPaciente.dgvPacientes.DataSource = ds.Tables["ViewPacientes"];
        }

        private void NuevoPaciente(object sender, EventArgs e)
        {
            //Se ejecuta el formulario de Agregar Pacientes con accion siendo 1
            ViewAgregarPaciente Vista = new ViewAgregarPaciente(1);
            Vista.ShowDialog();
            RefrescarData();
        }

    }
}