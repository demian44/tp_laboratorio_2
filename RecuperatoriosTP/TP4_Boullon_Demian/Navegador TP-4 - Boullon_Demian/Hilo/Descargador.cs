using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        private string html;
        private Uri direccion;
                
       
        public Descargador(Uri direccion)
        {
            this.direccion = direccion;
            this.html = "";
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;
                cliente.DownloadStringAsync(this.direccion);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public delegate void ProgresoDescargaCallback(int progreso);
        public event ProgresoDescargaCallback EventProgress;
        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            EventProgress.Invoke(e.ProgressPercentage);
        }        

        public delegate void DownloadEndCallback(string html);
        public event DownloadEndCallback EventComplet;

        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                this.html = e.Result;
                EventComplet.Invoke(this.html);
            }
            catch (Exception excepction)
            {                
                EventComplet.Invoke("No se puede acceder a este sitio \nNo se encontró la dirección DNS " +
                    "del servidor de www.asdasdasdasd.");
            }
        }
        
    }
}
