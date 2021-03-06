﻿using Archivos;
using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClasesInstanciables
{    
    public class Jornada
    {
        private List<Alumno> _alumno;
        private Universidad.EClases _clase;
        private Profesor _instructor;

        #region Properties
        public List<Alumno> Alumnos
        {
            get { return this._alumno; }
            set { this._alumno = value; }
        }

        public Universidad.EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        public Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }
        #endregion

        #region Constructos
        private Jornada()
        {
            this._alumno = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this._instructor = instructor;
            this._clase = clase;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Guarda la jondada en un archivo de texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            string fileNamej = "Jornada.txt";
            bool returnAux = texto.Guardar(fileNamej, jornada.ToString());
            return returnAux;
        }

        /// <summary>
        /// Lee informacion de un archivo de texto Jornada.txt
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string retorno = " ";
            if (File.Exists("Jornada.txt"))
            {
                Texto texto = new Texto();
                texto.Leer("Jornada.txt", out retorno);
            }
            return retorno;
        }
               

        /// <summary>
        /// Devuelve un string con la informacion de la jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<------------------------------------------------>");
            stringBuilder.AppendLine("CLASE DE " + this._clase.ToString() + " POR " + this._instructor.ToString());
            bool flag = true;
            foreach (Alumno alumno in this._alumno)
            {
                if (flag)
                {
                    stringBuilder.AppendLine("ALUMNOS:");
                    flag = false;
                }
                stringBuilder.AppendLine(alumno.ToString());
            }
            if (flag)
                stringBuilder.AppendLine("SIN ALUMNOS");
            return stringBuilder.ToString();
        }

        #endregion

        #region Operators
        public static bool operator ==(Jornada j, Alumno a)
        {
            if (j._alumno.Contains(a) && j.Instructor.Dni!=a.Dni)
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
                if (j!=a)
                    j._alumno.Add(a);
                else
                    throw new AlumnoRepetidoException();
            }
            return j;
        }
        #endregion
                        
    }
}

