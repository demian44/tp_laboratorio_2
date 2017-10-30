using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClasesInstanciables
{   
    [Serializable]
    public class Profesor : Universitario
    {
        protected Queue<Universidad.EClases> _clasesDelDia;
        protected static Random _random;

        #region Constructors
        public Profesor() { }

        static Profesor()
        {
            _random = new Random();
        }


        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        #endregion

        #region Methods
        /// <summary>
        /// COmunica la clase en la cual es responsable.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            string retorno = "\nCLASES DEL DIA:";
            foreach (Universidad.EClases clase in this._clasesDelDia)
            {
                retorno += string.Format(" {0}\n", clase.ToString());
            }
            return retorno;
        }

        /// <summary>
        /// Muestra la informacion.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            return string.Format("{0} {1}", base.MostrarDatos(), this.ParticiparEnClase());
        }

        /// <summary>
        /// Define una clase para la jornada mediante la clase Random
        /// </summary>
        private void _randomClases()
        {
            int aux = _random.Next(0, 3);
            if (aux == 0)
                this._clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
            else if (aux == 1)
                this._clasesDelDia.Enqueue(Universidad.EClases.Programacion);
            else if (aux == 2)
                this._clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
            else
                this._clasesDelDia.Enqueue(Universidad.EClases.SPD);
        }

        /// <summary>
        /// Muestra los datos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operators
        public static bool operator ==(Profesor p, Universidad.EClases c)
        {
            bool returnAux = false;
            if (!object.ReferenceEquals(p, null) && !object.ReferenceEquals(c, null))
            {
                foreach (Universidad.EClases element in p._clasesDelDia)
                {
                    if (element == c)
                    {
                        returnAux = true;
                    }
                }
            }
            else
                throw new Exception();

            return returnAux;
        }

        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            bool returnAux = true;
            if (p == clase)
                returnAux = false;
            return returnAux;
        }
        #endregion
       
    }
}