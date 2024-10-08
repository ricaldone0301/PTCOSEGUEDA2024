﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DTOPrimerUso
{
     class DtoPrimerUso: dbContext
    {
        private string nombrePersonal;
        private string personalID;
        private int especialidadID;
        private string telefono;
        private int consultorioID;
        private string usuarioPersonal;
        private string contraseñaPersonal;
        private int rolID;
        private string email;
        //Creacion Empresa info
        private string nombreEmpresa;
        private string telefonoEmpresa;
        private string direccion;
        private string emailEmpresa;

        public string Nombre { get => nombrePersonal; set => nombrePersonal = value; }
        public string PersonalId { get => personalID; set => personalID = value; }
        public int EspecialidadId { get => especialidadID; set => especialidadID = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int ConsultorioId { get => consultorioID; set => consultorioID = value; }
        public string Usuario { get => usuarioPersonal; set => usuarioPersonal = value; }
        public string Contrasena { get => contraseñaPersonal; set => contraseñaPersonal = value; }
        public int Rol { get => rolID; set => rolID = value; }
        public string Email { get => email; set => email = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string TelefonoEmpresa { get => telefonoEmpresa; set => telefonoEmpresa = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string EmailEmpresa { get => emailEmpresa; set => emailEmpresa = value; }
    }
}
    