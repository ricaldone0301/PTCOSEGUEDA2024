using Microsoft.VisualBasic.ApplicationServices;
using PTC.Modelo.DTOUsuarios;
using PTC.Modelo.DAOLogin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PTC.Controller.Common;
using System.Windows.Forms;

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

                    String query = "INSERT INTO Personal (usuarioPersonal, contraseñaPersonal, roleID, nombrePersonal, especialidadID, telefono, consultorioID, email, preguntaID, respuesta) VALUES (@usuario, @contrasena, @roleID, @nombre, @especialidadId, @telefono, @consultorioId, @email, @preguntaID, @respuesta)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@roleID", Rol);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@especialidadId", EspecialidadId);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@consultorioId", ConsultorioId);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@preguntaID", PreguntaID);
                    cmd.Parameters.AddWithValue("@respuesta", Respuesta);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRU001: {ex.Message}");
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
                string query = "SELECT * FROM VistaPersonal";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "VistaPersonal");
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
                                "email = @param8, " +
                                "preguntaID = @param9, " +
                                "Respuesta = @param10 " +
                                "WHERE personalID = @param11";
              
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", Nombre);
                cmd.Parameters.AddWithValue("param2", EspecialidadId);
                cmd.Parameters.AddWithValue("param3", Telefono);
                cmd.Parameters.AddWithValue("param4", ConsultorioId);
                cmd.Parameters.AddWithValue("param5", Usuario);
                cmd.Parameters.AddWithValue("param6", Contrasena);
                cmd.Parameters.AddWithValue("param7", Rol);
                cmd.Parameters.AddWithValue("param8", Email);
                cmd.Parameters.AddWithValue("param9", PreguntaID);
                cmd.Parameters.AddWithValue("param10", Respuesta);
                cmd.Parameters.AddWithValue("param11", PersonalId);

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
                adp.Fill(ds, "VistaPersonal");
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

        public DtoUsuarios GetUsuarioById(int id)
        {
            DtoUsuarios usuario = null;
            try
            {
                using (SqlConnection conn = getConnection())
                {
                    string query = "SELECT * FROM Personal WHERE personalID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        usuario = new DtoUsuarios
                        {
                            Nombre = reader["nombrePersonal"].ToString(),
                            Email = reader["email"].ToString(),
                            Telefono = reader["telefono"].ToString(),
                            Usuario = reader["usuarioPersonal"].ToString(),
                            EspecialidadId = Convert.ToInt32(reader["especialidadID"]),
                            ConsultorioId = Convert.ToInt32(reader["consultorioID"]),
                            Rol = Convert.ToInt32(reader["roleID"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return usuario;
        }

        //public bool EsAdministrador()
        //{
        //    try
        //    {
        //        // Se establece la conexión a la base de datos
        //        using (SqlConnection connection = getConnection())
        //        {
        //            //se crea una consulta  para verificar si existe un usuario con el rol de Administrador que coincida con el nombre de usuario y la contraseña escritos
        //            string query = "SELECT COUNT(*) FROM ViewLogin WHERE usuarioPersonal = @username AND rolPersonal = 'Administrador'";
        //            // Se crea un comando  y se le asigna la consulta junto con la conexión.
        //            SqlCommand cmd = new SqlCommand(query, connection);

        //            cmd.Parameters.AddWithValue("@username", Usuario);
        //            // Se ejecuta la consulta y se obtiene el resultado, que será el número de filas que coinciden con los criterios
        //            int count = (int)cmd.ExecuteScalar();
        //            return count > 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al verificar el rol del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}


        public bool VerificarCredenciales()
        {
            try
            {
                // Se establece la conexión a la base de datos
                Command.Connection = getConnection();
                //se crea una consulta  para verificar si existe un usuario con el rol de Administrador que coincida con el nombre de usuario y la contraseña escritos
                string query = "SELECT COUNT(*) FROM ViewLogin WHERE usuarioPersonal = @username AND contraseñaPersonal = @password AND nombreRol = 'Administrador'";
                // Se crea un comando  y se le asigna la consulta junto con la conexión.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("@username", Usuario);
                cmd.Parameters.AddWithValue("@password", Contrasena);

                // Se ejecuta la consulta y se obtiene el resultado, que será el número de filas que coinciden con los criterios

                int count = (int)cmd.ExecuteScalar();

                    return count > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                getConnection().Close();
            }
        }
        public int CambiarContra()
        {
            try
            {
                //DAo daologin = new DAOLogin();
                Command.Connection = getConnection();
                //Se crea el query de update donde
                string query = "UPDATE Personal SET contraseñaPersonal = @contra WHERE usuarioPersonal = @usuario";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se le asignan las variables a parametros 
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contra", Contrasena);
                int respuesta = cmd.ExecuteNonQuery();
                //se devuelve la respuesta
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                Command.Connection.Close();
            }
        }
    }
}


