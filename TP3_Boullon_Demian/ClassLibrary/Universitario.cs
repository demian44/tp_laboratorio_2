using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /*
     * Abstracta, con el atributo Legajo.
     * Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
     * Método protegido y abstracto ParticiparEnClase.
     * Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
     */
    public abstract class Universitario : Persona
    {
        private int _legajo;


        public override bool Equals(object obj)
        {
            if (obj is Universitario)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            return (base.ToString() + "\n\nLEGAJO NUMERO: " + this._legajo.ToString());
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Compara dos personas por el legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (pg1.GetType() == pg2.GetType())
            {
                if (pg1._legajo == pg2._legajo || pg1.Dni == pg2.Dni)
                    retorno = true;
            }

            return retorno;             
        }
        protected  abstract string ParticiparEnClase();

        public Universitario()
        {
            this._legajo = 0;
        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido,dni,nacionalidad)
        {
            this._legajo = legajo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

    }
}
