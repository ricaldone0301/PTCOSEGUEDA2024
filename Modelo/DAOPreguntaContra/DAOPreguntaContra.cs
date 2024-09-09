using PTC.Modelo.DTOPreguntaContra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Modelo.DAOPreguntaContra
{
    internal class DAOPreguntaContra : DtoPreguntaContra
    {
        readonly SqlCommand Command = new SqlCommand();
        public int ActualizarContra()
        {
            try
            {
                //crea comando de sql y abre la coneccion
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    //Actualiza la contrasena donde el correo sea el ingresado
                    String query = "UPDATE Personal SET contraseñaPersonal = @contrasena WHERE Email = @email";
                    cmd.CommandText = query;

                    //asigna valores a los parametros
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@email", Email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    //retorna las filas afectadas
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#018: Error al actualizar registro." + ex.Message);
                return -1;
            }
        }


        public bool ValidarPreguntaRespuestaSeguridad(string email, string preguntaSeguridadIngresada, string respuestaSeguridadIngresada)
        {
            //retorna true si la pregunta y respuesta ingresadas coinciden con las almacenadas en la base de datos si no retorna falso
            try
            {
                // Abre una nueva conexión a la base de datos.
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    // Crea un nuevo comando SQl

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // Crea el query para seleccionar la pregunta y respuesta de seguridad del usuario asociado a su email
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT preguntaSeguridad, respuestaSeguridad FROM Personal WHERE Email = @email";
                        cmd.Parameters.AddWithValue("@email", email);
                        // Ejecuta el comando y obtiene un lector de datos para leer los datos
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtiene la pregunta y respuesta de seguridad almacenadas en la base de datos
                                string preguntaSeguridad = reader["preguntaSeguridad"].ToString();
                                string respuestaSeguridad = reader["respuestaSeguridad"].ToString();

                                // retorna si estan asociados
                                return preguntaSeguridad == preguntaSeguridadIngresada && respuestaSeguridad == respuestaSeguridadIngresada;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#022: Error al validar pregunta y respuesta asociada al correo." + ex.Message);
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
                MessageBox.Show("Error OS#012: No se pudo cargar de forma correcta el contenido de los ComboBox" + ex.Message);
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