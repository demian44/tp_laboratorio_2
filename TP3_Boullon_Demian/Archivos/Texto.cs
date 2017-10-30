using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool returnAux = false;
            StreamWriter text = new StreamWriter(archivo);
            if (!object.ReferenceEquals(text, null) && !object.ReferenceEquals(datos, null))
            {
                text.Write(datos);
                returnAux = true;
            }
            else
            {
                throw new ArchivosException(new Exception());
            }
            text.Close();

            return returnAux;
        }


        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            StreamReader streamWriter;
            if (File.Exists(archivo))
            {
                streamWriter = new StreamReader(archivo);
                datos = streamWriter.ReadToEnd();
                streamWriter.Close();
                retorno = true;
            }
            else
                datos = String.Empty;

            return retorno;
        }
    }      

}
