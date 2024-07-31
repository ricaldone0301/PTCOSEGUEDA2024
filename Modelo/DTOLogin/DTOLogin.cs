using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOLogin
{
        public class DtoLogin : dbContext
        {
            private string usuarioPersonal;
            private string contraseñaPersonal;
            private string access;

            public string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
            public string Contraseña { get => contraseñaPersonal; set => contraseñaPersonal = value; }
            public string Access { get => access; set => access = value; }
    }

    }

