using PTC.Modelo.DTOPreguntaContra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DAOPreguntaContra
{
    internal class DAOPreguntaContra : DtoPreguntaContra
    {
        readonly SqlCommand Command = new SqlCommand();
        public int ActualizarContra()
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();


                    String query = "UPDATE Personal SET contraseñaPersonal = @contrasena WHERE Email = @email";
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@email", Email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        
    }


        public bool ValidarPreguntaRespuestaSeguridad(string email, string preguntaSeguridadIngresada, string respuestaSeguridadIngresada)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    string query = "SELECT preguntaID, Respuesta FROM Personal WHERE Email = @email";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string preguntaSeguridad = reader["preguntaID"].ToString();
                                string respuestaSeguridad = reader["Respuesta"].ToString();

                            if (preguntaSeguridad == preguntaSeguridadIngresada && respuestaSeguridad == respuestaSeguridadIngresada)
                            {
                                return true;
                            }
                        }

                        return false;
                    }


                }
                    
                
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al validar pregunta y respuesta de seguridad: {ex.Message}");
            }
            finally
            {
                getConnection().Close();
            }
            return false;
        
    }

            public DataSet ComboBoxPreguntas()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Preguntas";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Preguntas");
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
    }
}