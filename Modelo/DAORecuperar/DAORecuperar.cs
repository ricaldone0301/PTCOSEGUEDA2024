using PTC.Controller.Common;
using PTC.Modelo.DTORecuperar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Modelo.DAORecuperar
{
    internal class DAORecuperar : DtoRecuperar
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
                }
                if (Rol = 1)
                {
                    return true; // Login successful
                }
                if Rol = "Asistente"
                return false; // Login failed

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Ensure the connection is closed
                if (Command.Connection.State == System.Data.ConnectionState.Open)
                {
                    Command.Connection.Close();
                }
            }
        }
    }
}
   