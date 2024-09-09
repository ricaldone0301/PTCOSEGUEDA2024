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
                String test = "Server=SQL8020.site4now.net;Database=db_aacf79_ptcos;User Id= db_aacf79_ptcos_admin;Password=PTCOS123;";
               // string server = "SQL8020.site4now.net";
                //string database = "db_aacf79_ptcos";
                SqlConnection conexion = new SqlConnection(test);
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
