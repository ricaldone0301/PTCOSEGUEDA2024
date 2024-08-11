using PTC.Controller.Paciente;
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

namespace PTC.Vista.Paciente
{
    public partial class ViewPaciente : Form
    {
        public ViewPaciente()
        {
            InitializeComponent();
            ControllerAdminPaciente ObjAdminPaciente = new ControllerAdminPaciente(this);
        }
    }
}
