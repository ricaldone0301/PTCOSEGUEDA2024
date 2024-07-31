﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PTC.Modelo.DTOProcedimiento;

namespace PTC.Modelo.DAOProcedimiento
{
    internal class DAOProcedimiento : DtoProcedimiento
    {
        readonly SqlCommand Command = new SqlCommand();
        public int RegistrarProcedimiento()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Procedimientos (nombreProcedimiento, precioProcedimiento) VALUES (@nombreProcedimiento, @precioProcedimiento";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombreProcedimiento", NombreProcedimiento);
                    cmd.Parameters.AddWithValue("@precioProcedimiento", PrecioProcedimiento);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
            finally
            {

            }
        }

        public DataSet ObtenerProcedimiento()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM Procedimientos";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "Procedimientos");
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
                string query = "UPDATE Procedimientos SET " +
                                "nombreProcedimiento = @param2, " +
                                "precioProcedimiento = @param3, " +
                                "WHERE procedimientoID = @param1";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", ProcedimientoID);
                cmd.Parameters.AddWithValue("param2", NombreProcedimiento);
                cmd.Parameters.AddWithValue("param3", PrecioProcedimiento);

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
                string query = "DELETE Personal WHERE procedimientoID = @param1";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", ProcedimientoID);
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
    }
}
