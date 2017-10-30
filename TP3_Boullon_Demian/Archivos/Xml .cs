using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {

        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            if (ReferenceEquals(datos, null))
                throw new NullReferenceException();
            else
            {
                try
                {
                    
                    StreamWriter streamWriter = new StreamWriter(archivo);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                    streamWriter.Close();
                    retorno = true;
                }
                catch (Exception exception)
                {
                    throw new ArchivosException(exception);
                }

            }        

            return retorno;
        }


        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;            
            XmlTextReader xmlTextReader;
            XmlSerializer xmlSerializer;
            if (File.Exists(archivo))
            {
                xmlTextReader = new XmlTextReader(archivo);
                xmlSerializer = new XmlSerializer(typeof(T));

                datos = (T)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                retorno = true;
            }
            else            
                datos = default(T);            

            return retorno;
        }
    }
}
