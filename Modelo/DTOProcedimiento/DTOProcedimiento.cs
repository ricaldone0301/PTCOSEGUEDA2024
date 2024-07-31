using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOProcedimiento
{
    class DtoProcedimiento : dbContext
    {
        private int procedimientoID;
        private string nombreProcedimiento;
        private decimal precioProcedimiento;

        public int ProcedimientoID { get => procedimientoID; set => procedimientoID = value; }
        public string NombreProcedimiento { get => nombreProcedimiento; set => nombreProcedimiento = value; }
        public decimal PrecioProcedimiento { get => precioProcedimiento; set => precioProcedimiento = value; }
    }
}
