using System;
using System.IO;
using EntidadesAbstractas;
using System.Text;

namespace ClasesInstanciables
{
    public class Alumno : Universitario
    {
        public enum EEstadoCuenta { Becado, Deudor, AlDia }
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        #region Constructs
        public Alumno() : base()
        { }

        /// <summary>
        /// Inicializa un alumno con todos sus datos excluyendo el estado de
        /// cuenta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Inicializa un alumno con todos sus datos excluyendo el estado de
        /// cuenta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Muestra la informacion del alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder().Append(base.MostrarDatos());
            stringBuilder.AppendLine("\nESTADO DE CUENTA: " + this._estadoCuenta +
                "\nTOMA CLASE DE " + this._claseQueToma.ToString());
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Muestra de que clase forma parte el alumno.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return ("TOMA LA CLASE DE " + this._claseQueToma.ToString());
        }

        /// <summary>
        /// Retorna la informacion del alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Determina si el objeto es alumno y si es el mismo alumno.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Alumno)            
                return (this ==(Alumno)obj);            
            else
                return false;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;
            if (a._claseQueToma == clase)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }
        #endregion

    }
}
