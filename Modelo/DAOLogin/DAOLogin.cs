using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using PTC.Modelo.DTOLogin;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using PTC.Controller.Common;

namespace PTC.Modelo.DAOLogin
{
    public class DAOLogin : DtoLogin
    {

        SqlCommand Command = new SqlCommand();
        public bool Login()
        {
            try
            {

                Command.Connection = getConnection();
                string query = "SELECT * FROM ViewLogin WHERE usuarioPersonal = @username AND contraseñaPersonal = @password";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("username", Usuario);
                cmd.Parameters.AddWithValue("password", Contrasena);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    SessionVar.Usuario = rd.GetString(1);
                    SessionVar.Contrasena = rd.GetString(2);
                    SessionVar.Rol = rd.GetString(3);
                    SessionVar.Nombre = rd.GetString(0);
                    //
                    SessionVar.NombreConsul = rd.GetString(6);
                    SessionVar.Telefono = rd.GetString(7);
                    SessionVar.NombreEsp = rd.GetString(4);
                    SessionVar.Email = rd.GetString(5);
                }
                return rd.HasRows;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#014: El metodo para validar el login fue interrumpido." + ex.Message);
                return false;
            }
            finally 
            {
                getConnection().Close();
            }
        }

        public int ValidarPrimerUsoSistema()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM ViewLogin";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int totalUsuarios = (int)cmd.ExecuteScalar();
                return totalUsuarios;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error OS#015: No se pudo validar el primer uso del sistema" + sqlex.Message);
                return -1;
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

        public bool PrimerLogin(string usuario)
        {
            try
            {
                // Create and open a new connection
                using (var connection = getConnection())
                {
                    // Define the query to get the status
                    string query = "SELECT status FROM Personal WHERE usuarioPersonal = @Usuario";

                    // Create a SqlCommand object and associate it with the connection
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        // Add the parameter to the command
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        // Execute the query and get the status value
                        var result = cmd.ExecuteScalar();

                        // Check if the result is null
                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("No se encontró el usuario en la base de datos.");
                            return false; // Indicate that the user was not found or status is null
                        }

                        // Convert the result to a boolean
                        bool status = Convert.ToBoolean(result);
                        return status; // Return the status (true or false)
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error OS#015: No se pudo validar el primer uso del sistema: " + sqlex.Message);
                return false; // Indicate SQL error
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Indicate general error
            }
        }

        public int CambiarContra()
        {
            try
            {
                // Se crea la conexión
                Command.Connection = getConnection();

                // Se crea el query de update donde además de actualizar la contraseña, 
                // también se actualiza el campo status (tipo bit).
                string query = "UPDATE Personal SET contraseñaPersonal = @contra, status = @status WHERE usuarioPersonal = @usuario";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                // Se le asignan las variables a los parámetros 
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contra", Contrasena);

                // Se asume que quieres establecer un valor específico para status.
                // Aquí se establece el valor de status como true (1) para indicar que el usuario está activo.
                // Cambia el valor según tus necesidades (true o false).
                cmd.Parameters.AddWithValue("@status", true);

                // Se ejecuta el comando
                int respuesta = cmd.ExecuteNonQuery();

                // Se devuelve la respuesta
                return respuesta;
            }
            catch (Exception ex)
            {
                // Se muestra el mensaje de error
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                // Se cierra la conexión
                Command.Connection.Close();
            }
        }

                // Se crea el query de update donde además de actualizar la contraseña, 
                // también se actualiza el campo status (tipo bit).
                string query = "SELECT Status FROM Personal WHERE contraseñaPersonal = @contra AND usuarioPersonal = @usuario";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                // Se le asignan las variables a los parámetros 
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contra", Contrasena);

                // Se ejecuta el comando
                int respuesta = cmd.ExecuteNonQuery();

                // Se devuelve la respuesta
                return respuesta;
            }
            catch (Exception ex)
            {
                // Se muestra el mensaje de error
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                // Se cierra la conexión
                Command.Connection.Close();
            }
        }
        public int ValidarPrimerUsoSistema()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM ViewLogin";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int totalUsuarios = (int)cmd.ExecuteScalar();
                return totalUsuarios;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error OS#015: No se pudo validar el primer uso del sistema" + sqlex.Message);
                return -1;
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

        public bool PrimerLogin(string usuario)
        {
            try
            {
                // Create and open a new connection
                using (var connection = getConnection())
                {
                    // Define the query to get the status
                    string query = "SELECT status FROM Personal WHERE usuarioPersonal = @Usuario";

                    // Create a SqlCommand object and associate it with the connection
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        // Add the parameter to the command
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        // Execute the query and get the status value
                        var result = cmd.ExecuteScalar();

                        // Check if the result is null
                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("No se encontró el usuario en la base de datos.");
                            return false; // Indicate that the user was not found or status is null
                        }

                        // Convert the result to a boolean
                        bool status = Convert.ToBoolean(result);
                        return status; // Return the status (true or false)
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error OS#015: No se pudo validar el primer uso del sistema: " + sqlex.Message);
                return false; // Indicate SQL error
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Indicate general error
            }
        }

        public int CambiarContra()
        {
            try
            {
                // Se crea la conexión
                Command.Connection = getConnection();

                // Se crea el query de update donde además de actualizar la contraseña, 
                // también se actualiza el campo status (tipo bit).
                string query = "UPDATE Personal SET contraseñaPersonal = @contra, status = @status WHERE usuarioPersonal = @usuario";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                // Se le asignan las variables a los parámetros 
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contra", Contrasena);

                // Se asume que quieres establecer un valor específico para status.
                // Aquí se establece el valor de status como true (1) para indicar que el usuario está activo.
                // Cambia el valor según tus necesidades (true o false).
                cmd.Parameters.AddWithValue("@status", true);

                // Se ejecuta el comando
                int respuesta = cmd.ExecuteNonQuery();

                // Se devuelve la respuesta
                return respuesta;
            }
            catch (Exception ex)
            {
                // Se muestra el mensaje de error
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                // Se cierra la conexión
                Command.Connection.Close();
            }
        }
    }


}


