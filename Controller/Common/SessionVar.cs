using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Controller.Common
{
    internal class SessionVar
    {
        private static string usuarioPersonal = string.Empty;
        private static string contraseñaPersonal = string.Empty;
        private static int rolID = 0 ;
        private static string nombrePersonal = string.Empty;
        public static string access = string.Empty;

        public static string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public static string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public static string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }

        public static string Access { get => access; set => access = value; }
        public static int Rol { get => rolID; set => rolID = value; }
    }
}
