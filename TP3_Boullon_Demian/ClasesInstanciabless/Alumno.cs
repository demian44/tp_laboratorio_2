using System;
using System.IO;
using static ClasesInstanciables.Universidad;
using System.Text;
using static EntidadesAbstractas.Persona;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    /*
     * Clase Alumno:
     *  Atributos ClaseQueToma del tipo EClase y EstadoCuenta del tipo EEstadoCuenta.
     *  Sobreescribirá el método MostrarDatos con todos los datos del alumno.
     *  ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
     *  ToString hará públicos los datos del Alumno.
     *  Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
     *  Un Alumno será distinto a un EClase sólo si no toma esa clase.
     */
    public class Alumno : Universitario
    {
        public enum EEstadoCuenta { Becado, Deudor, AlDia }
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public Alumno() : base()
        { }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder().Append(base.MostrarDatos());
            stringBuilder.AppendLine("ESTADO DE CUENTA: " + this._estadoCuenta +
                "\nTOMA CLASE DE " + this._claseQueToma.ToString());
            return stringBuilder.ToString();
        }

        public static bool operator ==(Alumno a, EClases clase)
        {
            bool retorno = false;
            if (a._claseQueToma == clase)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Alumno a, EClases clase)
        {
            return !(a == clase);
        }

        protected override string ParticiparEnClase()
        {
            return ("TOMA LA CLASE DE " + this._claseQueToma.ToString());
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
