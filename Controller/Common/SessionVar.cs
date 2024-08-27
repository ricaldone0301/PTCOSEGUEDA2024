using PTC.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Controller.Common
{
    internal class SessionVar : dbContext
    {
        private static string usuarioPersonal;
        private static string contraseñaPersonal;
        private static string nombreRol;
        private static string nombreConsul;
        private static string nombreEsp;
        private static string nombrePersonal;
        private static string telefono;
        public static string access;
        private static int personalId;
        private static string email;

        public static string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public static string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public static string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }


        public static string Access { get => access; set => access = value; }
        public static string Rol { get => nombreRol; set => nombreRol = value; }
        public static int PersonalId { get => personalId; set => personalId = value; }
        public static string Telefono { get => telefono; set => telefono = value; }
        public static string Email { get => email; set => email = value; }
        public static string NombreConsul { get => nombreConsul; set => nombreConsul = value; }
        public static string NombreEsp { get => nombreEsp; set => nombreEsp = value; }
    }
}
