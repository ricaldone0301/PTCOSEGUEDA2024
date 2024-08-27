using PTC.Modelo.DAOLogin;
using PTC.Modelo.DAOPrimerUso;
using PTC.Vista;
using PTC.Vista.Login;
using PTC.Vista.PrimerUso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller
{
    internal class ControllerInit
    {
        public static void DeterminarVistaInicial()
        {
            DAOPrimerUso ObjPrimerUso = new DAOPrimerUso();
            
            int primerEmpresa =  ObjPrimerUso.VerificarEmpresa();
            int primerUsuario = ObjPrimerUso.VerificarRegistro();
            if (primerEmpresa == 0)
            {
                Application.Run(new ViewPrimerUsoInfo());
            }
            else if (primerUsuario == 0)
            {
                Application.Run(new ViewPrimerUso());
            }
            else

            {
                Application.Run(new ViewLogin());
            }
        }
    }
}
