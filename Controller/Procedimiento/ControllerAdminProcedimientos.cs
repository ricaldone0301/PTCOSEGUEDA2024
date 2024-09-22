using Microsoft.Win32;
using PTC.Modelo.DAOProcedimiento;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgregarProcedimiento;
using PTC.Vista.Doctores;
using PTC.Vista.Padecimientos;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTC.Controller.Procedimiento
{

        class ControllerAdminProcedimientos
        {
            //Se crea un objeto de la vista
            ViewProcedimiento ObjAdminProcedimiento;


            //Tenemos un Controller que usa la vista de procedimientos en la cual se obitenen
            //los botones para inicializar los diferentes eventos
            public ControllerAdminProcedimientos(ViewProcedimiento Vista)
            {
            ObjAdminProcedimiento = Vista;
            ObjAdminProcedimiento.Load += new EventHandler(Load);
            ObjAdminProcedimiento.cmsVerPaciente.Click += new EventHandler(Ver);
            ObjAdminProcedimiento.btnNuevo.Click += new EventHandler(Nuevo);
            ObjAdminProcedimiento.cmsActualizar.Click += new EventHandler(Actualizar);
            ObjAdminProcedimiento.cmsEliminar.Click += new EventHandler(Eliminar);
            ObjAdminProcedimiento.btnBuscar.Click += new EventHandler(Buscar);
            }


        //Este metodo se inicializa cada vez que se carga el formulario
        //Llama al metodo refrescar data
        public void Load(object sender, EventArgs e)
        {
            RefrescarData();
        }

        //El método RefrescarData actualiza la vista de los procedimientos en la interfaz de usuario con los datos.
        public void RefrescarData()
        {
            //Se crea una instancia de DAOProcedimiento para gestionar la obtención de datos.
            DAOProcedimiento objAdmin = new DAOProcedimiento();
            //llama al método ObtenerProcedimiento del objeto objAdmin, que devuelve un DataSet.
            DataSet ds = objAdmin.ObtenerProcedimiento();
            //El DataSet contiene la tabla Procedimientos que se asigna como fuente de datos
            ObjAdminProcedimiento.dgvProcedimientos.DataSource = ds.Tables["ViewProcedimientos"];

        }
    

        private void Nuevo(object sender, EventArgs e)
        {
            //crea una instancia del formulario ViewAgregarProcedimiento
            //pasan 1 como el parámetro de acción
            ViewAgregarProcedimiento Vista = new ViewAgregarProcedimiento(1);
            //Al ser creado tambien se crea una instancia del controlador
            Vista.ShowDialog();
            RefrescarData();
        }
        private void Buscar(object sender, EventArgs e)
        {
            //llama al método BuscarProcedimiento de ObjAdmin, pasando el texto ingresado a txtBuscar.
            //Devuelve un dataSet con los resultados de busqueda
            DAOProcedimiento ObjAdmin = new DAOProcedimiento();
            DataSet ds = ObjAdmin.BuscarProcedimiento(ObjAdminProcedimiento.txtBuscar.Text.Trim());
            //Asigna la tabla ViewProcedimientos del DataSet como la fuente de datos  del control
            //dgvProcedimientos en la vista ObjAdminProcedimiento
            ObjAdminProcedimiento.dgvProcedimientos.DataSource = ds.Tables["ViewProcedimientos"];
        }

            private void Eliminar(object sender, EventArgs e)
            {
            //obtiene el índice de la fila seleccionada (rowIndex) y la posición de la fila actual (pos) en el datagrid
            int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
                if (MessageBox.Show($"¿Esta seguro que desea eliminar este registro? Considere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                //crea una instancia de DAOProcedimiento
                DAOProcedimiento daoDel = new DAOProcedimiento();
                //establece el ProcedimientoID del objeto utilizando el valor de la celda de la primera columna de la fila seleccionada 
                daoDel.ProcedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[0, pos].Value.ToString());
                //llama al método EliminarProcedimiento para intentar eliminar el registro de la base de datos
                    int valorRetornado = daoDel.EliminarProcedimiento();
                    if (valorRetornado == 1)
                    {
                        MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarData();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        private void Ver(object sender, EventArgs e)
        {
            //obtiene el índice de la fila seleccionada (rowIndex) y la posición de la fila actual (pos) en el datagrid
            int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
            int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
            //extrae los valores de las celdas correspondientes a la fila seleccionada
            int procedimientoID;
            string nombreProcedimiento, descProcedimiento;
            decimal precioProcedimiento;

            procedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[0, pos].Value.ToString());
            nombreProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString();
            precioProcedimiento = decimal.Parse(ObjAdminProcedimiento.dgvProcedimientos[2, pos].Value.ToString());
            descProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[3, pos].Value.ToString();

            //Con estos datos, crea una instancia de ViewAgregarProcedimiento
            //Pasa el valor dos como valor de accion, junto con los datos extraidos 
            ViewAgregarProcedimiento openForm = new ViewAgregarProcedimiento(3, procedimientoID, nombreProcedimiento, precioProcedimiento, descProcedimiento);
            openForm.ShowDialog();
            RefrescarData();

        }
        private void Actualizar(object sender, EventArgs e)
            {
            //obtiene el índice de la fila seleccionada (rowIndex) y la posición de la fila actual (pos) en el datagrid
                int rowIndex = ObjAdminProcedimiento.dgvProcedimientos.CurrentCell.RowIndex;
                int pos = ObjAdminProcedimiento.dgvProcedimientos.CurrentRow.Index;
            //extrae los valores de las celdas correspondientes a la fila seleccionada
                int procedimientoID;
                string nombreProcedimiento, descProcedimiento;
                decimal precioProcedimiento;

                procedimientoID = int.Parse(ObjAdminProcedimiento.dgvProcedimientos[0,pos].Value.ToString());
                nombreProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[1, pos].Value.ToString();
                precioProcedimiento = decimal.Parse(ObjAdminProcedimiento.dgvProcedimientos[2, pos].Value.ToString());
                descProcedimiento = ObjAdminProcedimiento.dgvProcedimientos[3, pos].Value.ToString();

            //Con estos datos, crea una instancia de ViewAgregarProcedimiento
            //Pasa el valor dos como valor de accion, junto con los datos extraidos 
            ViewAgregarProcedimiento openForm = new ViewAgregarProcedimiento(2, procedimientoID, nombreProcedimiento, precioProcedimiento, descProcedimiento);
            openForm.ShowDialog();
            RefrescarData();

            }


        }
    }
