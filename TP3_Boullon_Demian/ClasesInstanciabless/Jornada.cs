using Archivos;
using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    /*
     * Atributos Profesor, Clase y Alumnos que toman dicha clase.
     *  Se inicializará la lista de alumnos en el constructor por defecto.
     *  Una Jornada será igual a un Alumno si el mismo participa de la clase.
     *  Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
     *  ToString mostrará todos los datos de la Jornada.
     *  Guardar de clase guardará los datos de la Jornada en un archivo de texto.
     *  Leer de clase retornará los datos de la Jornada como texto.
     * 
     */
    public class Jornada
    {
        private List<Alumno> _alumno;
        private EClases _clase;
        private Profesor _instructor;

        public List<Alumno> Alumnos
        {
            get { return this._alumno; }
            set { this._alumno = value; }
        }

        public EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        public Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }

        public static bool Guardar(Jornada jornada)
        {
            try
            {
                if (!File.Exists("Jornada"))
                {
                    Texto texto = new Texto();
                    texto.Guardar("Jornada.txt", jornada.ToString());
                    return true;
                }
            }
            catch(Exception exception)                       
            {
                throw (new ArchivosException(exception));
            }
            return false;
        }
        public string Leer()
        {
            string retorno = " ";
            if (File.Exists("Jornada"))
            {
                Texto texto = new Texto();
                texto.Leer("Jornada.txt", out retorno);
            }
            return retorno;
        }

        private Jornada()
        {
            this._alumno = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this._instructor = instructor;
            this._clase = clase;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            if (j._alumno.Contains(a))
                return true;
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(!ReferenceEquals(null,j) && !ReferenceEquals(null,a))
            {
                if (!j._alumno.Contains(a))
                    j._alumno.Add(a);
            }
            return j;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<------------------------------------------------>");
            stringBuilder.AppendLine("CLASE DE " + this._clase.ToString() + "POR " + this._instructor.ToString());
            stringBuilder.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in this._alumno)
            {
                stringBuilder.AppendLine(alumno.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}

