using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOPaciente
{
    internal class DtoPaciente : dbContext
    {
        //Declarar variables
        private string nombrePaciente;
        private int edadPaciente;
        private string telefonoPaciente;
        private DateTime fechaNac;
        private string correoPaciente;
        private int ocupacionID;
        private string direccionPaciente;
        private string DUI;
        private string referencia;
        private string nombreEmergencia;
        private string numEmergencia;
        private string motivoConsulta;
        private string padecimientos;
        private string controlMedico;
        private string medicoCabeceraNombre;
        private string numMedicoCabecera;
        private string alergiaMedicamentos;
        private string medicamentos;
        private string operacion;
        private string tipoOperacion;
        private string recuperacionoperacion;
        private int pacienteID;

        //Generar getters y setters
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public int EdadPaciente { get => edadPaciente; set => edadPaciente = value; }
        public string TelefonoPaciente { get => telefonoPaciente; set => telefonoPaciente = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string CorreoPaciente { get => correoPaciente; set => correoPaciente = value; }
        public int OcupacionID { get => ocupacionID; set => ocupacionID = value; }
        public string DireccionPaciente { get => direccionPaciente; set => direccionPaciente = value; }
        public string DUI1 { get => DUI; set => DUI = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string NombreEmergencia { get => nombreEmergencia; set => nombreEmergencia = value; }
        public string NumEmergencia { get => numEmergencia; set => numEmergencia = value; }
        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public string Padecimientos { get => padecimientos; set => padecimientos = value; }
        public string ControlMedico { get => controlMedico; set => controlMedico = value; }
        public string MedicoCabeceraNombre { get => medicoCabeceraNombre; set => medicoCabeceraNombre = value; }
        public string NumMedicoCabecera { get => numMedicoCabecera; set => numMedicoCabecera = value; }
        public string AlergiaMedicamentos { get => alergiaMedicamentos; set => alergiaMedicamentos =value; }
        public string Medicamentos { get => medicamentos; set => medicamentos = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string TipoOperacion { get => tipoOperacion; set => tipoOperacion = value; }
        public string RecuperacionOperacion { get => recuperacionoperacion; set => recuperacionoperacion = value; }
        public int PacienteID { get => pacienteID; set => pacienteID = value; }
        }
    }
