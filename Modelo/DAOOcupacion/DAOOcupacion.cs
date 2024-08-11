using PTC.Modelo.DTOOcupacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTC.Modelo.DAOOcupacion
{
    class DAOOcupacion : DTOocupacion
    {
        readonly SqlCommand Command = new SqlCommand();

        public DataSet ComboBoxOcupacion()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Ocupaciones";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Ocupaciones");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al llenar el ComboBox: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }
        public int RegistrarOcupacion()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Ocupaciones (nombreOcupacion) VALUES (@nombreOcupacion)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombreOcupacion", NombreOcupacion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar ocupacion: {ex.Message}");
                return -1;
            }
            finally
            {

            }
        }

        public DataSet ObtenerOcupacion()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM ViewOcupaciones";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "ViewOcupaciones");
                reader.Close();

                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int ActualizarOcupacion()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "UPDATE Ocupaciones SET " +
                                "nombreOcupacion = @param1" +
                                " WHERE ocupacionID = @param2";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreOcupacion);
                cmd.Parameters.AddWithValue("param2", OcupacionID);
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

        public int EliminarOcupacion()
        {
            try
            {

                Command.Connection = getConnection();
                string query = "DELETE Ocupaciones WHERE ocupacionID = @param1";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", OcupacionID);
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
        public DataSet BuscarOcupacion(string valor)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewOcupaciones WHERE [nombreOcupacion] LIKE '%{valor}%' OR [ocupacionID] LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewOcupaciones");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

    } 
}

