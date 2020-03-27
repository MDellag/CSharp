using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {

        public static double Calcular(double primerNumero, double segundoNumero, char operacionAritmetica)
        {
            double resultado = 0;

            switch (operacionAritmetica)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;

                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;

                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;

                case '/':
                    if(!Validar(segundoNumero))
                        resultado = primerNumero / segundoNumero;
                    break;

                default:
                    Console.WriteLine("\nOpcion Invalida");
                    break;
            }



            return resultado;
        }


        private static bool Validar(double segundoNumero)
        {
            bool success = false;

            if (segundoNumero == 0)
            {
                success = true;
            }

            return success;
        }
    }
}
