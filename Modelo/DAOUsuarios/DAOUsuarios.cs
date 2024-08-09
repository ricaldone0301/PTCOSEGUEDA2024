using Microsoft.VisualBasic.ApplicationServices;
using PTC.Modelo.DTOUsuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DAOUsuarios
{
    class DAOUsuarios : DtoUsuarios
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet ComboBoxRoles()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Roles";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Roles");
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

        public DataSet ComboBoxEspecialidad()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Especialidad";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Especialidad");
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


        public int RegistrarUsuario()
            {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Personal (usuarioPersonal, contraseñaPersonal, roleID, nombrePersonal, especialidadID, telefono, consultorioID, email) VALUES (@usuario, @contrasena, @roleID, @nombre, @especialidadId, @telefono, @consultorioId, @email)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@roleID", Rol);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@especialidadId", EspecialidadId);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@consultorioId", ConsultorioId);
                    cmd.Parameters.AddWithValue("@email", Email);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RegistrarUsuario: {ex.Message}");
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
                Command.Connection = getConnection();
                string query = "SELECT * FROM Personal";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "Personal");
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

        public int ActualizarUsuario()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "UPDATE Personal SET " +
                                "nombrePersonal = @param1, " +
                                "especialidadID = @param2, " +
                                "telefono = @param3," +
                                "consultorioID = @param4," +
                                "usuarioPersonal = @param5, " +
                                "contraseñaPersonal = @param6," +
                                "roleID = @param7," +
                                "email = @param8 " +
                                "WHERE personalID = @param9";
              
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", Nombre);
                cmd.Parameters.AddWithValue("param2", EspecialidadId);
                cmd.Parameters.AddWithValue("param3", Telefono);
                cmd.Parameters.AddWithValue("param4", ConsultorioId);
                cmd.Parameters.AddWithValue("param5", Usuario);
                cmd.Parameters.AddWithValue("param6", Contrasena);
                cmd.Parameters.AddWithValue("param7", Rol);
                cmd.Parameters.AddWithValue("param8", Email);
                cmd.Parameters.AddWithValue("param9", PersonalId);

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

        public int EliminarUsuario()
        {
            try
            {
               
                Command.Connection = getConnection();
                string query = "DELETE Personal WHERE personalID = @param2";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param2", PersonalId);
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
        public DataSet BuscarPersonas(string valor)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM viewPersonal WHERE nombrePersonal LIKE '%{valor}%' OR usuarioPersonal LIKE '%{valor}%' OR personalID LIKE '%{valor}%' OR especialidadID LIKE '%{valor}%' OR telefono LIKE '%{valor}%' OR contraseñaPersonal LIKE '%{valor}% 'OR roleID LIKE '%{valor}%' OR Email LIKE '%{valor}%'  OR consultorioID LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonal");
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

