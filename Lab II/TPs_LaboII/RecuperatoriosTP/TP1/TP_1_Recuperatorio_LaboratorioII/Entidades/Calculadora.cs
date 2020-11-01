using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida que el operador sea alguno de los 4 (+ - * /)
        /// caso contrario se asigna por defecto el operador '+'
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string strOperador = "+";

            if (operador == "+" || operador == "-" ||
                operador == "/" || operador == "*")
            {
                strOperador = operador;
            }

            return strOperador;
        }


        /// <summary>
        /// Opera 2 numeros segun el operador pasado como argumento
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            
            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
