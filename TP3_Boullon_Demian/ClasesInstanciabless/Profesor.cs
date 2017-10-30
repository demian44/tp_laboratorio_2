using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    /*
     *  Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
     *  Sobrescribir el método MostrarDatos con todos los datos del profesor.
     *  ParticiparEnClase retornará la cadena "CLASES DEL DÍA " junto al nombre de la clases que da.
     *  ToString hará públicos los datos del Profesor.
     *  Se inicializará a Random sólo en un constructor.
     *  En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
     * mediante el método randomClases. Las dos clases pueden o no ser la misma.
     *  Un Profesor será igual a un EClase si da esa clase.
     */

    public class Profesor : Universitario
    {
        private Queue<EClases> _clasesDelDia;
        static private Random _random;

        protected override string ParticiparEnClase()
        {
            return "\nCLASES DEL DIA: " + _clasesDelDia.Dequeue().ToString() + "\n" + _clasesDelDia.Dequeue().ToString();
        }

        private void _randomClases()
        {
            if (_random.Next(0, 2) == 0)
                this._clasesDelDia.Enqueue(EClases.Laboratorio);
            else if (_random.Next(0, 2) == 1)
                this._clasesDelDia.Enqueue(EClases.Programacion);
            else
                this._clasesDelDia.Enqueue(EClases.SPD);
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            Boolean retorno = false;
            if (!ReferenceEquals(i, null))
            {
                if (i._clasesDelDia.Contains(clase))
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }

        public Profesor() : base()
        {
            this._clasesDelDia = new Queue<EClases>();
            this._randomClases();
            this._randomClases();
        }

        static Profesor()
        {
            _random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            _random = new Random();
        }

        public override string ToString()
        {
            return base.MostrarDatos() + this.ParticiparEnClase();
        }
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}