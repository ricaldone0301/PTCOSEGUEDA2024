using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOCitas
{
    class DtoCitas : dbContext
    {
        private int pacienteID;
        private int procedimientoID;
        private string personalID;
        private int consultorioID;
        private string hora;
        private DateTime fecha;
        private int citaID;

        public int PacienteID { get => pacienteID; set => pacienteID = value; }

        public string PersonalID { get => personalID; set => personalID = value; }
        public int ConsultorioID { get => consultorioID; set => consultorioID = value; }
        public string Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int CitaID { get => citaID; set => citaID = value; }
        public int ProcedimientoID {  get => procedimientoID; set => procedimientoID = value;}
    }
}