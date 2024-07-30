using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo
{
    internal class dbPacientes
    {
        public static SqlConnection getConnection()
        {
            try
            {
                string server = "LAPTOP-GBM8P6V7\\SQLEXPRESS";
                string database = "Dental_Osegueda";
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
