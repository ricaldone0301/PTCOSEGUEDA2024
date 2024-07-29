using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Modelo.DAOAgregarPacientes
{
    class DAOAgregarPacientes : DTOAgregarPacientes
    {
        readonly SqlCommand sql = new SqlCommand();

        public int AgregarPaciente()
        {
            try
            {
                sql.Connection = getConnection();

                string query = "INSERT INTO Pacientes(nombrePaciente, edadPaciente, telefonoPaciente, fechaNac, correoPaciente, direccionPaciente, DUI, referencia, nombreEmergencia, numEmergencia, controlMedico) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11)";

                SqlCommand command = new SqlCommand(query, sql.Connection);

                command.Parameters.AddWithValue("param1", NombrePaciente);
                command.Parameters.AddWithValue("param2", EdadPaciente);
                command.Parameters.AddWithValue("param3", TelefonoPaciente);
                command.Parameters.AddWithValue("param4", FechaNac);
                command.Parameters.AddWithValue("param5", CorreoPaciente);
                command.Parameters.AddWithValue("param6", DireccionPaciente);
                command.Parameters.AddWithValue("param7", DUI1);
                command.Parameters.AddWithValue("param8", Referencia);
                command.Parameters.AddWithValue("param9", NombreEmergencia);
                command.Parameters.AddWithValue("param10", NumEmergencia);
                command.Parameters.AddWithValue("para11", ControlMedico);

                int resultado = command.ExecuteNonQuery();
                return resultado;
            }
            catch (Exception)
            {
                Regresar();
                return -1;
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        public void Regresar()
        {
            string query = "DELETE FROM Pacientes WHERE (nombrePaciente = @nombre AND edadPaciente = @edad AND telefonoPaciente = @telefono) OR (nombrePaciente = @nombre AND edadPaciente = @edad AND correoPaciente = @correo)";
            SqlCommand command = new SqlCommand(@query, sql.Connection);
            command.Parameters.AddWithValue("nombre", NombrePaciente);
            command.Parameters.AddWithValue("edad", EdadPaciente);
            command.Parameters.AddWithValue("telefono", TelefonoPaciente);
            command.Parameters.AddWithValue("correo", CorreoPaciente);
        }

        public DataSet ObtenerPacientes()
        {
            try
            {
                sql.Connection = getConnection();
                string query = "SELECT * FROM PacientesVista";
                SqlCommand command = new SqlCommand(query, sql.Connection);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "PacientesVista");
                return data;
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

        public int ActualizarPacientes()
        {
            try
            {
                sql.Connection = getConnection();

                string query = "UPDATE Pacientes SET" +
                    "nombrePaciente = @param1,"
            }
}

    }
}
