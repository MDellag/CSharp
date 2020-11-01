using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /**@Brief: Valida que el operador sea alguno de los 4 (+ - * /)
         *          caso contrario se asigna por defecto el operador '+'
         * @Param: string operador
         * @Return: strOperador: 
         */ 
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


        /**@Brief: Opera 2 numeros segun el operador pasado como argumento
         * @Param Numero num1, Numero num2, string operador
         * @Return: resultado: operacion final entre 2 numeros
         */ 
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;

            switch (operador)
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

                default:
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }

    }
}
