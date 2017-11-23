using Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto<String> : IArchivo<string>
    {
        private string _archivo;
        public Texto(string archivo)
        {
            this._archivo = archivo;
        }

        public bool Guardar(string datos)
        {
            bool retorno = false;
            
            StreamWriter text = File.AppendText(this._archivo);
            try
            {
                if (!object.ReferenceEquals(text, null) && datos != string.Empty && this._archivo != string.Empty)
                {
                    text.WriteLine(datos);
                    retorno = true;
                }
            }
            catch (IOException ioException)
            {
                throw new ArchivosExceptions("No pudo abrirse el archivo. " + ioException.Message);
            }
            catch (Exception exception)
            {
                throw new ArchivosExceptions("No pudo abrirse el archivo. " + exception.Message);
            }
            finally
            {
                text.Close();
            }

            return retorno;
        }

        public bool Leer(out List<string> dato)
        {
            dato = new List<string>();
            bool retorno = false;
            StreamReader streamReader = new StreamReader(_archivo);
            if (!object.ReferenceEquals(streamReader, null) && this._archivo != string.Empty)
            {
                while(!streamReader.EndOfStream)
                    dato.Add(streamReader.ReadLine());

                streamReader.Close();
                retorno = true;
            }
            else
                throw new ArchivosExceptions(new FileNotFoundException());

            return retorno;
        }
    }

}
