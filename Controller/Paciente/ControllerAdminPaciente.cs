﻿using PTC.Modelo.DAOPaciente;
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

        ViewPaciente ObjAdminPaciente;

        public ControllerAdminPaciente(ViewPaciente vistaPacientes)
        {
            ObjAdminPaciente = vistaPacientes;
            ObjAdminPaciente.Load += new EventHandler(Load);
            ObjAdminPaciente.btnNuevoPaciente.Click += new EventHandler(NuevoPaciente);
            ObjAdminPaciente.cmsActualizarPaciente.Click += new EventHandler(ActualizarPaciente);
            ObjAdminPaciente.cmsEliminarPaciente.Click += new EventHandler(EliminarPaciente);
            ObjAdminPaciente.btnBuscar.Click += new EventHandler(Buscar);
        }
        private void Buscar(object sender, EventArgs e)
        {
            DAOPaciente ObjAdminBuscar = new DAOPaciente();
            DataSet ds = ObjAdminBuscar.BuscarPersonas(ObjAdminPaciente.txtBuscar.Text.Trim());
            ObjAdminPaciente.dgvPacientes.DataSource = ds.Tables["ViewPacientes"];
        }
        private void EliminarPaciente(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminPaciente.dgvPacientes.CurrentCell.RowIndex;
            int pos = ObjAdminPaciente.dgvPacientes.CurrentRow.Index;
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPaciente daoDel = new DAOPaciente();
                daoDel.PacienteID = int.Parse(ObjAdminPaciente.dgvPacientes[0, pos].Value.ToString());
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

        private void ActualizarPaciente(object sender, EventArgs e)
        {
            int rowIndex = ObjAdminPaciente.dgvPacientes.CurrentCell.RowIndex;
            int pos = ObjAdminPaciente.dgvPacientes.CurrentRow.Index;
            int edadpaciente;
            int pacienteID;
            DateTime fechaNac;
            string nombrepaciente, telefonopaciente, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion;

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


            ViewAgregarPaciente openForm = new ViewAgregarPaciente(2, pacienteID, nombrepaciente, edadpaciente, telefonopaciente, fechaNac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, recuperacionoperacion);
            openForm.ShowDialog();
            RefrescarData();

        }

        public void RefrescarData()
        {
            DAOPaciente objAdmin = new DAOPaciente();
            DataSet ds = objAdmin.ObtenerPersonas();
            ObjAdminPaciente.dgvPacientes.DataSource = ds.Tables["ViewPacientes"];
        }

        private void NuevoPaciente(object sender, EventArgs e)
        {
            ViewAgregarPaciente Vista = new ViewAgregarPaciente(1);
            Vista.ShowDialog();
            RefrescarData();
        }

    }
}

