using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOLogin
{
        public class DtoLogin : dbContext
        {
        private  string usuarioPersonal;
        private  string contraseñaPersonal;
        private  int rolID;
        private  string nombrePersonal;
        public  string access;
        private static string usuarioNormal;

        public  string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public  string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }

        public  string Access { get => access; set => access = value; }

        public string UsuarioNormal { get => usuarioNormal; set => usuarioNormal = value; }

        public  int Rol { get => rolID; set => rolID = value; }
        }

    }

