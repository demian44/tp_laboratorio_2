using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInstanciables
{   

    public class Universidad
    {
        private List<Alumno> _alumnos;
        private List<Jornada> _jornada;
        private List<Profesor> _profesores;

        #region Properties
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this._profesores; }
            set { this._profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this._jornada; }
            set { this._jornada = value; }
        }

        public Jornada this[int i]
        {
            get { return this._jornada[i]; }
            set { this._jornada[i] = value; }
        }
        #endregion
        #region Methods
        public bool Guardar(Universidad gim);
        private bool MostrarDatos(Universidad gim);
        public static operator ==(Universidad g, Alumno a);
        public static operator !=(Universidad g, Alumno a);

        #endregion

        public enum EClases { Programacion, Laboratorio, SPD }
    }
}
