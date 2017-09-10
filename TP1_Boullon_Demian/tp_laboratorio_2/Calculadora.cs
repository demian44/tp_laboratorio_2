using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_laboratorio_2
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion validando el operador.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;
            switch (operador)
            {
                case "+":
                    retorno = numero1.GetNumero() + numero2.GetNumero();
                    break;
                case "-":
                    retorno = numero1.GetNumero() - numero2.GetNumero();
                    break;
                case "/":
                    if (numero2.GetNumero() != 0)
                        retorno = numero1.GetNumero() / numero2.GetNumero();
                    break;
                case "*":
                    retorno = numero1.GetNumero() * numero2.GetNumero();
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// valida que el operador sea válido.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                operador = "+";
            return operador;
        }

    }
}
