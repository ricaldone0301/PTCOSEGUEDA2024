using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                string server = "DELLNATA\\SQLEXPRESS";
                string database = "PTCDOCTORES";
                SqlConnection conexion = new SqlConnection("Server =" + server +
                                                                 "; DataBase = " + database +
                                                                 "; Integrated Security = true");
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
