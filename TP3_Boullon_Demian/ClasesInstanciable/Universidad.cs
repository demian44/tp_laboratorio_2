﻿using Archivos;
using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClasesInstanciables
{  
    [Serializable]
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
            get
            {
                if (i < this._jornada.Count && i >= 0)
                    return this._jornada[i];
                else
                    return null;
            }
            set
            {
                if (!ReferenceEquals(value, null))
                {
                    this._jornada[i] = value;
                }
            }
        }
        #endregion

        #region Constructors

        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Jornadas = new List<Jornada>();
            this.Instructores = new List<Profesor>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Guarda a la universidad en un archivo xml.
        /// </summary>
        /// <param name="gim"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad gim)
        {
            string nomArchivo = "Universidad.xml";
            Xml<Universidad> fileXml = new Xml<Universidad>();
            bool returnAux = fileXml.Guardar(nomArchivo, gim);
            return returnAux;
        }

        /// <summary>
        /// Muestra los datos de la universidad.
        /// </summary>
        /// <param name="gim"></param>
        /// <returns></returns>
        private bool MostrarDatos(Universidad gim)
        {
            bool retorno = false;
            if (!File.Exists("Universidad.xml"))
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                xml.Leer("Universidad.xml", out gim);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Devuelve la informacion perteneciente a las jornadas de la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Jornada jornada in this._jornada)
            {
                stringBuilder.AppendLine(jornada.ToString());
            }

            return stringBuilder.ToString();
        }

        #endregion

        #region Operators
        public static bool operator ==(Universidad g, Alumno a)
        {
            if (!ReferenceEquals(null, g) && !ReferenceEquals(null, a))
            {
                foreach (Alumno alumno in g._alumnos)
                {
                    if (alumno == a)
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }


        public static bool operator ==(Universidad g, EClases clase)
        {
            foreach (Jornada jornada in g._jornada)
            {
                if (jornada.Clase == clase)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Universidad g, EClases clase)
        {
            return !(g == clase);
        }

        public static bool operator ==(Universidad g, Profesor profesor)
        {
            foreach (Jornada jornada in g._jornada)
            {
                if (jornada.Instructor == profesor)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Universidad g, Profesor profesor)
        {
            return !(g == profesor);
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (!ReferenceEquals(null, g) && !ReferenceEquals(g, null))
            {
                if (g != a)                
                    g._alumnos.Add(a);                
                else                
                    throw new AlumnoRepetidoException();                
            }
            else
                throw new Exception("Referencia nula");

            return g;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            if (g != clase)
            {
                Jornada jornada;
                if (g._profesores.Count == 0)
                    throw (new SinProfesorException());

                foreach (Profesor prof in g._profesores)
                {
                    if (prof == clase)
                    {
                        jornada = new Jornada(clase, prof);
                        g._profesores.Remove(prof);
                        foreach (Alumno alumno in g._alumnos)
                        {
                            if (alumno == clase)
                                jornada.Alumnos.Add(alumno);
                        }
                        g.Jornadas.Add(jornada);

                        break;
                    }
                    else
                    {
                        throw new SinProfesorException();
                    }
                }
            }
            return g;
        }

        public static Universidad operator +(Universidad g, Profesor profesor)
        {
            if (ReferenceEquals(null, profesor) || ReferenceEquals(null,g))
                throw new NullReferenceException("Profesor no instanciado.");
            else
            {
                if (g != profesor)
                    g.Instructores.Add(profesor);                                
                    
            }               

            return g;
        }
        
        #endregion

        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
    }
}
