using PTC.Modelo.DAOCitas;
using PTC.Modelo.DAOProcedimiento;
using PTC.Vista.AgendarCita;
using PTC.Vista.AgregarProcedimiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PTC.Controller.Procedimiento
{
    internal class ControllerAgregarProcedimientos
    {
        ViewAgregarProcedimiento ObjAgregarProcedimiento;

        private int accion;
        private int procedimientoID;

        public ControllerAgregarProcedimientos(ViewAgregarProcedimiento Vista, int accion)
        {
            ObjAgregarProcedimiento = Vista;
            this.accion = accion;
            verificarAccion();
            ObjAgregarProcedimiento.btnGuardar.Click += new EventHandler(NuevoProcedimeinto);
        }
        public ControllerAgregarProcedimientos(ViewAgregarProcedimiento Vista, int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            ObjAgregarProcedimiento = Vista;
            this.accion = accion;

            verificarAccion();
            this.procedimientoID = procedimientoID;
            ObjAgregarProcedimiento.btnActualizar.Click += new EventHandler(Actualizar);
            CargarValores(accion, procedimientoID, nombreProcedimiento, precioProcedimiento, descProcedimiento);

        }

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAgregarProcedimiento.btnGuardar.Enabled = true;
                ObjAgregarProcedimiento.btnActualizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAgregarProcedimiento.btnActualizar.Enabled = true;
                ObjAgregarProcedimiento.btnGuardar.Enabled = false;
            }
        }

        public void NuevoProcedimeinto(object sender, EventArgs e)
        {
            try
            {
                DAOProcedimiento daoAdmin = new DAOProcedimiento();

                daoAdmin.NombreProcedimiento = ObjAgregarProcedimiento.txtNombreProcedimiento.Text.ToString();
                String test = ObjAgregarProcedimiento.txtPrecio.Text.ToString().Trim();
                decimal result;
                decimal.TryParse(test, out result);
                daoAdmin.PrecioProcedimiento = result;
                daoAdmin.DescProcedimiento = ObjAgregarProcedimiento.txtDescripcion.Text.ToString();

                int valorRetornado = daoAdmin.RegistrarProcedimiento();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los cita ha sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los cita no pudo ser registrada.",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar Cita: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        public void Actualizar(object sender, EventArgs e)
        {
            DAOProcedimiento daoUpdate = new DAOProcedimiento();
            daoUpdate.ProcedimientoID = procedimientoID;
            daoUpdate.NombreProcedimiento = ObjAgregarProcedimiento.txtNombreProcedimiento.Text.ToString();
            String test = ObjAgregarProcedimiento.txtPrecio.Text.ToString().Trim();
            //daoUpdate.PrecioProcedimiento = decimal.Parse(ObjAgregarProcedimiento.txtPrecio.Text.ToString().Trim());
            decimal result;
            decimal.TryParse(test, out result);
            daoUpdate.PrecioProcedimiento = result;
            daoUpdate.DescProcedimiento = ObjAgregarProcedimiento.txtDescripcion.Text.ToString();


            int valorRetornado = daoUpdate.ActualizarProcedimiento();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos del procedimiento han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos de la cita no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        public void CargarValores(int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            try
            {
                //objAgregarPaciente.txtId.Text = id.ToString();
                ObjAgregarProcedimiento.txtDescripcion.Text = descProcedimiento;
                ObjAgregarProcedimiento.txtNombreProcedimiento.Text = nombreProcedimiento;
                ObjAgregarProcedimiento.txtPrecio.Text = precioProcedimiento.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

     

