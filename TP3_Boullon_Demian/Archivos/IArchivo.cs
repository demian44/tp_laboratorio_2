using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /*Archivos:
    *  Generar una interfaz con las firmas para guardar y leer.
    *  Implementar la interfaz en las clases Xml y Texto, a fin de poder guardar y leer archivos de esos tipos.
    */
    public interface IArchivo<T>
    {
        bool Guardar(string archivo, T datos);
        bool Leer(string archivo,out T datos);
    }
}
