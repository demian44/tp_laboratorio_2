using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{

    public enum EMarca
    {
        Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
    }

    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        EMarca _marca;
        string _codigoDeBarras;
        ConsoleColor _colorPrimarioEmpaque;

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public abstract short CantidadCalorias { get; }
        public Producto( EMarca marca, string patente, ConsoleColor color)
        {
            this._codigoDeBarras = patente;
            this._marca = marca;
            this._colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (String)this;
        }

        /// <summary>
        /// Convierte implicitamente el producto en un mensaje "string" con tu información.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("CODIGO DE BARRAS: {0}\r\n", p._codigoDeBarras));
            sb.AppendLine(String.Format("MARCA          : {0}\r\n", p._marca.ToString()));
            sb.AppendLine(String.Format("COLOR EMPAQUE  : {0}\r\n", p._colorPrimarioEmpaque.ToString()));
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            bool retorno = false;
            if (!object.ReferenceEquals(null, v1) && !object.ReferenceEquals(null, v2))
                retorno=(String.Compare(v1._codigoDeBarras , v2._codigoDeBarras)==0);
            return retorno;
        }

        /// <summary>
        ///  Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1._codigoDeBarras == v2._codigoDeBarras);
        }

        /// <summary>
        ///  Recibe un objeto, determina si es o no de la misma clase y si no es null.
        /// Si son iguales compara con la sobrecarga del operador "==".
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {            
            if (!ReferenceEquals(obj, null) && this.GetType() != obj.GetType())
                return true;

            return (this==(Producto)obj);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <returns></returns> 
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
