using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_laboratorio_2
{
    public class Numero
    {
        private double _numero;

        /// <summary>
        /// Genera una instancia con valor "cero".
        /// </summary>
        public Numero()
        {
            _numero = 0;
        }
        /// <summary>
        /// Inicializa el objeto del tipo Numero ingresando un numero de tipo 'double' sin validar.
        /// </summary>
        /// <param name="num"></param>
        public Numero(double num)
        {
            this._numero = num;
        }

        /// <summary>
        /// Instancia la clase utilizando la funcion SetNumero.
        /// </summary>
        /// <param name="numeroString"></param>
        public Numero(string numeroString)
        {
            SetNumero(numeroString);
        }
        /// <summary>
        /// Carga el numero en la variable privada "_numero" si es que es el mismo es válido.
        /// </summary>
        /// <param name="numeroString"></param>
        private void SetNumero(string numeroString)
        {
            double.TryParse(numeroString, out this._numero);
        }
        /// <summary>
        /// Devuelve el valor en Double.
        /// </summary>
        /// <returns></returns>
        public double GetNumero()
        {
            return this._numero;
        }
    }
}
