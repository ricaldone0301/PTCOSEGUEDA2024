using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTC.Modelo.DTOPaciente;
using PTC.Controller.Paciente;

namespace PTC.Modelo.DAOPaciente
{
        class DAOPaciente : DtoPaciente
        {
            readonly SqlCommand sql = new SqlCommand();

            public DataSet LlenarComboOcupaciones()
            {
                try
                {
                    sql.Connection = getConnection();

                    string query = "SELECT * FROM Ocupaciones";
                    SqlCommand command = new SqlCommand(query, sql.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "Ocupaciones");
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

            public int AgregarPaciente()
            {
                try
                {
                    ControllerAgregarPaciente objcontrolador = new ControllerAgregarPaciente();
                    sql.Connection = getConnection();

                    string query = "INSERT INTO Pacientes(nombrePaciente, edadPaciente, telefonoPaciente, fechaNac, correoPaciente, ocupacionID, direccionPaciente, DUI, referencia, nombreEmergencia, numEmergencia, motivoConsulta, controlMedico, medicoCabeceraNombre, numMedicoCabecera, alergiaMedicamentos, medicamentos, operacion, tipoOperacion, recuperacionOperacion, otroPadecimiento) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15, @param16, @param17, @param18, @param19, @param20, @param21)";

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

                    if (objcontrolador.hipertensionarterial == true || objcontrolador.diabetes == true || objcontrolador.autismo == true || objcontrolador.antecedentespsiquiatricos == true || objcontrolador.vih == true || objcontrolador.cancer == true || objcontrolador.tiroides == true || objcontrolador.ronquidos == true || objcontrolador.artritis == true || objcontrolador.vph == true || objcontrolador.migraña == true || objcontrolador.hemofilia == true || objcontrolador.lupus == true || objcontrolador.parkinson == true || objcontrolador.hemorragias == true || objcontrolador.lentacicatrizacion == true || objcontrolador.gastritis == true || objcontrolador.colitis == true || objcontrolador.otro == true)
                    {
                        string query2;

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

                    return 1;
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
                        string query2;

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
