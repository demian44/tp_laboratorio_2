using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Hilo;
using System.IO;
using Archivos;

namespace Navegador
{
    public partial class frmWebBrowser : Form
    {
        private const string ESCRIBA_AQUI = "Escriba aquí...";
        Texto<String> archivos;
        List<string> _urls;

        public frmWebBrowser()
        {
            InitializeComponent();
            this._urls = new List<string>();
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            
            this.txtUrl.SelectionStart = 0;  //This keeps the text
            this.txtUrl.SelectionLength = 0; //from being highlighted
            this.txtUrl.ForeColor = Color.Gray;
            this.txtUrl.Text = frmWebBrowser.ESCRIBA_AQUI;
            archivos = new Archivos.Texto<String>(frmHistorial.ARCHIVO_HISTORIAL);
            
        }

        #region "Escriba aquí..."

        private void txtUrl_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.IBeam; //Without this the mouse pointer shows busy
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtUrl.Text.Equals(frmWebBrowser.ESCRIBA_AQUI) == true)
            {
                this.txtUrl.Text = "";
                this.txtUrl.ForeColor = Color.Black;
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtUrl.Text.Equals(null) == true || this.txtUrl.Text.Equals("") == true)
            {
                this.txtUrl.Text = frmWebBrowser.ESCRIBA_AQUI;
                this.txtUrl.ForeColor = Color.Gray;
            }
        }

        private void txtUrl_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtUrl.SelectAll();
        }
        #endregion

        delegate void ProgresoDescargaCallback(int progreso);

        private void ProgresoDescarga(int progreso)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (statusStrip.InvokeRequired)
            {
                ProgresoDescargaCallback d = new ProgresoDescargaCallback(ProgresoDescarga);
                this.Invoke(d, new object[] { progreso });
                this.tspbProgreso.Value = progreso;
            }
            else
            {
                this.tspbProgreso.Value = progreso;
                if (progreso == 100)
                {
                    Thread threadResetProgressBar = new Thread(ResetProgress);                    
                    threadResetProgressBar.Start();
                }
            }
        }

        private void ResetProgress()
        {
            Thread.Sleep(2000);
            this.tspbProgreso.Value = 0;
        }

        delegate void FinDescargaCallback(string html);

        private void FinDescarga(string html)
        {
            if (rtxtHtmlCode.InvokeRequired)
            {
                FinDescargaCallback d = new FinDescargaCallback(FinDescarga);
                this.Invoke(d, new object[] { html });
            }
            else
            {
                if (String.Compare(html, "Error 404 - Pagina no encontrada.") == 0)
                    MessageBox.Show(html);
                else
                    rtxtHtmlCode.Text = html;
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            try
            {
                string link = txtUrl.Text;
                Uri url;
                txtUrl.Text = SetUrl(link, out url);
                Descargador descargador = new Descargador(url);


                Thread hiloDescarga = new Thread(descargador.IniciarDescarga);
                hiloDescarga.Start();


                descargador.EventProgress += ProgresoDescarga;
                descargador.EventComplet += FinDescarga;

               
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                archivos.Guardar(txtUrl.Text);
            }
        }

        private string SetUrl(string link, out Uri url)
        {
            if (!link.Contains("http:"))
                url = new Uri(link = ("http://" + link));
            else
                url = new Uri(link);
            return link;
        }

        private void mostrarTodoElHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frmHistorial = new frmHistorial();
            frmHistorial.ShowDialog();
        }
       
    }
}
