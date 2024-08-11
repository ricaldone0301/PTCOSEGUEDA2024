using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTC.Modelo.DTOPaciente;
using PTC.Controller.Paciente;
using PTC.Vista.AgregarPaciente;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTC.Modelo.DAOPaciente
{
    class DAOPaciente : DtoPaciente
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet ComboBoxOcupacion()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT * FROM Ocupacion";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds, "Ocupacion");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }


        public int RegistrarPaciente()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConnection();

                    String query = "INSERT INTO Pacientes(nombrePaciente, edadPaciente, telefonoPaciente, fechaNac, correoPaciente, ocupacionID, direccionPaciente, DUI, referencia, nombreEmergencia, numEmergencia, motivoConsulta, controlMedico, medicoCabeceraNombre, numMedicoCabecera, alergiaMedicamentos, medicamentos, operacion, tipoOperacion, recuperacionOperacion, padecimientos) VALUES (@nombre, @edad, @telefono, @fechaNac, @correo, @ocupacionID, @direccion, @DUI, @referencia, @nombreEmergencia, @numEmergencia, @motivoConsulta, @controlMedico, @medicoCabeceranombre, @numMedicoCabecera, @alergia, @medicamentos, @operacion, @tipoOperacion, @recuperacion, @padecimientos)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("nombre", NombrePaciente);
                    cmd.Parameters.AddWithValue("edad", EdadPaciente);
                    cmd.Parameters.AddWithValue("telefono", TelefonoPaciente);
                    cmd.Parameters.AddWithValue("fechaNac", FechaNac);
                    cmd.Parameters.AddWithValue("correo", CorreoPaciente);
                    cmd.Parameters.AddWithValue("ocupacionID", OcupacionID);
                    cmd.Parameters.AddWithValue("direccion", DireccionPaciente);
                    cmd.Parameters.AddWithValue("DUI", DUI1);
                    cmd.Parameters.AddWithValue("referencia", Referencia);
                    cmd.Parameters.AddWithValue("nombreEmergencia", NombreEmergencia);
                    cmd.Parameters.AddWithValue("numEmergencia", NumEmergencia);
                    cmd.Parameters.AddWithValue("motivoConsulta", MotivoConsulta);
                    cmd.Parameters.AddWithValue("controlMedico", ControlMedico);
                    cmd.Parameters.AddWithValue("medicoCabeceranombre", MedicoCabeceraNombre);
                    cmd.Parameters.AddWithValue("numMedicoCabecera", NumMedicoCabecera);
                    cmd.Parameters.AddWithValue("alergia", AlergiaMedicamentos);
                    cmd.Parameters.AddWithValue("medicamentos", Medicamentos);
                    cmd.Parameters.AddWithValue("operacion", Operacion);
                    cmd.Parameters.AddWithValue("tipoOperacion", TipoOperacion);
                    cmd.Parameters.AddWithValue("recuperacion", RecuperacionOperacion);
                    cmd.Parameters.AddWithValue("padecimientos", Padecimientos);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RegistrarUsuario: {ex.Message}");
                return -1;
            }
            finally
            {

            }
        }

        public DataSet ObtenerPersonas()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM ViewPacientes";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "ViewPacientes");
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
                string query = "UPDATE Pacientes SET " +
                        "nombrePaciente = @param1," +
                        "edadPaciente = @param2," +
                        "telefonoPaciente = @param3," +
                        "fechaNac = @param4," +
                        "correoPaciente = @param5," +
                        "ocupacionID = @param6," +
                        "direccionPaciente = @param7," +
                        "DUI = @param8," +
                        "referencia = @param9," +
                        "nombreEmergencia = @param10," +
                        "numEmergencia = @param11," +
                        "motivoConsulta = @param12," +
                        "controlMedico = @param13," +
                        "medicoCabeceraNombre = @param14," +
                        "numMedicoCabecera = @param15," +
                        "alergiaMedicamentos = @param16," +
                        "medicamentos = @param17," +
                        "operacion = @param18," +
                        "tipoOperacion = @param19," +
                        "recuperacionOperacion = @param20," +
                        "padecimientos = @param21 " +
                        "WHERE PacienteID = @param22";


                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param1", NombrePaciente);
                cmd.Parameters.AddWithValue("param2", EdadPaciente);
                cmd.Parameters.AddWithValue("param3", TelefonoPaciente);
                cmd.Parameters.AddWithValue("param4", FechaNac);
                cmd.Parameters.AddWithValue("param5", CorreoPaciente);
                cmd.Parameters.AddWithValue("param6", OcupacionID);
                cmd.Parameters.AddWithValue("param7", DireccionPaciente);
                cmd.Parameters.AddWithValue("param8", DUI1);
                cmd.Parameters.AddWithValue("param9", Referencia);
                cmd.Parameters.AddWithValue("param10", NombreEmergencia);
                cmd.Parameters.AddWithValue("param11", NumEmergencia);
                cmd.Parameters.AddWithValue("param12", MotivoConsulta);
                cmd.Parameters.AddWithValue("param13", ControlMedico);
                cmd.Parameters.AddWithValue("param14", MedicoCabeceraNombre);
                cmd.Parameters.AddWithValue("param15", NumMedicoCabecera);
                cmd.Parameters.AddWithValue("param16", AlergiaMedicamentos);
                cmd.Parameters.AddWithValue("param17", Medicamentos);
                cmd.Parameters.AddWithValue("param18", Operacion);
                cmd.Parameters.AddWithValue("param19", TipoOperacion);
                cmd.Parameters.AddWithValue("param20", RecuperacionOperacion);
                cmd.Parameters.AddWithValue("param21", Padecimientos);
                cmd.Parameters.AddWithValue("param22", PacienteID);
                //cmd.Parameters.AddWithValue("param21", OtrosPadecimientos)
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
                string query = "DELETE Pacientes WHERE pacienteID = @param22";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("param22", PacienteID);
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
        public DataSet BuscarPersonas(string valor)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewPacientes WHERE [Nombre completo] LIKE '%{valor}%' OR [Edad] LIKE '%{valor}%' OR [Número de teléfono] LIKE '%{valor}%' OR [Fecha de nacimiento] LIKE '%{valor}%' OR [Correo electrónico] LIKE '%{valor}%' OR [Ocupación] LIKE '%{valor}%' OR [Dirección] LIKE '%{valor}%'  OR [DUI] LIKE '%{valor}%'  OR [En caso de emergencia llamar a] LIKE '%{valor}%' OR [En caso de emergencia llamar a] LIKE '%{valor}%'  OR [Número de teléfono (emergencia)] LIKE '%{valor}%' OR [Motivo de consulta] LIKE '%{valor}%' OR [Padecimientos] LIKE '%{valor}%' OR [Control médico] LIKE '%{valor}%'  OR [Médico cabecera] LIKE '%{valor}%' OR [Número de teléfono del médico cabecera] LIKE '%{valor}%' OR [Medicamentos a los que es alérgico] LIKE '%{valor}%' OR [Medicamentos que toma actualmente] LIKE '%{valor}%' OR [Ha sido operado] LIKE '%{valor}%' OR [Operaciones realizadas] LIKE '%{valor}%' OR [Recuperación de la operación] LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewPacientes");
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
           /* readonly SqlCommand sql = new SqlCommand();
            int accion;

            public DataSet LlenarComboOcupaciones()
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
                Console.WriteLine("Error: " + ex.Message);
                ds = null;
            }
            finally
            {
                getConnection().Close();
            }
            return ds;
        }

        public int AgregarPaciente(ViewAgregarPaciente objAgregarPacientes)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    
                    cmd.Connection = getConnection();
                    
                    //ControllerAgregarPaciente objcontrolador = new ControllerAgregarPaciente();

                    String query = "INSERT INTO Pacientes(nombrePaciente, edadPaciente, telefonoPaciente, fechaNac, correoPaciente, ocupacionID, direccionPaciente, DUI, referencia, nombreEmergencia, numEmergencia, motivoConsulta, controlMedico, medicoCabeceraNombre, numMedicoCabecera, alergiaMedicamentos, medicamentos, operacion, tipoOperacion, recuperacionOperacion) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15, @param16, @param17, @param18, @param19, @param20)";

                    cmd.CommandText = query;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("param1", NombrePaciente);
                    cmd.Parameters.AddWithValue("param2", EdadPaciente);
                    cmd.Parameters.AddWithValue("param3", TelefonoPaciente);
                    cmd.Parameters.AddWithValue("param4", FechaNac);
                    cmd.Parameters.AddWithValue("param5", CorreoPaciente);
                    cmd.Parameters.AddWithValue("param6", OcupacionID);
                    cmd.Parameters.AddWithValue("param7", DireccionPaciente);
                    cmd.Parameters.AddWithValue("param8", DUI1);
                    cmd.Parameters.AddWithValue("param9", Referencia);
                    cmd.Parameters.AddWithValue("param10", NombreEmergencia);
                    cmd.Parameters.AddWithValue("param11", NumEmergencia);
                    cmd.Parameters.AddWithValue("param12", MotivoConsulta);
                    cmd.Parameters.AddWithValue("param13", ControlMedico);
                    cmd.Parameters.AddWithValue("param14", MedicoCabeceraNombre);
                    cmd.Parameters.AddWithValue("param15", NumMedicoCabecera);
                    cmd.Parameters.AddWithValue("param16", AlergiaMedicamentos);
                    cmd.Parameters.AddWithValue("param17", Medicamentos);
                    cmd.Parameters.AddWithValue("param18", Operacion);
                    cmd.Parameters.AddWithValue("param19", TipoOperacion);
                    cmd.Parameters.AddWithValue("param20", RecuperacionOperacion);
                    //cmd.Parameters.AddWithValue("param21", OtrosPadecimientos);


                    int pacienteID = Convert.ToInt32(cmd.ExecuteScalar());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    var padecimientoMap = new Dictionary<CheckBox, int>
                    {
                    { objAgregarPacientes.cbHipertensionArterial, 1 },
                    { objAgregarPacientes.cbDiabetes, 2 },
                    { objAgregarPacientes.cbAutismo, 3 },
                    { objAgregarPacientes.cbAntecedentesPsiquiatricos, 4 },
                    { objAgregarPacientes.cbVIH, 5 },
                    { objAgregarPacientes.cbCancer, 6 },
                    { objAgregarPacientes.cbTiroides, 7 },
                    { objAgregarPacientes.cbRonquidos, 8 },
                    { objAgregarPacientes.cbArtritis, 9 },
                    { objAgregarPacientes.cbVPH, 10 },
                    { objAgregarPacientes.cbMigrana, 11 },
                    { objAgregarPacientes.cbHemofilia, 12 },
                    { objAgregarPacientes.cbLupus, 13 },
                    { objAgregarPacientes.cbParkinson, 14 },
                    { objAgregarPacientes.cbHemorragias, 15 },
                    { objAgregarPacientes.cbLentaCicatrizacion, 16 },
                    { objAgregarPacientes.cbGastritis, 17 },
                    { objAgregarPacientes.cbColitis, 18 },
                    { objAgregarPacientes.cbOtros, 19 }
                    };

                    
                    foreach (var entry in padecimientoMap)
                    {
                        if (entry.Key.Checked)
                        {
                            
                            cmd.CommandText = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";
                            cmd.Parameters.Clear(); 
                            cmd.Parameters.AddWithValue("@param22", PacienteID);
                            cmd.Parameters.AddWithValue("@param23", entry.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    /*
                                        String query2;

                                        if (objAgregarPacientes.cbHipertensionArterial.Checked)
                                        {
                                            cmd.CommandText = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";
                                            cmd.Parameters.Clear(); 
                                            cmd.Parameters.AddWithValue("@param22", PacienteID);
                                            cmd.Parameters.AddWithValue("@param23", 1);
                                            cmd.ExecuteNonQuery();
                                        }
                                            if (objAgregarPacientes.cbDiabetes.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 2);
                                            }
                                            if (objAgregarPacientes.cbAutismo.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 3);
                                            }
                                            if (objAgregarPacientes.cbAntecedentesPsiquiatricos.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 4);
                                            }
                                            if (objAgregarPacientes.cbVIH.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 5);
                                            }
                                            if (objAgregarPacientes.cbCancer.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 6);
                                            }
                                            if (objAgregarPacientes.cbTiroides.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 7);
                                            }
                                            if (objAgregarPacientes.cbRonquidos.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 8);
                                            }
                                            if (objAgregarPacientes.cbArtritis.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 9);
                                            }
                                            if (objAgregarPacientes.cbVPH.Checked)
                                            {


                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 10);
                                            }
                                            if (objAgregarPacientes.cbMigrana.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 11);
                                            }
                                            if (objAgregarPacientes.cbHemofilia.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 12);
                                            }
                                            if (objAgregarPacientes.cbLupus.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 13);
                                            }
                                            if (objAgregarPacientes.cbParkinson.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 14);
                                            }
                                            if (objAgregarPacientes.cbHemorragias.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 15);
                                            }
                                            if (objAgregarPacientes.cbLentaCicatrizacion.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 16);
                                            }
                                            if (objAgregarPacientes.cbGastritis.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 17);
                                            }
                                            if (objAgregarPacientes.cbColitis.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 18);
                                            }
                                            if (objAgregarPacientes.cbOtros.Checked)
                                            {

                                                query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                                                cmd.CommandText = query2;

                                                cmd.Parameters.AddWithValue("param22", PacienteID);
                                                cmd.Parameters.AddWithValue("param23", 19);


                                            }
                    

                }
                    return 1;
            }
            catch (Exception)
            {
                Regresar();
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
         }

            public void Regresar()
            {
                string query = "DELETE FROM Pacientes WHERE (nombrePaciente = @nombre AND edadPaciente = @edad AND telefonoPaciente = @telefono) OR (nombrePaciente = @nombre AND edadPaciente = @edad AND correoPaciente = @correo)" +
                    "" +
                    "DELETE FROM PadecimientosPacientes WHERE (pacienteID = @id)";

                SqlCommand command = new SqlCommand(@query, sql.Connection);
                command.Parameters.AddWithValue("nombre", NombrePaciente);
                command.Parameters.AddWithValue("edad", EdadPaciente);
                command.Parameters.AddWithValue("telefono", TelefonoPaciente);
                command.Parameters.AddWithValue("correo", CorreoPaciente);
                command.Parameters.AddWithValue("id", PacienteID);
            }

        public DataSet ObtenerPacientes()
        {
            try
            {
                sql.Connection = getConnection();
                string query = "SELECT * FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, sql.Connection);

                SqlDataReader reader = cmd.ExecuteReader();

                DataSet ds = new DataSet();

                ds.Load(reader, LoadOption.OverwriteChanges, "Pacientes");
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

        public int ActualizarPacientes()
            {
                try
                {
                    ControllerAgregarPaciente objcontrolador = new  ControllerAgregarPaciente();

                    sql.Connection = getConnection();

                    string query = "UPDATE Pacientes SET" +
                        "nombrePaciente = @param1," +
                        "edadPaciente = @param2," +
                        "telefonoPaciente = @param3," +
                        "fechaNac = @param4," +
                        "correoPaciente = @param5," +
                        "ocupacionID = @param6," +
                        "direccionPaciente = @param7," +
                        "DUI = @param8," +
                        "referencia = @param9," +
                        "nombreEmergencia = @param10," +
                        "numEmergencia = @param11," +
                        "motivoConsulta = @param12," +
                        "controlMedico = @param13," +
                        "medicoCabeceraNombre = @param14," +
                        "numMedicoCabecera = @param15," +
                        "alergiaMedicamentos = @param16," +
                        "medicamentos = @param17," +
                        "operacion = @param18," +
                        "tipoOperacion = @param19," +
                        "recuperacionOperacion = @param20" +
                        "otroPadecimiento = @param21" +
                        "WHERE PacienteID = @param22" +
                        "" +
                        "DELETE FROM PadecimientosPacientes WHERE PacienteID = @param22";

                    SqlCommand command = new SqlCommand(query, sql.Connection);

                    command.Parameters.AddWithValue("param1", NombrePaciente);
                    command.Parameters.AddWithValue("param2", EdadPaciente);
                    command.Parameters.AddWithValue("param3", TelefonoPaciente);
                    command.Parameters.AddWithValue("param4", FechaNac);
                    command.Parameters.AddWithValue("param5", CorreoPaciente);
                    command.Parameters.AddWithValue("param6", OcupacionID);
                    command.Parameters.AddWithValue("param7", DireccionPaciente);
                    command.Parameters.AddWithValue("param8", DUI1);
                    command.Parameters.AddWithValue("param9", Referencia);
                    command.Parameters.AddWithValue("param10", NombreEmergencia);
                    command.Parameters.AddWithValue("param11", NumEmergencia);
                    command.Parameters.AddWithValue("param12", MotivoConsulta);
                    command.Parameters.AddWithValue("param13", ControlMedico);
                    command.Parameters.AddWithValue("param14", MedicoCabeceraNombre);
                    command.Parameters.AddWithValue("param15", NumMedicoCabecera);
                    command.Parameters.AddWithValue("param16", AlergiaMedicamentos);
                    command.Parameters.AddWithValue("param17", Medicamentos);
                    command.Parameters.AddWithValue("param18", Operacion);
                    command.Parameters.AddWithValue("param19", TipoOperacion);
                    command.Parameters.AddWithValue("param20", RecuperacionOperacion);
                    command.Parameters.AddWithValue("param21", OtrosPadecimientos);
                    command.Parameters.AddWithValue("param22", PacienteID);

                    if (objcontrolador.hipertensionarterial == true || objcontrolador.diabetes == true || objcontrolador.autismo == true || objcontrolador.antecedentespsiquiatricos == true || objcontrolador.vih == true || objcontrolador.cancer == true || objcontrolador.tiroides == true || objcontrolador.ronquidos == true || objcontrolador.artritis == true || objcontrolador.vph == true || objcontrolador.migraña == true || objcontrolador.hemofilia == true || objcontrolador.lupus == true || objcontrolador.parkinson == true || objcontrolador.hemorragias == true || objcontrolador.lentacicatrizacion == true || objcontrolador.gastritis == true || objcontrolador.colitis == true || objcontrolador.otro == true)
                    {
                        String query2;

                        if (objcontrolador.hipertensionarterial == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 1);
                        }
                        if (objcontrolador.diabetes == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 2);
                        }
                        if (objcontrolador.autismo == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 3);
                        }
                        if (objcontrolador.antecedentespsiquiatricos == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 4);
                        }
                        if (objcontrolador.vih == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 5);
                        }
                        if (objcontrolador.cancer == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 6);
                        }
                        if (objcontrolador.tiroides == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 7);
                        }
                        if (objcontrolador.ronquidos == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 8);
                        }
                        if (objcontrolador.artritis == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 9);
                        }
                        if (objcontrolador.vph == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 10);
                        }
                        if (objcontrolador.migraña == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 11);
                        }
                        if (objcontrolador.hemofilia == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 12);
                        }
                        if (objcontrolador.lupus == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 13);
                        }
                        if (objcontrolador.parkinson == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 14);
                        }
                        if (objcontrolador.hemorragias == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 15);
                        }
                        if (objcontrolador.lentacicatrizacion == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 16);
                        }
                        if (objcontrolador.gastritis == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 17);
                        }
                        if (objcontrolador.colitis == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 18);
                        }
                        if (objcontrolador.otro == true)
                        {
                            query2 = "INSERT INTO PadecimientosPacientes(pacienteID, padecimientoID) VALUES (@param22, @param23)";

                            SqlCommand command2 = new SqlCommand(query2, sql.Connection);

                            command2.Parameters.AddWithValue("param22", PacienteID);
                            command2.Parameters.AddWithValue("param23", 19);
                        }
                    }

                    return 2;
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

            public int EliminarPaciente()
            {
                try
                {
                    sql.Connection = getConnection();
                    string query = "DELETE FROM Pacientes WHERE pacienteID = @param1" +
                        "" +
                        "DELETE FROM Padecimientos WHERE pacienteID = @param1";
                    SqlCommand command = new SqlCommand(query, sql.Connection);
                    command.Parameters.AddWithValue("param1", PacienteID);
                    return 2;
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

            public DataSet BuscarPacientes(string valor)
            {
                try
                {
                    sql.Connection = getConnection();

                    string query = $"SELECT * FROM PacientesVista WHERE nombrePaciente LIKE '%{valor}%' OR telefonoPaciente LIKE '%{valor}%' OR correoPaciente '%{valor}%'";

                    SqlCommand command = new SqlCommand(query, sql.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "PacientesVista");
                    return dataset;
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
*/