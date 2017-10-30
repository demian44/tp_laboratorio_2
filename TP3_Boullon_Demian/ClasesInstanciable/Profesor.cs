using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
    [Serializable]
    public class Profesor : Universitario
    {
        protected Queue<Universidad.EClases> _clasesDelDia;
        protected static Random _random;

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


        protected override string ParticiparEnClase()
        {
            string retorno = "\nCLASES DEL DIA:";
            foreach (Universidad.EClases clase in this._clasesDelDia)
            {
                retorno += string.Format(" {0}\n", clase.ToString());
            }
            return retorno;
        }

        protected override string MostrarDatos()
        {
            return string.Format("{0} {1}", base.MostrarDatos(), this.ParticiparEnClase());
        }


        private void _randomClases()
        {
            int aux = _random.Next(0, 3);
            if(aux == 0)
                this._clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
            else if (aux == 1)
                this._clasesDelDia.Enqueue(Universidad.EClases.Programacion);
            else if (aux == 2)
                this._clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
            else 
                this._clasesDelDia.Enqueue(Universidad.EClases.SPD);
        }


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

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}