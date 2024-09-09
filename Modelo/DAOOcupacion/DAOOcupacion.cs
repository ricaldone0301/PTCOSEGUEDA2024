using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;
using PTC.Modelo.DTOOcupacion;
using PTC.Vista.Ocupaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PTC.Modelo.DAOOcupacion
{
    class DAOOcupacion : DTOocupacion
    {
        readonly SqlCommand Command = new SqlCommand();

        //
        public DataSet ComboBoxOcupacion()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Ocupaciones";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Ocupaciones");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#012: No se pudo cargar de forma correcta el contenido de los ComboBox" + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }


        //Este metodo inserta una tabla de ocupaciones, se crea  un objeto con sql command
        public int RegistrarOcupacion()
        {
            // se  establece la conexion con la base de datos
            //Se define una consulta SQL (`INSERT INTO Ocupaciones (nombreOcupacion) VALUES (@nombreOcupacion)`) para insertar un nuevo registro.
          //  Se agrega un parámetro `@nombreOcupacion` a la consulta, que toma el valor de la propiedad `NombreOcupacion`.
  //  Se ejecuta la consulta utilizando `ExecuteNonQuery`, que retorna el número de filas afectadas.
 //   Si ocurre una excepción, se imprime un mensaje de error y se retorna `-1`.
  //  Finalmente, se cierra la conexión a la base de datos.
  //  El método retorna el número de filas afectadas.

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Ocupaciones (nombreOcupacion) VALUES (@nombreOcupacion)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombreOcupacion", NombreOcupacion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#021: Error al crear registro" + ex.Message);
                return -1;
            }
            finally
            {

            }
        }

        public DataSet ObtenerOcupacion()
        {
            //Este método recupera los datos de la vista `ViewOcupaciones` y los devuelve en un `DataSet`.
            //Flujo del Método:
            //Se establece la conexión a la base de datos.
            //Se define una consulta SQL(`SELECT* FROM ViewOcupaciones`).
           //Se ejecuta la consulta y el resultado se almacena en un `SqlDataReader`.
           //El `DataSet` se llena con los datos del `SqlDataReader`.
            //Si ocurre una excepción, el método retorna `null`.
           //Finalmente, se cierra la conexión a la base de datos.
           //El método retorna el `DataSet` con los datos recuperados.

            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM ViewOcupaciones";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "ViewOcupaciones");
                reader.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#017: Error al visualizar registro." + ex.Message);
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

     
        public int ActualizarOcupacion()
        {
            //Este método actualiza un registro en la tabla `Ocupaciones` basado en el `ocupacionID`.
            //Se establece la conexión a la base de datos.
            //2. Se define una consulta SQL (`UPDATE Ocupaciones SET nombreOcupacion = @param1 WHERE ocupacionID = @param2`).
            // 3. Se agregan los parámetros `@param1` y `@param2` a la consulta, que toman los valores de `NombreOcupacion` y `OcupacionID`.
            //4. Se ejecuta la consulta utilizando `ExecuteNonQuery`, que retorna el número de filas afectadas.
            // 5. Si ocurre una excepción, el método retorna `-1`.
            //6. Finalmente, se cierra la conexión a la base de datos.
            //7. El método retorna el número de filas afectadas.

            try
            {
                Command.Connection = getConnection();
                string query = "UPDATE Ocupaciones SET " +
                                "nombreOcupacion = @param1" +
                                " WHERE ocupacionID = @param2";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreOcupacion);
                cmd.Parameters.AddWithValue("param2", OcupacionID);
                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#018: Error al actualizar registro." + ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int EliminarOcupacion()
        {
            //1. Se establece la conexión a la base de datos.
          //  2.Se define una consulta SQL(`DELETE Ocupaciones WHERE ocupacionID = @param1`).
    //3.Se agrega el parámetro `@param1` a la consulta, que toma el valor de `OcupacionID`.
    //4.Se ejecuta la consulta utilizando `ExecuteNonQuery`, que retorna el número de filas afectadas.
    //5.Si ocurre una excepción, el método retorna `-1`.
    //6.Finalmente, se cierra la conexión a la base de datos.
   // 7.El método retorna el número de filas afectadas.

            try
            {

                Command.Connection = getConnection();
                string query = "DELETE Ocupaciones WHERE ocupacionID = @param2";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param2", OcupacionID);
                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#019: Error al eliminar registro." + ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }
        public DataSet BuscarOcupacion(string valor)
        {
            //1. Se establece la conexión a la base de datos.
           // 2.Se define una consulta SQL con una cláusula `LIKE` para buscar coincidencias en `nombreOcupacion` o `ocupacionID`.
          //3.Se ejecuta la consulta.
            //4.Un `SqlDataAdapter` llena un `DataSet` con los resultados de la consulta.
           //Si ocurre una excepción, el método retorna `null`.
          //Finalmente, se cierra la conexión a la base de datos.
         //El método retorna el `DataSet` con los resultados de la búsqueda.

            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewOcupaciones WHERE [nombreOcupacion] LIKE '%{valor}%' OR [ocupacionID] LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewOcupaciones");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#020: Error al intentar buscar registro." + ex.Message);
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

    } 
}

