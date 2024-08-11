﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC.Modelo
{
    internal class ModelInit : dbContext
    {
        SqlCommand Command = new SqlCommand();
        public bool ValidarInicio()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM Personal";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd.HasRows;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return false;
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
    }
}
