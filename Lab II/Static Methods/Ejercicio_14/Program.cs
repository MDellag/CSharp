using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";

            int option;
            double dato, dato2;

            Console.Write("1- Calcular Area Cuadrado");
            Console.Write("\n2- Calcular Area Triangulo");
            Console.Write("\n3- Calcular Area Circulo");
            Console.Write("\n\nOpcion: ");


            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.Write("\n\nIngrese la medida del Lado del cuadrado: ");
                    Double.TryParse(Console.ReadLine(), out dato);
                    Console.Write("\nEl area del Cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(dato));
                    break;

                case 2:
                    Console.Write("\n\nIngrese la base del triangulo: ");
                    Double.TryParse(Console.ReadLine(), out dato);
                    Console.Write("\nIngrese la altura del triangulo: ");
                    Double.TryParse(Console.ReadLine(), out dato2);
                    Console.Write("\nEl area del Triangulo es: {0}", CalculoDeArea.CalcularTriangulo(dato, dato2));
                    break;

                case 3:
                    Console.Write("\n\nIngrese el radio del circulo: ");
                    Double.TryParse(Console.ReadLine(), out dato);
                    Console.Write("\nEl area del Circulo es: {0}", CalculoDeArea.CalcularCirculo(dato));
                    break;
            }

            Console.ReadKey();
        }
    }
}
