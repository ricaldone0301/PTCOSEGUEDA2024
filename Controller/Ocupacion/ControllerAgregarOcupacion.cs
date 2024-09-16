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

        //Se declaran las variables
        private int accion;
        private int ocupacionID;

        //Contructor para agregar registro
        public ControllerAgregarOcupacion(ViewAgregarOcupacion Vista, int accion)
        {
            ObjAgregarOcupacion = Vista;
            this.accion = accion;
            verificarAccion();
            ObjAgregarOcupacion.btnGuardar.Click += new EventHandler(NuevoRegistro);
        }

        //Constructor para actualizar registro
        public ControllerAgregarOcupacion(ViewAgregarOcupacion Vista, int accion, string nombreOcupacion, int ocupacionID)
        {
            ObjAgregarOcupacion = Vista;
            this.accion = accion;
            verificarAccion();
            CargarData(Vista, accion, nombreOcupacion, ocupacionID);
            this.ocupacionID = ocupacionID;
            ObjAgregarOcupacion.btnActualizar.Click += new EventHandler(ActualizarRegistro);
        }

        //Se verifica la acción y dependiendo del valor se desactivan distintos controles
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
            }
            else if (accion == 3)
            {
                ObjAgregarOcupacion.btnGuardar.Enabled = false;
                ObjAgregarOcupacion.btnActualizar.Enabled = false;
                ObjAgregarOcupacion.txtNombre.Enabled = false;
            }
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                //Se verifica que el campo esté lleno
                if (!(string.IsNullOrEmpty(ObjAgregarOcupacion.txtNombre.Text.Trim())))

                {
                    DAOOcupacion daoAdmin = new DAOOcupacion();
                    CommonClass commonClass = new CommonClass();

                    daoAdmin.NombreOcupacion = ObjAgregarOcupacion.txtNombre.Text.Trim();

                    //Se ejecuta el método del DAO
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#005: Error al registrar ocupacion." + ex.Message);
            }
        }


        public void ActualizarRegistro(object sender, EventArgs e)
        {
            //Se verifica que el campo esté lleno
            if (!(string.IsNullOrEmpty(ObjAgregarOcupacion.txtNombre.Text.Trim())))

            {
                //Se crea un objeto del DAO
                DAOOcupacion daoUpdate = new DAOOcupacion();
                daoUpdate.NombreOcupacion = ObjAgregarOcupacion.txtNombre.Text.Trim();
                daoUpdate.OcupacionID = ocupacionID;

                //Se ejecuta el método del DAO
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
        }

        public void CargarData(ViewAgregarOcupacion Vista, int accion, string nombreOcupacion, int ocupacionID)
        {
            ObjAgregarOcupacion.txtNombre.Text = nombreOcupacion;

        }
    }
}
