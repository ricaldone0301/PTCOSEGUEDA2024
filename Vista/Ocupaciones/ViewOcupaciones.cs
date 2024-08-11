using PTC.Controller.Ocupacion;
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

namespace PTC.Vista.Ocupaciones
{
    public partial class ViewOcupaciones : Form
    {
        public ViewOcupaciones()
        {
            InitializeComponent();
            ControllerAdminOcupacion ObjOcupacion = new ControllerAdminOcupacion(this);
        }
    }
}
