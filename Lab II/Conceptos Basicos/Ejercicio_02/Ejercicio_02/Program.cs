using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            double numToPow;

            Console.Write("Ingrese un numero a calcular el cuadrado: ");
            bool success = double.TryParse(Console.ReadLine(), out numToPow);

            while (!success)
            {
                Console.Write("\nError. Reingrese un Numero valido: ");
                success = double.TryParse(Console.ReadLine(), out numToPow);
            }


            Console.WriteLine("\nEl Cuadrado del Numero es: {0}", Math.Pow(numToPow, 2));

            Console.ReadKey();
        }
    }
}
