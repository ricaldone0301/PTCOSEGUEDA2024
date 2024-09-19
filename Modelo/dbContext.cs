using PTC.Modelo.DTOdbContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PTC.Modelo
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
                try
                {
                    SqlConnection conexion = new SqlConnection($"Server = {DtodbContext.Server}; DataBase = {DtodbContext.Database}; User Id = {DtodbContext.User}; Password = {DtodbContext.Password}");
                    conexion.Open();
                    return conexion;
                }
           
                catch (SqlException)
                {
                    return null;
                }

                //try
                //{
                //    String test = "Server=SQL8020.site4now.net;Database=db_aacf79_ptcos;User Id= db_aacf79_ptcos_admin;Password=PTCOS123;";
                //   // string server = "SQL8020.site4now.net";
                //    //string database = "db_aacf79_ptcos";
                //    SqlConnection conexion = new SqlConnection(test);
                //    conexion.Open();
                //    return conexion;
                //}
                //catch (Exception)
                //{
                //    return null;
                //}

            }

        public static SqlConnection testConnection(string server, string database, string user, string password)
        {
            try
            {
                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {user}; Password = {password}");
                conexion.Open();
                return conexion;
            }
            catch (SqlException)
            {

                return null;
            }
        }
    }
}
