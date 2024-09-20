using PTC.Modelo.DTOdbContext;
using PTC.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PTC.Vista.Conexion;

namespace PTC.Controller.Servidor
{
    internal class ControllerServidor
    {

        ViewConexion ObjViewConexion;
        int origen;

        public ControllerServidor(ViewConexion View, int origen)
        {
            ObjViewConexion = View;
            verificarOrigen(origen);
            ///tabcontrol 2
             View.rdDeshabilitar.CheckedChanged += new EventHandler(rdFalseMarked);
            View.rdHabilitar.CheckedChanged += new EventHandler(rdTrueMarked);
            View.btnGuardar.Click += new EventHandler(GuardarRegistro);

        }

        public void verificarOrigen(int origen)
        {
            if (origen == 2)
            {
                //Cambiar configuración
                ObjViewConexion.txtServer.Text = DtodbContext.Server;
                ObjViewConexion.txtDatabase.Text = DtodbContext.Database;
                ObjViewConexion.txtSqlAuth.Text = DtodbContext.User;
                ObjViewConexion.txtSqlPass.Text = DtodbContext.Password;
            }
        }

        
        void rdFalseMarked(object sender, EventArgs e)
        {
            if (ObjViewConexion.rdDeshabilitar.Checked == true)
            {
                ObjViewConexion.panelAuth.Enabled = true;
            }
        }

        void rdTrueMarked(object sender, EventArgs e)
        {
            if (ObjViewConexion.rdHabilitar.Checked == true)
            {
                ObjViewConexion.panelAuth.Enabled = false;
                ObjViewConexion.txtSqlAuth.Clear();
                ObjViewConexion.txtSqlPass.Clear();
            }
        }

        void GuardarRegistro(object sender, EventArgs e)
        {
            GuardarConfiguracionXML();
        }
        public void GuardarConfiguracionXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                // Crear declaración XML
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);

                // Crear elemento raíz
                XmlElement root = doc.CreateElement("Conn");
                doc.AppendChild(root);

                // Crear los elementos hijos y agregarlos al elemento raíz
                XmlElement servidor = doc.CreateElement("Server");
                string servidorCode = CodificarBase64String(ObjViewConexion.txtServer.Text.Trim());
                servidor.InnerText = servidorCode;
                root.AppendChild(servidor);

                XmlElement Database = doc.CreateElement("Database");
                string DatabaseCode = CodificarBase64String(ObjViewConexion.txtDatabase.Text.Trim());
                Database.InnerText = DatabaseCode;
                root.AppendChild(Database);

                XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                XmlElement SqlPass = doc.CreateElement("SqlPass");

                if (ObjViewConexion.rdHabilitar.Checked)
                {
                    // Autenticación de Windows
                    SqlAuth.InnerText = string.Empty; // O simplemente no lo añadas
                    SqlPass.InnerText = string.Empty; // O simplemente no lo añadas
                }
                else
                {
                    // Autenticación SQL
                    string sqlAuthCode = CodificarBase64String(ObjViewConexion.txtSqlAuth.Text.Trim());
                    SqlAuth.InnerText = sqlAuthCode;

                    string SqlPassCode = CodificarBase64String(ObjViewConexion.txtSqlPass.Text.Trim());
                    SqlPass.InnerText = SqlPassCode;
                }

                root.AppendChild(SqlAuth);
                root.AppendChild(SqlPass);

                // Crear una instancia de dbContext
                var connectionContext = new dbContext();

                // Conectar
                SqlConnection con = connectionContext.testConnection(
                    ObjViewConexion.txtServer.Text.Trim(),
                    ObjViewConexion.txtDatabase.Text.Trim(),
                    ObjViewConexion.rdHabilitar.Checked ? null : ObjViewConexion.txtSqlAuth.Text.Trim(),
                    ObjViewConexion.rdHabilitar.Checked ? null : ObjViewConexion.txtSqlPass.Text.Trim()
                );

                if (con != null)
                {
                    // Guardar configuración en XML
                    doc.Save("config_server.xml");
                    DtodbContext.Server = ObjViewConexion.txtServer.Text.Trim();
                    DtodbContext.Database = ObjViewConexion.txtDatabase.Text.Trim();
                    DtodbContext.User = ObjViewConexion.rdHabilitar.Checked ? null : ObjViewConexion.txtSqlAuth.Text.Trim();
                    DtodbContext.Password = ObjViewConexion.rdHabilitar.Checked ? null : ObjViewConexion.txtSqlPass.Text.Trim();

                    MessageBox.Show("El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjViewConexion.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public string CodificarBase64String(string textoacifrar)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoacifrar);
                //Codificación base 64 string
                string base64String = Convert.ToBase64String(bytes);
                return base64String;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
