using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejericio_12";

            int numero,
                suma = 0;
            char continuar;

            do
            {
                Console.Write("\nIngrese un numero a sumar: ");
                int.TryParse(Console.ReadLine(), out numero);
                suma += numero;

                Console.Write("\nDesea Continuar? S/N: ");
                char.TryParse(Console.ReadLine(), out continuar);

            } while (ValidaS_N(continuar));

            Console.Write("La suma de los numeros ingresados es de: {0}", suma);

            Console.ReadKey();
        }

        static bool ValidaS_N(char c)
        {
            bool success = false;

            char.ToUpper(c);

            if (c == 'S')
            {
                success = true;
            }

            return success;
        }
    }
}
