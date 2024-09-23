using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PTC.Vista.Descargas
{
    public partial class ViewDescargas : Form
    {
        public ViewDescargas()
        {
            InitializeComponent();
        }

        WebClient cliente = new WebClient();
        string ruta = null;

        private void ViewDescargas_Load(object sender, EventArgs e)
        {
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando);
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(descargando);

            // Set the URL in txturl automatically
            txturl.Text = "https://download1529.mediafire.com/n6tracestlxgYGLrBGqvFB1-YY7uheLnp1d1ywUKhTscVV-WJ6moSSJ4d8uGR8g_5MJC_5rf-sJiYiIAl3JD8WFANNGrAITzeoZoU0YIeCamXH2wGx2kMJDjj643L4c6R_VKA_N5pZh_4SJo-Oz8Gpt0czrOZUnZUEOnZ08V4iYos60/hsh8spu9ngg5fh6/Manuales.zip";
        }

        private void cargando(object sender, DownloadProgressChangedEventArgs e)
        {
            pbprogreso.Value = e.ProgressPercentage;
            lbprogreso.Text = pbprogreso.Value.ToString() + "%";
        }

        private void descargando(object sender, EventArgs e)
        {
            pbprogreso.Value = 0;
            lbprogreso.Text = "0%";

            if (MessageBox.Show("¿Desea abrir el archivo descargado?", "Archivo descargado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(ruta);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Todos los archivos|*.*";
            dialogo.FileName = txturl.Text.Substring(txturl.Text.LastIndexOf("/") + 1);
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                ruta = dialogo.FileName;
                cliente.DownloadFileAsync(new Uri(txturl.Text), dialogo.FileName);
            }
        }
    }
    }
