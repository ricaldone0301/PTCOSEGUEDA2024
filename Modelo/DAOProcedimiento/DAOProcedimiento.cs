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

                    //la sentencia es una cadena de texto a la cual se le asignan ciertos parametros
                    //a los cuales posteriormente se les agrega un valor 
                    String query = "INSERT INTO Procedimientos (nombreProcedimiento, precioProcedimiento, descProcedimiento) VALUES (@nombreProcedimiento, @precioProcedimiento, @descProcedimiento)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombreProcedimiento", NombreProcedimiento);
                    cmd.Parameters.AddWithValue("@precioProcedimiento", PrecioProcedimiento);
                    cmd.Parameters.AddWithValue("@descProcedimiento", DescProcedimiento);

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
                getConnection().Close();
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
                //Utiliza sql reader para leer los resultados y los carga
                //en un dataset utilizando el metodo load
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

        public int ActualizarProcedimiento()
        {
            try
            {
                // prepara una consulta UPDATE para modificar los campos
                Command.Connection = getConnection();
                string query = "UPDATE Procedimientos SET " +
                                "nombreProcedimiento = @param2, " +
                                "precioProcedimiento = @param3, " +
                                "descProcedimiento = @param4 " +
                                "WHERE procedimientoID = @param1";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", ProcedimientoID);
                cmd.Parameters.AddWithValue("param2", NombreProcedimiento);
                cmd.Parameters.AddWithValue("param3", PrecioProcedimiento);
                cmd.Parameters.AddWithValue("param4", DescProcedimiento);

                //ejecuta la consulta con ExecuteNonQuery, que devuelve el número de filas afectadas.
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

        public int EliminarProcedimiento()
        {
            try
            {

                Command.Connection = getConnection();
                //prepara una consulta DELETE con un parámetro para identificar el registro a eliminar.
                string query = "DELETE Procedimientos WHERE procedimientoID = @param1";
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
        public DataSet BuscarProcedimiento(string valor) //El metodo tiene la variable valor asignada
        {
            try
            {
                Command.Connection = getConnection();
                //Establece una conexión a la base de datos
                //construye una consulta SELECT que busca coincidencias en varios campos
                string query = $"SELECT * FROM viewProcedimientos WHERE procedimientoID LIKE '%{valor}%' OR nombreProcedimiento LIKE '%{valor}%' OR precioProcedimiento LIKE '%{valor}%' OR descProcedimiento LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //utiliza un SqlDataAdapter para llenar un DataSet con los resultados de la consulta. 
                cmd.ExecuteReader();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewProcedimientos");
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


    }
}
