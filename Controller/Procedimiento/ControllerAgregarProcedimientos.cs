using PTC.Modelo.DAOCitas;
using PTC.Modelo.DAOProcedimiento;
using PTC.Vista.AgendarCita;
using PTC.Vista.AgregarProcedimiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PTC.Controller.Procedimiento
{
    internal class ControllerAgregarProcedimientos
    {
        ViewAgregarProcedimiento ObjAgregarProcedimiento;

        //Variables Instancia
        private int accion;
        private int procedimientoID;

        //Toma una instancia de ViewAgregarProcedimiento y un entero accion
        // Inicializa el objeto de vista y establece el valor de accion,
        public ControllerAgregarProcedimientos(ViewAgregarProcedimiento Vista, int accion)
        {
            ObjAgregarProcedimiento = Vista;
            this.accion = accion;
            // luego llama al método verificarAccion para realizar acciones basadas en el valor de accion.
            verificarAccion();
            ObjAgregarProcedimiento.btnGuardar.Click += new EventHandler(NuevoProcedimeinto);
        }

        //Incluye parametros necesarios para realizar la actutalizacion
        public ControllerAgregarProcedimientos(ViewAgregarProcedimiento Vista, int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            ObjAgregarProcedimiento = Vista;
            this.accion = accion;
            //Inicializa las acciones necesarias y llama a verificar acciom
            verificarAccion();
            this.procedimientoID = procedimientoID;
            ObjAgregarProcedimiento.btnActualizar.Click += new EventHandler(Actualizar);
            //Llama al metodo cargar valores para llenar los campos de la vista
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
                //Se crea para interatuar con la base de datos.
                DAOProcedimiento daoAdmin = new DAOProcedimiento();

                //Se les asigna valores de la vista y luego se le asigna al objeto en el dao.
                daoAdmin.NombreProcedimiento = ObjAgregarProcedimiento.txtNombreProcedimiento.Text.ToString();
                String test = ObjAgregarProcedimiento.txtPrecio.Text.ToString(
                    ).Trim();
                decimal result;
                decimal.TryParse(test, out result);
                daoAdmin.PrecioProcedimiento = result;
                daoAdmin.DescProcedimiento = ObjAgregarProcedimiento.txtDescripcion.Text.ToString();

                // Una vez llamadas las variables para llenar el procedimiento
                // Se invoca el metodo RegistrarProcedimiento del DAO para registrar el nuevo procedimiento
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
            //crea una instancia de DAOProcedimiento y asigna el procedimientoID del registro a modificar
            DAOProcedimiento daoUpdate = new DAOProcedimiento();
            daoUpdate.ProcedimientoID = procedimientoID;
            //Luego obtiene y asigna el nombre del procedimiento desde el campo de texto de la vista
            daoUpdate.NombreProcedimiento = ObjAgregarProcedimiento.txtNombreProcedimiento.Text.ToString();
            //EL precio se toma del campo y se convierte a decimal utilizando decimal.TryParse para asegurar que
            //el formato sea válido.
            String test = ObjAgregarProcedimiento.txtPrecio.Text.ToString().Trim();
            decimal result;
            decimal.TryParse(test, out result);
            daoUpdate.PrecioProcedimiento = result;
            daoUpdate.DescProcedimiento = ObjAgregarProcedimiento.txtDescripcion.Text.ToString();

            //llama al método ActualizarProcedimiento del objeto daoUpdate para actualizar los datos en la tabla.


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


        //El método se encarga de inicializar los campos de la vista ObjAgregarProcedimiento con los valores proporcionados.
        //Este se llama en el segundo Controlador.
        public void CargarValores(int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            try
            {
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

     

