using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTC.Modelo.DTOPaciente;
using PTC.Controller.Paciente;
using PTC.Vista.AgregarPaciente;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PTC.Modelo.DAOPaciente
{
    class DAOPaciente : DtoPaciente
    {
        //Se crea una variable llamada Command de tipo SqlCommand
        readonly SqlCommand Command = new SqlCommand();

        public int RegistrarPaciente()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //Establece conexion con la base de datos
                    cmd.Connection = getConnection();

                    //Se manda una consulta donde indica que se hace un intert a la tabla Pacientes, se llenan sus campos con las variables previamente llenas con los valores obtenidos
                    String query = "INSERT INTO Pacientes(nombrePaciente, edadPaciente, telefonoPaciente, fechaNac, correoPaciente, ocupacionID, direccionPaciente, DUI, referencia, nombreEmergencia, numEmergencia, motivoConsulta, controlMedico, medicoCabeceraNombre, numMedicoCabecera, alergiaMedicamentos, medicamentos, operacion, tipoOperacion, recuperacionOperacion, padecimientos) VALUES (@nombre, @edad, @telefono, @fechaNac, @correo, @ocupacionID, @direccion, @DUI, @referencia, @nombreEmergencia, @numEmergencia, @motivoConsulta, @controlMedico, @medicoCabeceranombre, @numMedicoCabecera, @alergia, @medicamentos, @operacion, @tipoOperacion, @recuperacion, @padecimientos)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("nombre", NombrePaciente);
                    cmd.Parameters.AddWithValue("edad", EdadPaciente);
                    cmd.Parameters.AddWithValue("telefono", TelefonoPaciente);
                    cmd.Parameters.AddWithValue("fechaNac", FechaNac);
                    cmd.Parameters.AddWithValue("correo", CorreoPaciente);
                    cmd.Parameters.AddWithValue("ocupacionID", OcupacionID);
                    cmd.Parameters.AddWithValue("direccion", DireccionPaciente);
                    cmd.Parameters.AddWithValue("DUI", DUI1);
                    cmd.Parameters.AddWithValue("referencia", Referencia);
                    cmd.Parameters.AddWithValue("nombreEmergencia", NombreEmergencia);
                    cmd.Parameters.AddWithValue("numEmergencia", NumEmergencia);
                    cmd.Parameters.AddWithValue("motivoConsulta", MotivoConsulta);
                    cmd.Parameters.AddWithValue("controlMedico", ControlMedico);
                    cmd.Parameters.AddWithValue("medicoCabeceranombre", MedicoCabeceraNombre);
                    cmd.Parameters.AddWithValue("numMedicoCabecera", NumMedicoCabecera);
                    cmd.Parameters.AddWithValue("alergia", AlergiaMedicamentos);
                    cmd.Parameters.AddWithValue("medicamentos", Medicamentos);
                    cmd.Parameters.AddWithValue("operacion", Operacion);
                    cmd.Parameters.AddWithValue("tipoOperacion", TipoOperacion);
                    cmd.Parameters.AddWithValue("recuperacion", RecuperacionOperacion);
                    cmd.Parameters.AddWithValue("padecimientos", Padecimientos);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#021: Error al crear registro" + ex.Message);
                return -1;
            }
            finally
            {

            }
        }

        public DataSet ObtenerPersonas()
        {
            try
            {
                //Establece conexion con la base de datos
                Command.Connection = getConnection();
                //Se manda una consulta donde indica que se hace un select a la vista de pacientes
                string query = "SELECT * FROM ViewPacientes";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();
                
                DataSet ds = new DataSet();
                //Lee los datos de la Vista pacientes y los retorna
                ds.Load(reader, LoadOption.OverwriteChanges, "ViewPacientes");
                reader.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#017: Error al visualizar registro." + ex.Message);
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int ActualizarUsuario()
        {
            try
            {
                //Establece conexion con la base de datos
                Command.Connection = getConnection();
                //Se manda una consulta donde indica que hace un update a la tabla de pacientes para modificar sus datos, se llenan sus campos con las variables previamente llenas con los valores obtenidos
                string query = "UPDATE Pacientes SET " +
                        "nombrePaciente = @param1," +
                        "edadPaciente = @param2," +
                        "telefonoPaciente = @param3," +
                        "fechaNac = @param4," +
                        "correoPaciente = @param5," +
                        "ocupacionID = @param6," +
                        "direccionPaciente = @param7," +
                        "DUI = @param8," +
                        "referencia = @param9," +
                        "nombreEmergencia = @param10," +
                        "numEmergencia = @param11," +
                        "motivoConsulta = @param12," +
                        "controlMedico = @param13," +
                        "medicoCabeceraNombre = @param14," +
                        "numMedicoCabecera = @param15," +
                        "alergiaMedicamentos = @param16," +
                        "medicamentos = @param17," +
                        "operacion = @param18," +
                        "tipoOperacion = @param19," +
                        "recuperacionOperacion = @param20," +
                        "padecimientos = @param21 " +
                        "WHERE PacienteID = @param22";


                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", NombrePaciente);
                cmd.Parameters.AddWithValue("param2", EdadPaciente);
                cmd.Parameters.AddWithValue("param3", TelefonoPaciente);
                cmd.Parameters.AddWithValue("param4", FechaNac);
                cmd.Parameters.AddWithValue("param5", CorreoPaciente);
                cmd.Parameters.AddWithValue("param6", OcupacionID);
                cmd.Parameters.AddWithValue("param7", DireccionPaciente);
                cmd.Parameters.AddWithValue("param8", DUI1);
                cmd.Parameters.AddWithValue("param9", Referencia);
                cmd.Parameters.AddWithValue("param10", NombreEmergencia);
                cmd.Parameters.AddWithValue("param11", NumEmergencia);
                cmd.Parameters.AddWithValue("param12", MotivoConsulta);
                cmd.Parameters.AddWithValue("param13", ControlMedico);
                cmd.Parameters.AddWithValue("param14", MedicoCabeceraNombre);
                cmd.Parameters.AddWithValue("param15", NumMedicoCabecera);
                cmd.Parameters.AddWithValue("param16", AlergiaMedicamentos);
                cmd.Parameters.AddWithValue("param17", Medicamentos);
                cmd.Parameters.AddWithValue("param18", Operacion);
                cmd.Parameters.AddWithValue("param19", TipoOperacion);
                cmd.Parameters.AddWithValue("param20", RecuperacionOperacion);
                cmd.Parameters.AddWithValue("param21", Padecimientos);
                cmd.Parameters.AddWithValue("param22", PacienteID);

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#018: Error al actualizar registro." + ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int EliminarUsuario()
        {
            try
            {
                //Establece conexion con la base de datos
                Command.Connection = getConnection();
                //Se manda una consulta donde indica que hace delete a la tabla de pacientes donde el ID del paciente sea igual al previamente obtenido
                string query = "DELETE Pacientes WHERE pacienteID = @param22";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param22", PacienteID);
                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#019: Error al eliminar registro." + ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }
        public DataSet BuscarPersonas(string valor)
        {
            try
            {
                //Establece conexion con la base de datos
                Command.Connection = getConnection();
                //Se seleccionan los datos que cumplen con los requisitos del valor
                string query = $"SELECT * FROM ViewPacientes WHERE [Nombre completo] LIKE '%{valor}%' OR [Edad] LIKE '%{valor}%' OR [Número de teléfono] LIKE '%{valor}%' OR [Fecha de nacimiento] LIKE '%{valor}%' OR [Correo electrónico] LIKE '%{valor}%' OR [Ocupación] LIKE '%{valor}%' OR [Dirección] LIKE '%{valor}%'  OR [DUI] LIKE '%{valor}%'  OR [En caso de emergencia llamar a] LIKE '%{valor}%' OR [En caso de emergencia llamar a] LIKE '%{valor}%'  OR [Número de teléfono (emergencia)] LIKE '%{valor}%' OR [Motivo de consulta] LIKE '%{valor}%' OR [Padecimientos] LIKE '%{valor}%' OR [Control médico] LIKE '%{valor}%'  OR [Médico cabecera] LIKE '%{valor}%' OR [Número de teléfono del médico cabecera] LIKE '%{valor}%' OR [Medicamentos a los que es alérgico] LIKE '%{valor}%' OR [Medicamentos que toma actualmente] LIKE '%{valor}%' OR [Ha sido operado] LIKE '%{valor}%' OR [Operaciones realizadas] LIKE '%{valor}%' OR [Recuperación de la operación] LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewPacientes");
                //Devuelve los datos obtenidos
                return ds; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#020: Error al intentar buscar registro." + ex.Message);
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }
}