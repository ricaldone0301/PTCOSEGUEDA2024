using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOContrasena
{
    internal class DtoContrasena : dbContext
    {

        private string email;
        private string contraseñaPersonal;


        public string Email { get => email; set => email = value; }
        public string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }
    }
}
