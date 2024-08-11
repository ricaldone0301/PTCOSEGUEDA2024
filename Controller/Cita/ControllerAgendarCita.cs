using PTC.Modelo.DAOCitas;
using PTC.Modelo.DAOOcupacion;
using PTC.Vista.AgendarCita;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Controller.Cita
{
    internal class ControllerAgendarCita
    {
        ViewAgendarcita ObjAgendarCita;

        private int accion;
        private string consultorio;
        private string personal;
        private string paciente;
        private string procedimiento;
        private int citaID;

        public ControllerAgendarCita(ViewAgendarcita Vista, int accion)
        {
            ObjAgendarCita = Vista;
            this.accion = accion;
            
            verificarAccion();
            ObjAgendarCita.Load += new EventHandler(CargoInicial);
            ObjAgendarCita.btnGuardar.Click += new EventHandler(NuevaCita);
        }
        public ControllerAgendarCita(ViewAgendarcita Vista, int accion, int citaID, int pacienteID, string personalID, int consultorioID, string hora, DateTime fecha, int procedimientoID)
        {
            ObjAgendarCita = Vista;
            this.accion = accion;
            ObjAgendarCita.Load += new EventHandler(CargoInicial);
            verificarAccion();
            ChargeValues(Vista, accion, pacienteID, personalID, consultorioID, hora, fecha, procedimientoID);
            this.citaID = citaID;
            ObjAgendarCita.btnActualizar.Click += new EventHandler(ActualizarRegistro);
        }

        public void CargoInicial(object sender, EventArgs e)
        {
            try
            {
                DAOCitas objAdmin = new DAOCitas();

                DataSet dsConsultorio = objAdmin.ComboBoxConsultorio();
                if (dsConsultorio != null && dsConsultorio.Tables.Contains("Consultorio"))
                {
                    DataTable dtConsultorio = dsConsultorio.Tables["Consultorio"];
                    ObjAgendarCita.cbConsultorio.DataSource = dtConsultorio;
                    ObjAgendarCita.cbConsultorio.ValueMember = "ConsultorioID";
                    ObjAgendarCita.cbConsultorio.DisplayMember = "nombreConsultorio";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtConsultorio.Select($"nombreConsultorio = '{consultorio}'");
                        if (rows.Length > 0)
                        {
                            ObjAgendarCita.cbConsultorio.Text = rows[0]["nombreConsultorio"].ToString();
                        }
                    }

                }
                DataSet dsProcedimientos = objAdmin.ComboBoxProcedimiento();
                if (dsProcedimientos != null && dsProcedimientos.Tables.Contains("Procedimientos"))
                {
                    DataTable dtProcedimientos = dsProcedimientos.Tables["Procedimientos"];
                    ObjAgendarCita.cbProcedimiento.DataSource = dtProcedimientos;
                    ObjAgendarCita.cbProcedimiento.ValueMember = "procedimientoID";
                    ObjAgendarCita.cbProcedimiento.DisplayMember = "nombreProcedimiento";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtProcedimientos.Select($"nombreProcedimiento = '{procedimiento}'");
                        if (rows.Length > 0)
                        {
                            ObjAgendarCita.cbProcedimiento.Text = rows[0]["nombreProcedimiento"].ToString();
                        }
                    }
                }


                    DataSet dsPersonal = objAdmin.ComboBoxDoctor();
                     if (dsPersonal != null && dsPersonal.Tables.Contains("Personal"))
                     {
                         DataTable dtPersonal = dsPersonal.Tables["Personal"];
                         DataView dvPersonal = new DataView(dtPersonal);
                         dvPersonal.RowFilter = "roleID = 1";
                         ObjAgendarCita.cbDoctor.DataSource = dvPersonal;
                         ObjAgendarCita.cbDoctor.ValueMember = "personalID";
                         ObjAgendarCita.cbDoctor.DisplayMember = "nombrePersonal";


                         if (accion == 1)
                         {
                             DataRow[] rows = dtPersonal.Select($"nombrePersonal = '{personal}'");
                             if (rows.Length > 0)
                             {
                                 ObjAgendarCita.cbDoctor.Text = rows[0]["nombrePersonal"].ToString();
                             }
                         }

                     }

                    DataSet dsPacientes = objAdmin.ComboBoxPacientes();
                    if (dsPacientes != null && dsPacientes.Tables.Contains("Pacientes"))
                    {
                        DataTable dtPacientes = dsPacientes.Tables["Pacientes"];
                        ObjAgendarCita.cbPaciente.DataSource = dtPacientes;
                        ObjAgendarCita.cbPaciente.ValueMember = "pacienteID";
                        ObjAgendarCita.cbPaciente.DisplayMember = "nombrePaciente";

                    if (accion == 1)
                    {
                        DataRow[] rows = dtPacientes.Select($"nombrePaciente = '{paciente}'");
                        if (rows.Length > 0)
                        {
                            ObjAgendarCita.cbDoctor.Text = rows[0]["nombrePacientel"].ToString();
                        }
                    }


                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAgendarCita.btnGuardar.Enabled = true;
                ObjAgendarCita.btnActualizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAgendarCita.btnGuardar.Enabled = false;
                ObjAgendarCita.btnActualizar.Enabled = true;
                //ObjAgendarCita.txtUsuario.Enabled = false;
            }
        }

        public void NuevaCita(object sender, EventArgs e)
        {
            try
            {
                DAOCitas daoAdmin = new DAOCitas();

                daoAdmin.PacienteID = int.Parse(ObjAgendarCita.cbPaciente.SelectedValue.ToString());
                daoAdmin.PersonalID = (int.Parse(ObjAgendarCita.cbDoctor.SelectedValue.ToString())).ToString();
                daoAdmin.ConsultorioID = int.Parse(ObjAgendarCita.cbConsultorio.SelectedValue.ToString());
                daoAdmin.Hora = ObjAgendarCita.txtHora.Text.ToString();
                daoAdmin.Fecha = ObjAgendarCita.Fecha.Value.Date;
                daoAdmin.ProcedimientoID = int.Parse(ObjAgendarCita.cbProcedimiento.SelectedValue.ToString());


                //daoAdmin.CitaID = ObjAgendarCita.txtUsuario.Text.Trim();

                int valorRetornado = daoAdmin.AgendarCita();

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
                MessageBox.Show($"ERRC002: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        public void ActualizarRegistro(object sender, EventArgs e)
        {
            DAOCitas daoUpdate = new DAOCitas();
            daoUpdate.PacienteID = int.Parse(ObjAgendarCita.cbPaciente.SelectedValue.ToString());
            daoUpdate.PersonalID = ObjAgendarCita.cbDoctor.SelectedValue.ToString();
            daoUpdate.ConsultorioID = int.Parse(ObjAgendarCita.cbConsultorio.SelectedValue.ToString());
            daoUpdate.CitaID = citaID;
            daoUpdate.Hora = ObjAgendarCita.txtHora.Text.ToString();
            daoUpdate.Fecha = ObjAgendarCita.Fecha.Value;
            daoUpdate.ProcedimientoID = int.Parse(ObjAgendarCita.cbProcedimiento.SelectedValue.ToString());
            //daoUpdate.Hora = DateTime.Parse(ObjAgendarCita.Tiempo.ToString()).ToString();


            int valorRetornado = daoUpdate.ActualizarUsuario();
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

        /*public void UpdateRegister(object sender, EventArgs e)
        {
            DAOCitas daoUpdate = new DAOCitas();
            daoUpdate.PacienteID = int.Parse(ObjAgendarCita.cbPaciente.SelectedValue.ToString());
            daoUpdate.PersonalID = ObjAgendarCita.cbDoctor.SelectedValue.ToString();
            daoUpdate.ConsultorioID = int.Parse(ObjAgendarCita.cbConsultorio.SelectedValue.ToString());
            //daoUpdate.CitaID = int.Parse(ObjAgendarCita.Cita.SelectedValue.ToString());

            //string dummy2 = ObjAgendarCita.Tiempo.ToString();

            // daoUpdate.Fecha = DateTime.ParseExact(ObjAgendarCita.Fecha.ToString(), "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);


            //daoUpdate.Hora = DateTime.Parse(ObjAgendarCita.Tiempo.ToString());
            //String fechaTest = ObjAgendarCita.Fecha.ToString();
            //daoUpdate.Fecha = DateTime.ParseExact(ObjAgendarCita.Fecha.Value.ToString(), "M/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            daoUpdate.Fecha = ObjAgendarCita.Fecha.Value;
            daoUpdate.Hora = daoUpdate.Fecha.ToString("HH:mm:ss.fffffff tt");
            //daoUpdate.Hora = DateTime.ParseExact(ObjAgendarCita.Tiempo.ToString(), "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            //daoUpdate.Fecha = DateTime.Parse(ObjAgendarCita.Fecha.ToString());

            // daoUpdate.Fecha = DateTime.ParseExact(ObjAgendarCita.Fecha.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            daoUpdate.ProcedimientoID = int.Parse(ObjAgendarCita.cbProcedimiento.SelectedValue.ToString());

            int valorRetornado = daoUpdate.ActualizarUsuario();
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
        }*/
        public void ChargeValues(ViewAgendarcita Vista, int accion, int pacienteID, string personalID, int consultorioID, string hora, DateTime fecha, int procedimientoID)
        {
            ObjAgendarCita.cbPaciente.SelectedValue = pacienteID;
            ObjAgendarCita.cbDoctor.SelectedValue = personalID;
            ObjAgendarCita.cbConsultorio.SelectedValue = consultorioID;
            ObjAgendarCita.txtHora.Text = hora;
            ObjAgendarCita.Fecha.Value = DateTime.Now;
            ObjAgendarCita.cbProcedimiento.SelectedValue = procedimientoID;
        }
    }
}

