﻿using PTC.Controller.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgregarPaciente
{
    public partial class ViewAgregarPaciente : Form
    {
        private int id;
        private string nombrepaciente;
        private int edadpaciente;
        private string telefonopaciente;
        private DateTime fechanac;
        private string correopaciente;
        private string nombreocupacion;
        private string direccionpaciente;
        private string dui;
        private string referencia;
        private string nombreemergencia;
        private string numemergencia;
        private string motivoconsulta;
        private string padecimientos;
        private string controlmedico;
        private string medicocabeceranombre;
        private string nummedicocabecera;
        private string alergiamedicamentos;
        private string medicamentos;
        private string operacion;
        private string tipooperacion;
        private string recuperacionoperacion;

        public ViewAgregarPaciente(int accion)
        {
            InitializeComponent();
            ControllerAgregarPaciente ObjAgregarPaciente = new ControllerAgregarPaciente(this, accion);
        }

        public ViewAgregarPaciente(int accion, int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string nombreocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamentos, string operacion, string tipooperacion, string recuperacionoperacion) : this(accion)
        {
            this.id = id;
            this.nombrepaciente = nombrepaciente;
            this.edadpaciente = edadpaciente;
            this.telefonopaciente = telefonopaciente;
            this.fechanac = fechanac;
            this.correopaciente = correopaciente;
            this.nombreocupacion = nombreocupacion;
            this.direccionpaciente = direccionpaciente;
            this.dui = dui;
            this.referencia = referencia;
            this.nombreemergencia = nombreemergencia;
            this.numemergencia = numemergencia;
            this.motivoconsulta = motivoconsulta;
            this.padecimientos = padecimientos;
            this.controlmedico = controlmedico;
            this.medicocabeceranombre = medicocabeceranombre;
            this.nummedicocabecera = nummedicocabecera;
            this.alergiamedicamentos = alergiamedicamentos;
            this.medicamentos = medicamentos;
            this.operacion = operacion;
            this.tipooperacion = tipooperacion;
            this.recuperacionoperacion = recuperacionoperacion;
        }

        public ViewAgregarPaciente(int accion, int id, string nombrepaciente, int edadpaciente, string telefonopaciente, DateTime fechanac, string correopaciente, string ocupacion, string direccionpaciente, string dui, string referencia, string nombreemergencia, string numemergencia, string motivoconsulta, string padecimientos, string controlmedico, string medicocabeceranombre, string nummedicocabecera, string alergiamedicamentos, string medicamento, string operacion, string tipooperacion, string otrosPadecimientos, string recuperacionoperacion)
        {
            InitializeComponent();
            ControllerAgregarPaciente ObjAgregarPaciente = new ControllerAgregarPaciente(this, accion, id, nombrepaciente, edadpaciente, telefonopaciente, fechanac, correopaciente, ocupacion, direccionpaciente, dui, referencia, nombreemergencia, numemergencia, motivoconsulta, padecimientos, controlmedico, medicocabeceranombre, nummedicocabecera, alergiamedicamentos, medicamento, operacion, tipooperacion, otrosPadecimientos, recuperacionoperacion);
        }

        private void txtRecuperacionOperacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbAgregarOcupacion_Enter(object sender, EventArgs e)
        {

        }

        private void bcPadecimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarPadecimientos_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAlergiaMedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarOcupacion_Click(object sender, EventArgs e)
        {

        }

        private void txtMotivoConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel22_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel21_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoOperacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel20_Click(object sender, EventArgs e)
        {

        }

        private void cbOperacionNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOperacionSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void txtNumMedicoCabecera_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtMedicoCabeceraNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void cbControlMedicoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbControlMedicoSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void txtNumEmergencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreEmergencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccionPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cmbOcupacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEdadPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
