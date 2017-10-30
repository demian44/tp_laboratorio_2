using System;
using System.Collections.Generic;
using System.Text;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
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

        public Boolean Guardar(Jornada jornada)
        {            
        }

        private Jornada()
        {
            this._alumno = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor): this()
        {
            this._instructor = instructor;
            this._clase = clase;
        }

        public string Leer()
        {
        }

        public static bool operator ==(Jornada j,Alumno a)
        {

        }

        public static bool operator !=(Jornada j, Alumno a)
        {

        }

        public static Jornada operator +(Jornada j, Alumno a)
        {

        }

        public override string ToString()
        {
            
        }

    }
}

