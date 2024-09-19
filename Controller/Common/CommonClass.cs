using PTC.Modelo.DTOdbContext;
using PTC.Vista.Conexion;
using PTC.Vista.Login;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PTC.Controller.Common
{
    internal class CommonClass
    {
        public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void LeerXML()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "config_server.xml");
            if (File.Exists(path))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNode root = doc.DocumentElement;
                XmlNode servernode = root.SelectSingleNode("Server/text()");
                XmlNode databaseNode = root.SelectSingleNode("Database/text()");
                XmlNode sqlAuthNode = root.SelectSingleNode("SqlAuth/text()");
                XmlNode sqlPassNode = root.SelectSingleNode("SqlPass/text()");

                string serverCode = servernode.Value;
                string databaseCode = databaseNode.Value;
                string userCode = sqlAuthNode.Value;
                string passwordCode = sqlPassNode.Value;

                DtodbContext.Server = DescifrarCadena(serverCode);
                DtodbContext.Database = DescifrarCadena(databaseCode);
                DtodbContext.User = DescifrarCadena(userCode);
                DtodbContext.Password = DescifrarCadena(passwordCode);
                //MessageBox.Show($"{DTOdbContext.Server}, {DTOdbContext.Database}, {DTOdbContext.User}, {DTOdbContext.Password}");
            }
            else
            {
                //Crear archivo
                ViewConexion Form = new ViewConexion(1);
                Form.ShowDialog();
                ViewLogin FormLog = new ViewLogin();
                FormLog.Show();
            }
        }

        public string DescifrarCadena(string cadenaCode)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(cadenaCode);
                // Convertir los bytes a una cadena
                string decodedString = Encoding.UTF8.GetString(decodedBytes);
                return decodedString.ToString();
            }
            catch (Exception ex)
            {
                return $"Error al descifrar: {ex.Message}";
            }
        }
    }
}
