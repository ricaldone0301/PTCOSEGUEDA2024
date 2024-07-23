using PTC.Vista.Dashboard;
using PTC.Vista.Pacientes;
using PTC.Vista.Calendario;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgendarCita;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC.Vista.Cita;
using PTC.Vista.Login;
using PTC.Vista.Doctores;

namespace PTC.Controller.Dasboard
{
    public class ControllerDashboard
    {
        private ViewDashboard ObjDashboard;
        private Form currentForm;
    

        public ControllerDashboard(ViewDashboard View)
        {
            ObjDashboard = View;
            ObjDashboard.btnCerrarSesion.Click += new EventHandler(CerrarSesion);
            ObjDashboard.btnPacientes.Click += new EventHandler(Pacientes);
            ObjDashboard.btnCalendario.Click += new EventHandler(Calendario);
            ObjDashboard.btnCitas.Click += new EventHandler(Citas);
            ObjDashboard.btnInicio.Click += new EventHandler(Inicio);
            ObjDashboard.btnUsuarios.Click += new EventHandler(Usuarios);
        }

        private void Pacientes(object sender, EventArgs e)
        {
            AbrirFormulario<ViewPacientes>();
        }

        private void Citas(object sender, EventArgs e)
        {
            AbrirFormulario<ViewCitas>();
        }

        private void Calendario(object sender, EventArgs e)
        {
            AbrirFormulario<VistaCalendario>();
        }

        private void Inicio(object sender, EventArgs e)
        {
            //AbrirFormulario<ViewD>
            //currentForm.Close();
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            AbrirFormulario<ViewLogin>();

        }
        private void Usuarios(object sender, EventArgs e)
        {
            AbrirFormulario<ViewUsuarios>();

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            Form formulariologin;
            formulario = ObjDashboard.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            formulariologin = ObjDashboard.PanelPadre.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                if (currentForm != null)
                {
                    currentForm.Close();
                    ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                ObjDashboard.PanelContenedor.Controls.Add(formulario);
                ObjDashboard.PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }


            if (formulariologin is ViewLogin)
            {
                formulario.TopLevel = true; // Make it a top-level window
                formulario.FormBorderStyle = FormBorderStyle.Sizable; // Or your preferred style
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.Show();

            }

        }

    }


}


