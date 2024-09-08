using PTC.Modelo.DTOContrasena;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace PTC.Modelo.DAOContrasena
{
    class DAOContrasena : DtoContrasena
    {
        readonly SqlCommand Command = new SqlCommand();
        public int ActualizarContra()
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    
                    String query = "UPDATE Personal SET contraseñaPersonal = @contrasena WHERE Email = @email";
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@contrasena", Contrasena);
                    cmd.Parameters.AddWithValue("@email", Email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error OS#013: El metodo para actualizar contraseña fue interrumpido2" + ex.Message);
                return -1;
            }
        }
    }
}
