using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /// <summary>
    /// Clase que permite leer y guardar archivos de texto mediante un objeto
    /// definido al memento de instanciar esta clase.
    /// </summary>
    public class Texto : IArchivo<string>
    {
        #region Methods
        /// <summary>
        /// Permite guardar un string en un archivo txt.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Permite traer informacion de un archivo de texto plano dentro
        /// de un string.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
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
        #endregion
    }

}
