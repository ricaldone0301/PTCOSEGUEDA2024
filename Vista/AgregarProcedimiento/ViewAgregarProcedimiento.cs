using PTC.Controller.Cita;
using PTC.Controller.Procedimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Vista.AgregarProcedimiento
{
    public partial class ViewAgregarProcedimiento : Form
    {
        public ViewAgregarProcedimiento(int accion)
        {
            InitializeComponent();
            ControllerAgregarProcedimientos ObjAgregarProcedimientos = new ControllerAgregarProcedimientos(this, accion);
        }

        public ViewAgregarProcedimiento(int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            ControllerAgregarProcedimientos ObjAgregarProcedimiento = new ControllerAgregarProcedimientos(this, accion, procedimientoID, nombreProcedimiento, precioProcedimiento, descProcedimiento);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
