using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOOcupacion
{
    internal class DTOocupacion : dbContext
    {
        private int ocupacionID;
        private string nombreOcupacion;

        public int OcupacionID { get => ocupacionID; set => ocupacionID = value; }
        public string NombreOcupacion { get => nombreOcupacion; set => nombreOcupacion = value; }
    }
}
