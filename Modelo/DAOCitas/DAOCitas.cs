using PTC.Modelo.DTOCitas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DAOCitas
{
    class DAOCitas : DtoCitas
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet ComboBoxConsultorio()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Consultorio";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Consultorio");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }

        public DataSet ComboBoxDoctor()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Personal";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Personal");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }

        public DataSet ComboBoxProcedimiento()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Procedimientos";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Procedimientos");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }

        public DataSet ComboBoxPacientes()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Pacientes";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Pacientes");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }

        public int AgendarCita()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();
                    //cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                    //int personalId = Convert.ToInt32(cmd.ExecuteScalar());

                    String query = "INSERT INTO Citas (pacienteID, personalID, consultorioID, hora, fecha, citaID, procedimientoID) VALUES (@pacienteID, @personalID, @nombreConsultorio, @nombre, @hora, @fecha, @citaID, @procedimientoID)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@pacienteID", PacienteID);
                    cmd.Parameters.AddWithValue("@personalID", PersonalID);
                    cmd.Parameters.AddWithValue("@consultorioID", ConsultorioID);
                    cmd.Parameters.AddWithValue("@hora", Hora);
                    cmd.Parameters.AddWithValue("@fecha", Fecha);
                    cmd.Parameters.AddWithValue("@citaID", CitaID);
                    cmd.Parameters.AddWithValue("@procedimientoID", ProcedimientoID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en AgendarCita: {ex.Message}");
                return -1;
            }
        }



        public int ActualizarUsuario()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "UPDATE Citas SET " +
                                "pacienteID = @param1, " +
                                "personalID = @param2, " +
                                "consultorioID = @param3," +
                                "hora = @param4," +
                                "fecha = @param5, " +
                                "procedimeintoID = @param6, " +
                                "WHERE citaID = @param7";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", PacienteID);
                cmd.Parameters.AddWithValue("param2", PersonalID);
                cmd.Parameters.AddWithValue("param3", ConsultorioID);
                cmd.Parameters.AddWithValue("param4", Hora);
                cmd.Parameters.AddWithValue("param5", Fecha);
                cmd.Parameters.AddWithValue("param6", ProcedimientoID);
                cmd.Parameters.AddWithValue("param7", CitaID);
                int respuesta = cmd.ExecuteNonQuery();

                if (respuesta == 1)
                {
                    respuesta = 1;
                }

                return respuesta;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int EliminarCita()
        {
            try
            {

                Command.Connection = getConnection();
                string query = "DELETE Citas WHERE citaID = @param7";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param7", CitaID);
                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }

    }
}
