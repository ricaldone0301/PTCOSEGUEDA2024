using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOProcedimiento
{
    class DtoProcedimiento : dbContext
    {
        private int procedimientoID;
        private string nombreProcedimiento;
        private decimal precioProcedimiento;
        private string descProcedimiento;
        private int rolID;
        public int ProcedimientoID { get => procedimientoID; set => procedimientoID = value; }
        public string NombreProcedimiento { get => nombreProcedimiento; set => nombreProcedimiento = value; }
        public decimal PrecioProcedimiento { get => precioProcedimiento; set => precioProcedimiento = value; }
        public string DescProcedimiento { get => descProcedimiento; set => descProcedimiento = value; }
        public int Rol { get => rolID; set => rolID = value; }
    }
}
