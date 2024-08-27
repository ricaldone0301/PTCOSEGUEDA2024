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
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { getConnection().Close(); }
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
                MessageBox.Show(sqlex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }
 }

