using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo
{
    public static class ErrorCode
    {
        public static  readonly Dictionary<string, string> Codes = new Dictionary<string, string>
        {
            { "ERRC001", "ERRC001: Error al agendar una cita"  },
            { "ERRC002", "ERRC002: Error al modificarr una cita"  },
        };

    }
}
