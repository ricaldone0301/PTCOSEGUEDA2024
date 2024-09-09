using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PTC.Modelo.DTOPrimerUso;
using System.Windows.Forms;

namespace PTC.Modelo.DAOPrimerUso
{
    internal class DAOPrimerUso : DtoPrimerUso
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet ComboBoxRoles()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM ViewPrimer";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "ViewPrimer");
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


        public int RegistrarUsuario()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Personal (usuarioPersonal, contraseñaPersonal, roleID, nombrePersonal, especialidadID, telefono, consultorioID, email) VALUES (@usuario, @contrasena, @roleID, @nombre, @especialidadId, @telefono, @consultorioId, @email)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@roleID", Rol);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@especialidadId", EspecialidadId);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@consultorioId", ConsultorioId);
                    cmd.Parameters.AddWithValue("@email", Email);

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
                Command.Connection.Close();
            }


        }

        public int RegistrarEmpresa()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Empresa (nombreEmpresa, telefonoEmpresa, direccion, emailEmpresa) VALUES (@nombre, @telefono, @direccion, @email)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@direccion", Direccion);
                    cmd.Parameters.AddWithValue("@nombre", NombreEmpresa);
                    cmd.Parameters.AddWithValue("@telefono", TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("@email", EmailEmpresa);

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
                getConnection().Close();
            }


        }
        public int VerificarEmpresa()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM Empresa";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int totalPersonal = (int)cmd.ExecuteScalar();
                return totalPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#023: Error al realizar el conteo de datos." + ex.Message);
                return -1;
            }
            finally
            {
                Command.Connection.Close();
            }
        }
        public int VerificarRegistro()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM Personal";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int totalPersonal = (int)cmd.ExecuteScalar();
                return totalPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#023: Error al realizar el conteo de datos." + ex.Message);
                return -1;
            }
            finally
            {
                Command.Connection.Close();
            }
        }
    }
}

