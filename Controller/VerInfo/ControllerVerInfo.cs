using PTC.Controller.Common;
using PTC.Modelo.DTOPrimerUso;
using PTC.Vista.AcercaDe;
using PTC.Vista.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.VerInfo
{
    internal class ControllerVerInfo
    {
        ViewAcercaDe ObjAcercaDe;
        DtoPrimerUso dtoPrimerUso;
        Form currentForm;


        public ControllerVerInfo(ViewAcercaDe View)
        {

            ObjAcercaDe = View;
            ObjAcercaDe.lblCorreo.Text = dtoPrimerUso.Email;
            ObjAcercaDe.lblNombre.Text = dtoPrimerUso.NombreEmpresa;
            ObjAcercaDe.lblTelefono.Text = dtoPrimerUso.Telefono;
            ObjAcercaDe.lblDireccion.Text = dtoPrimerUso.Direccion;
        }
    }
}
