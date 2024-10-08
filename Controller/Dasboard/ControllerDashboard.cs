﻿using PTC.Vista.Dashboard;
//using PTC.Vista.Pacientes;
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
using PTC.Vista.Padecimientos;
using PTC.Modelo.DTOLogin;
using PTC.Modelo.DTOContrasena;
using PTC.Controller.Common;
using PTC.Vista.Paciente;
using PTC.Vista.Ocupaciones;
using PTC.Vista.RecuperarContra;
using PTC.Vista.Conexion;
using PTC.Vista.Descargas;

namespace PTC.Controller.Dasboard
{
    public class ControllerDashboard
    {
        ViewDashboard ObjDashboard;
        Form currentForm;


        public ControllerDashboard(ViewDashboard View)
        {
            ObjDashboard = View;
            View.Load += new EventHandler(EventosIniciales);
            ObjDashboard.lblUsuario.Text = SessionVar.Usuario;
            ObjDashboard.lblNombre.Text = SessionVar.Rol;
            ObjDashboard.btnCerrarSesion.Click += new EventHandler(CerrarSesion);
            ObjDashboard.btnPacientes.Click += new EventHandler(Pacientes);
            ObjDashboard.btnOcupaciones.Click += new EventHandler(Ocupaciones);
            ObjDashboard.btnCitas.Click += new EventHandler(Citas);
            ObjDashboard.btnInicio.Click += new EventHandler(Inicio);
            ObjDashboard.btnUsuarios.Click += new EventHandler(Usuarios);
            ObjDashboard.btnProcedimientos.Click += new EventHandler(Procedimientos);
            ObjDashboard.lblUsuario.Click += new EventHandler(Recuperar);
            ObjDashboard.btnMaximizar.Click += new EventHandler(Maximizar);
            ObjDashboard.btnCerrar.Click += new EventHandler(Cerrar);
            ObjDashboard.btnMinimizar.Click += new EventHandler(Minimizar);
            ObjDashboard.btnServidor.Click += new EventHandler(Servidor);
            ObjDashboard.btnDescargas.Click += new EventHandler(Descargas);
        }

        private void Maximizar(object sender, EventArgs e)
        {
            if (ObjDashboard.WindowState == FormWindowState.Normal)
            {
                ObjDashboard.WindowState = FormWindowState.Maximized;
            }
            else
            {
                ObjDashboard.WindowState = FormWindowState.Normal;
            }
        }

        private void Cerrar(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que quiere cerrarla aplicacion? Esto resultará en un cierre de sesión.",
                                                    "Confirm Salida",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                if (currentForm != null)
                {
                    currentForm.Close();
                }
                Application.Exit();
            }
        }

        private void Minimizar(object sender, EventArgs e)
        {
            ObjDashboard.WindowState = FormWindowState.Minimized;
        }

        private void Pacientes(object sender, EventArgs e)
        {
            AbrirFormulario<ViewPaciente>();
        }

        private void Servidor(object sender, EventArgs e)
        {
            AbrirFormulario<ViewContraConexion>();

        }

        private void Descargas(object sender, EventArgs e)
        {
            AbrirFormulario<ViewDescargas>();

        }
        private void Procedimientos(object sender, EventArgs e)
        {
            AbrirFormulario<ViewProcedimiento>();
        }

        private void Citas(object sender, EventArgs e)
        {
            AbrirFormulario<ViewCitas>();
        }

        private void Ocupaciones(object sender, EventArgs e)
        {
            AbrirFormulario<ViewOcupaciones>();
        }

        private void Recuperar(object sender, EventArgs e)
        {
            AbrirFormulario<ViewVerContra>();
        }

        private void Inicio(object sender, EventArgs e)
        {
            AbrirFormulario<ViewDashboard>();
            currentForm.Close();
        }

        private void CerrarSesion(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Esta seguro que quiere cerrar sesion?",
                                         "Confirm Salida",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                if (currentForm != null)
                {
                    currentForm.Close();
                }
                Application.Exit();
            }
        }
        private void Usuarios(object sender, EventArgs e)
        {
            AbrirFormulario<ViewUsuarios>();

        }

        void EventosIniciales(object sender, EventArgs e)
        {
            Acceso();
        }


        public void Acceso()
        {
            switch (SessionVar.Rol)
            {
                case "Asistente":
                    ObjDashboard.btnServidor.Visible = false;
                    break;
                case "Administrador":
                    break;
                case "Secretario":
                    ObjDashboard.btnServidor.Visible = false;
                    break;
                case "Doctor":
                    ObjDashboard.btnUsuarios.Visible = false;
                    ObjDashboard.btnServidor.Visible = false;
                    break;
                default:
                    break;
            }
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
                formulario.StartPosition = FormStartPosition.CenterScreen;
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
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.Sizable;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.Show();

            }

        }

    }


}


