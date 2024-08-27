using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOPreguntaContra
{
    internal class DtoPreguntaContra : dbContext
    {
        private string contraseñaPersonal;
        private string email;
        private int preguntaID;
        private string respuesta;

      
        public string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }

        public string Email { get => email; set => email = value; }
        public int PreguntaID { get => preguntaID; set => preguntaID = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
    }
}

