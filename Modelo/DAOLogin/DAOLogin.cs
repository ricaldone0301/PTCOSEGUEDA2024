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

namespace PTC.Modelo.DAOLogin
{
    public class DAOLogin : DtoLogin
    {
        //internal string usuarioPersonal;
        //internal string contraseñaPersonal;
        SqlCommand Command = new SqlCommand();
        public int Login()
        {
            try
            {
                Command.Connection = getConnection();
                Command.CommandText = "sp_Login";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@username", Usuario);
                Command.Parameters.AddWithValue("@password", Contraseña);
                return Command.ExecuteScalar().ToString() == Usuario ? 1 : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally { getConnection().Close(); }
        }
    }
 }

