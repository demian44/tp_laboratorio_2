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
            bool returnAux = false;
            XmlTextWriter fl = new XmlTextWriter(archivo, System.Text.Encoding.UTF8);
            try
            {
                if (!object.ReferenceEquals(fl, null))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(fl, datos);
                    returnAux = true;
                }
            }
            catch(Exception exception)
            {
                throw new ArchivosException(exception);
            }

            return returnAux;
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
