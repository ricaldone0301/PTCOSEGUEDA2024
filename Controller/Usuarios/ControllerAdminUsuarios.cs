using Microsoft.VisualBasic.ApplicationServices;
using PTC.Modelo.DAOUsuarios;
using PTC.Vista.AgregarDoctores;
using PTC.Vista.AgregarUsuario;
using PTC.Vista.Doctores;
using PTC.Vista.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Usuarios
{
    class ControllerAdminUsuarios
    {
            ViewUsuarios ObjAdminUsuario;
            public ControllerAdminUsuarios(ViewUsuarios Vista)
            {
                //Eventos que sucederan.
                ObjAdminUsuario = Vista;
                //Eventos se ejecuata mientras caraga la vista.
                ObjAdminUsuario.Load += new EventHandler(CargarData);
                //En este parte de eventos se ha dado click en botones correspondientes y se ejecutan los metodos.
                ObjAdminUsuario.btnNuevo.Click += new EventHandler(NuevoUsuario);
                ObjAdminUsuario.cmsActualizar.Click += new EventHandler(ActualizarUsuario);
                ObjAdminUsuario.cmsEliminar.Click += new EventHandler(EliminarUsuario);
                ObjAdminUsuario.cmsVerPaciente.Click += new EventHandler(VerUsuario);
                ObjAdminUsuario.btnBuscar.Click += new EventHandler(BuscarPersonas);
            }
            private void BuscarPersonas(object sender, EventArgs e)
            {
                //se crea el objeto de dao.
                DAOUsuarios ObjAdmin = new DAOUsuarios();
                //se ejecuta el metodo del dao y se envian al txtbuscar para que lo tome como valor requerido.
                DataSet ds = ObjAdmin.BuscarPersonas(ObjAdminUsuario.txtBuscar.Text.Trim());
                //se muestran las opciones que devuelve el metodo dao
                ObjAdminUsuario.dgvPersonas.DataSource = ds.Tables["VistaPersonal"];
            }
            private void EliminarUsuario(object sender, EventArgs e)
            {
                //En esta parte lo que se esta haciendo es obteniendo el indice de la fila que sea seleccionado en dgv.
                int rowIndex = ObjAdminUsuario.dgvPersonas.CurrentCell.RowIndex;
                int pos = ObjAdminUsuario.dgvPersonas.CurrentRow.Index;
                //En esta parte se  hace una pregunta de configuracion con los detalles del usuario a eliminar.
                if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //En esta parte al que el usuario confirma el eliminar registro se crea la instacncia del dao y lo elimina usan el metodo elminarusuario.
                    DAOUsuarios daoDel = new DAOUsuarios();
                    daoDel.PersonalId = int.Parse(ObjAdminUsuario.dgvPersonas[1, pos].Value.ToString());
                    int valorRetornado = daoDel.EliminarUsuario();
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


            private void VerUsuario(object sender, EventArgs e)
            {
                //nuevamente con row y pos se obtienen los datos de la fila que hemos seleccionado en el dgv
                int rowIndex = ObjAdminUsuario.dgvPersonas.CurrentCell.RowIndex;
                int pos = ObjAdminUsuario.dgvPersonas.CurrentRow.Index;
                int rolID, EspecialidadID, consultorioID, preguntaID;
                string PersonalID, Nombre, Telefono, UsuarioPersonal, contraseñaPersonal, email, respuesta, Especialidad, consultorio, pregunta, rol;

            //En esta parte se abre nuestro formulario de edicion con los datos del usuario precargados listo para modificarlos.
            Nombre = ObjAdminUsuario.dgvPersonas[0, pos].Value.ToString();
            PersonalID = ObjAdminUsuario.dgvPersonas[1, pos].Value.ToString();
            Telefono = ObjAdminUsuario.dgvPersonas[2, pos].Value.ToString();
            UsuarioPersonal = ObjAdminUsuario.dgvPersonas[3, pos].Value.ToString();
            email = ObjAdminUsuario.dgvPersonas[4, pos].Value.ToString();
            respuesta = ObjAdminUsuario.dgvPersonas[5, pos].Value.ToString();
            pregunta = ObjAdminUsuario.dgvPersonas[6, pos].Value.ToString();
            consultorio = ObjAdminUsuario.dgvPersonas[7, pos].Value.ToString();
            Especialidad = ObjAdminUsuario.dgvPersonas[8, pos].Value.ToString();
            rol = ObjAdminUsuario.dgvPersonas[9, pos].Value.ToString();
            EspecialidadID = int.Parse(ObjAdminUsuario.dgvPersonas[8, pos].Value.ToString());
            consultorioID = int.Parse(ObjAdminUsuario.dgvPersonas[7, pos].Value.ToString());
            rolID = int.Parse(ObjAdminUsuario.dgvPersonas[9, pos].Value.ToString());
            preguntaID = int.Parse(ObjAdminUsuario.dgvPersonas[6, pos].Value.ToString());
            contraseñaPersonal = ObjAdminUsuario.dgvPersonas[10, pos].Value.ToString();


            //En esta parte se actualizan los datos que hemos modificado en el dgv.

            ViewAgregarUsuario openForm = new ViewAgregarUsuario(3, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email, preguntaID, respuesta, pregunta, consultorio, Especialidad, rolID);
                openForm.ShowDialog();
                RefrescarData();
            }


            //Carga los datos en el dgv cuando la vista se carga y se llama al metodo refrescar data para actualizar los datos con el proceso que se ha hecho.
            public void CargarData(object sender, EventArgs e)
            {
                RefrescarData();
            }


            private void ActualizarUsuario(object sender, EventArgs e)
            {
                //nuevamente con row y pos se obtienen los datos de la fila que hemos seleccionado en el dgv
                int rowIndex = ObjAdminUsuario.dgvPersonas.CurrentCell.RowIndex;
                int pos = ObjAdminUsuario.dgvPersonas.CurrentRow.Index;
                int rolID, EspecialidadID, consultorioID, preguntaID;
                string PersonalID, Nombre, Telefono, UsuarioPersonal, contraseñaPersonal, email, respuesta, pregunta, consultorio, Especialidad, rol;

                //En esta parte se abre nuestro formulario de edicion con los datos del usuario precargados listo para modificarlos.
                Nombre = ObjAdminUsuario.dgvPersonas[0, pos].Value.ToString();
                PersonalID = ObjAdminUsuario.dgvPersonas[1, pos].Value.ToString();
            Telefono = ObjAdminUsuario.dgvPersonas[2, pos].Value.ToString();
            UsuarioPersonal = ObjAdminUsuario.dgvPersonas[3, pos].Value.ToString();
            email = ObjAdminUsuario.dgvPersonas[4, pos].Value.ToString();
            respuesta = ObjAdminUsuario.dgvPersonas[5, pos].Value.ToString();
            pregunta = ObjAdminUsuario.dgvPersonas[6, pos].Value.ToString();
            consultorio = ObjAdminUsuario.dgvPersonas[7, pos].Value.ToString();
            Especialidad = ObjAdminUsuario.dgvPersonas[8, pos].Value.ToString();
            rol = ObjAdminUsuario.dgvPersonas[9, pos].Value.ToString();
            EspecialidadID = int.Parse(ObjAdminUsuario.dgvPersonas[10, pos].Value.ToString());
            consultorioID = int.Parse(ObjAdminUsuario.dgvPersonas[11, pos].Value.ToString());
            rolID = int.Parse(ObjAdminUsuario.dgvPersonas[12, pos].Value.ToString());
            preguntaID = int.Parse(ObjAdminUsuario.dgvPersonas[13, pos].Value.ToString());
            contraseñaPersonal = ObjAdminUsuario.dgvPersonas[14, pos].Value.ToString();


            //En esta parte se actualizan los datos que hemos modificado en el dgv.

            ViewAgregarUsuario openForm = new ViewAgregarUsuario(2, Nombre, PersonalID, rol, EspecialidadID, Telefono, consultorioID, UsuarioPersonal, contraseñaPersonal, email, preguntaID, respuesta, pregunta, consultorio, Especialidad,rolID);
                openForm.ShowDialog();
                RefrescarData();

            }

            // Actualiza el contenido en dgv con los datos mas recientes.
            public void RefrescarData()
            {
                //LLama al metodo obtener personas de nuestro dao para que le de la informacion que se registro y poder obtener el data set con los datos agregado de usuario y los establece como fuente de datos en dgv.
                DAOUsuarios objAdmin = new DAOUsuarios();
                DataSet ds = objAdmin.ObtenerPersonas();
                ObjAdminUsuario.dgvPersonas.DataSource = ds.Tables["VistaPersonal"];
            }


            private void NuevoUsuario(object sender, EventArgs e)
            {
                //Se abre el form de agregar usuario en modo de creacion para poder agregar el usuario.
                ViewAgregarUsuario Vista = new ViewAgregarUsuario(1);
                Vista.ShowDialog();
                //Actualiza los datos en el dgv
                RefrescarData();
            }

        }
    }

