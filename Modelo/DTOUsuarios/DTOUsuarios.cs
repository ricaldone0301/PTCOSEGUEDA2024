using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOUsuarios
{
    class DtoUsuarios : dbContext
    {
        private string nombrePersonal;
        private int personalID;
        private int especialidadID;
        private string telefono;
        private int consultorioID;
        private string usuarioPersonal;
        private string contraseñaPersonal;
        private int rolID;
        private string email;
        private string usuarioNormal;
        private string contrasenaNormal;

        public string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public int PersonalId { get => personalID; set => personalID = value; }
        public int EspecialidadId { get => especialidadID; set => especialidadID = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int ConsultorioId { get => consultorioID; set => consultorioID = value; }
        public string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }
        public int Rol { get => rolID; set => rolID = value; }
        public string Email { get => email; set => email = value; }
        public string UsuarioNormal { get => usuarioNormal; set => usuarioNormal = value; }
        public string ContrasenaNormal { get => contrasenaNormal; set => contrasenaNormal = value; }
    }
}
