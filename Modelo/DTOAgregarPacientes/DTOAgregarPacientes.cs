using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOAgregarPacientes
{
    internal class DTOAgregarPacientes
    {
        private string nombrePaciente;
        private int edadPaciente;
        private string telefonoPaciente;
        private DateTime fechaNac;
        private string correoPaciente;
        private string nombreOcupacion;
        private string direccionPaciente;
        private string DUI;
        private string referencia;
        private string nombreEmergencia;
        private string numEmergencia;
        private string motivoConsulta;
        private string nombrePadecimiento;
        private bool controlMedico;
        private string medicoCabeceraNombre;
        private string numMedicoCabecera;
        private string nombreAlergiaMedicamento;
        private string nombreMedicamento;
        private bool operacion;
        private string tipoOperacion;
        private string recuperacionOperacion;

        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public int EdadPaciente { get => edadPaciente; set => edadPaciente = value; }
        public string TelefonoPaciente { get => telefonoPaciente; set => telefonoPaciente = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string CorreoPaciente { get => correoPaciente; set => correoPaciente = value; }
        public string NombreOcupacion { get => nombreOcupacion; set => nombreOcupacion = value; }
        public string DireccionPaciente { get => direccionPaciente; set => direccionPaciente = value; }
        public string DUI1 { get => DUI; set => DUI = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string NombreEmergencia { get => nombreEmergencia; set => nombreEmergencia = value; }
        public string NumEmergencia { get => numEmergencia; set => numEmergencia = value; }
        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public string NombrePadecimiento { get => nombrePadecimiento; set => nombrePadecimiento = value; }
        public bool ControlMedico { get => controlMedico; set => controlMedico = value; }
        public string MedicoCabeceraNombre { get => medicoCabeceraNombre; set => medicoCabeceraNombre = value; }
        public string NumMedicoCabecera { get => numMedicoCabecera; set => numMedicoCabecera = value; }
        public string NombreAlergiaMedicamento { get => nombreAlergiaMedicamento; set => nombreAlergiaMedicamento = value; }
        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = value; }
        public bool Operacion { get => operacion; set => operacion = value; }
        public string TipoOperacion { get => tipoOperacion; set => tipoOperacion = value; }
        public string RecuperacionOperacion { get => recuperacionOperacion; set => recuperacionOperacion = value; }

    }
}
