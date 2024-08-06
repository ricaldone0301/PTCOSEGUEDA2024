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
            ObjAgregarProcedimiento.btnGuardar.Click += new EventHandler(NewRegister);
        }
        public ControllerAgregarProcedimientos(ViewAgregarProcedimiento Vista, int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            ObjAgregarProcedimiento = Vista;
            this.accion = accion;
            verificarAccion();
            this.procedimientoID = procedimientoID;
            ObjAgregarProcedimiento.btnActualizar.Click += new EventHandler(UpdateRegister);

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

        public void NewRegister(object sender, EventArgs e)
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


                //daoAdmin.CitaID = ObjAgendarCita.txtUsuario.Text.Trim();

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



        public void UpdateRegister(object sender, EventArgs e)
        {
            DAOProcedimiento daoUpdate = new DAOProcedimiento();
            daoUpdate.NombreProcedimiento = ObjAgregarProcedimiento.txtNombreProcedimiento.Text.ToString();
            String test = ObjAgregarProcedimiento.txtPrecio.Text.ToString().Trim();
            decimal result;
            decimal.TryParse(test, out result);
            daoUpdate.PrecioProcedimiento = result;
            daoUpdate.DescProcedimiento = ObjAgregarProcedimiento.txtDescripcion.Text.ToString();


            int valorRetornado = daoUpdate.ActualizarProcedimiento();
            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos de la cita han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos de la cita no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

    }
}
