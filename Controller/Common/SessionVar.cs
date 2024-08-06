using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Controller.Common
{
    internal class SessionVar
    {
        private static string usuarioPersonal;
        private static string contraseñaPersonal;
        private static int rolID;
        private static string nombrePersonal;
        public static string access;

        public static string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public static string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public static string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }

        public static string Access { get => access; set => access = value; }
        public static int Rol { get => rolID; set => rolID = value; }
    }
}
