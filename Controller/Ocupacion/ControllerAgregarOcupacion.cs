using PTC.Controller.Common;
using PTC.Modelo.DAOOcupacion;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgendarOcupaciones;
using PTC.Vista.AgregarDoctores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Ocupacion
{
    class ControllerAgregarOcupacion
    {
        ViewAgregarOcupacion ObjAgregarOcupacion;

        private int accion;
        private string rol;
        private int ocupacionID;

        public ControllerAgregarOcupacion(ViewAgregarOcupacion Vista, int accion)
        {
            ObjAgregarOcupacion = Vista;
            this.accion = accion;
            verificarAccion();
            //ObjAgregarOcupacion.Load += new EventHandler(CargarData);
            ObjAgregarOcupacion.btnGuardar.Click += new EventHandler(NuevoRegistro);
        }
        public ControllerAgregarOcupacion(ViewAgregarOcupacion Vista, int accion, string nombreOcupacion, int ocupacionID)
        {
            ObjAgregarOcupacion = Vista;
            this.accion = accion;
            //ObjAgregarOcupacion.Load += new EventHandler(CargarData);
            verificarAccion();
            CargarData(Vista, accion, nombreOcupacion, ocupacionID);
            this.ocupacionID = ocupacionID;
            ObjAgregarOcupacion.btnActualizar.Click += new EventHandler(ActualizarRegistro);
        }

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAgregarOcupacion.btnGuardar.Enabled = true;
                ObjAgregarOcupacion.btnActualizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAgregarOcupacion.btnGuardar.Enabled = false;
                ObjAgregarOcupacion.btnActualizar.Enabled = true;
                //ObjAgregarOcupacion.txtUsuario.Enabled = false;
            }
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                DAOOcupacion daoAdmin = new DAOOcupacion();
                CommonClass commonClass = new CommonClass();

                daoAdmin.NombreOcupacion = ObjAgregarOcupacion.txtNombre.Text.Trim();
                //daoAdmin.OcupacionID = (int)ObjAgregarOcupacion.cbOcupacion.SelectedValue;

                int valorRetornado = daoAdmin.RegistrarOcupacion();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        public void ActualizarRegistro(object sender, EventArgs e)
        {
            DAOOcupacion daoUpdate = new DAOOcupacion();
            daoUpdate.NombreOcupacion = ObjAgregarOcupacion.txtNombre.Text.Trim();
            daoUpdate.OcupacionID = ocupacionID;
            //daoUpdate.OcupacionID = (int)ObjAgregarOcupacion.cbOcupacion.SelectedValue;


            int valorRetornado = daoUpdate.ActualizarOcupacion();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void CargarData(ViewAgregarOcupacion Vista, int accion, string nombreOcupacion, int ocupacionID)
        {
            ObjAgregarOcupacion.txtNombre.Text = nombreOcupacion;
            //ObjAgregarOcupacion.txtEmail.Text = ocupacionID;

        }
    }
}
