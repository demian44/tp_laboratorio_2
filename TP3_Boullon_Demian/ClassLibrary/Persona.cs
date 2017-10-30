using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Clase Persona:
 *  Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
 *  Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y
 * 89999999. Caso contrario, se lanzará la excepción DniInvalidoException.
 *  Sólo se realizarán las validaciones dentro de las propiedades.
 *  Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
 * cargará.
 *  ToString retornará los datos de la Persona.
 * 
 * */
namespace EntidadesAbstractas
{


    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }
        private string _nombre;
        private string _apellido;
        private ENacionalidad _nacionalidad;
        private int _dni;

        #region Propiedades

        protected string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (OnlyLetters(value))
                    this._nombre = value;
            }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set
            {
                if (OnlyLetters(value))
                    this._nombre = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set
            {
                this._nacionalidad = value;
            }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        #endregion


        #region Metodos

        public Persona()
        {
            this._nombre = "";
            this._apellido = "";
            this._dni = 0;
        }

        public Persona(String nombre, String apellido, ENacionalidad nacionalidad) : this()
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        public Persona(String nombre, String apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            try
            {
                this._dni = ValidarDni(nacionalidad, dni);
            }
            catch
            {
                throw new DniInvalidoException("asd");
            }


        }

        public Persona(String nombre, String apellido, String dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            int aux = 0;
            if (int.TryParse(dni, out aux) && ValidarDni(nacionalidad, aux) != 0)
                this._dni = aux;
        }

        /// <summary>
        /// Recorre la cadena de caracteres en busca de un elemento que no sea una letra.
        /// En caso de encontrar dicho elemento retorna false, caso contrario, true.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool OnlyLetters(string text)
        {
            bool retorno = true;
            foreach (char caracter in text)
            {
                if (!char.IsLetter(caracter))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el dni esté entre 1 y 89999999.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        private static int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            int retorno = 0;

            if (dni < 1 || dni > 89999999 && nacionalidad == ENacionalidad.Argentino)
                throw new DniInvalidoException("Valor invalido.");            
            else if (dni > 1 && dni < 89999999 && nacionalidad != ENacionalidad.Argentino)            
                throw new NacionalidadInvalidaException(" Numero opNacionalidad incorrecta");            
            else            
                retorno = dni;
            
            return retorno;
        }

        /// <summary>
        /// Valida que el dni esté entre 1 y 89999999.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            int aux = 0;
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (!int.TryParse(dni, out aux))
                    throw (new DniInvalidoException("Se ingresaron caracteres invalidos."));
                if (aux < 1 || aux > 89999999)
                    throw (new DniInvalidoException("Fuera de rango."));
            }

            return aux;
        }

        /// <summary>
        /// Devuelve nombre, apellido, nacionalidad y DNI (Uno por renglon).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("NOMBRE COMPLETO: {0}, {1}\nNacionalidad: {2}\n", this._apellido, this._nombre, this._nacionalidad.ToString());
        }


        #endregion
    }
}
