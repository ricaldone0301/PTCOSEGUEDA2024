using PTC.Modelo.DTOUsuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PTC.Modelo.DTORegistro;
using System.Windows.Forms;

namespace PTC.Modelo.DAORegistro
{
    class DAORegistro : DtoRegistro
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet ComboBoxRoles()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Roles";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Roles");
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

        public DataSet ComboBoxPreguntas()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Preguntas";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Preguntas");
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
        public DataSet ComboBoxEspecialidad()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Especialidad";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Especialidad");
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

        public DataSet ComboBoxConsultorio()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Consultorio";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Consultorio");
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


        public int RegistrarUsuario()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Personal (usuarioPersonal, contraseñaPersonal, roleID, nombrePersonal, especialidadID, telefono, consultorioID, email, preguntaID, Respuesta) VALUES (@usuario, @contrasena, @roleID, @nombre, @especialidadId, @telefono, @consultorioId, @email, @pregunta, @respuesta)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@roleID", Rol);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@especialidadId", EspecialidadId);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@consultorioId", ConsultorioId);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@pregunta", PreguntaID);
                    cmd.Parameters.AddWithValue("@respuesta", Respuesta);

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
    }
}
