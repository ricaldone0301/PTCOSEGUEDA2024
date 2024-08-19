using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTORecuperar
{
    internal class DtoRecuperar : dbContext
    {
        private string usuarioPersonal;
        private string contraseñaPersonal;
        private int rolID;
        private string nombrePersonal;
        public string access;

        public string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }

        public string Access { get => access; set => access = value; }
        public int Rol { get => rolID; set => rolID = value; }
    }
}

