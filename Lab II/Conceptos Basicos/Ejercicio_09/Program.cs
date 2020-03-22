using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";

            //Variables
            int nroPisosPiramide;
            bool success;
            int contador = 1,
                a;

            //Mensaje y Parse
            Console.Write("Ingrese nro de pisos para la Piramide: ");
            success = int.TryParse(Console.ReadLine(), out nroPisosPiramide);

            Console.Write("\n\nPiramide \n---------- \n\n");

            while (!success)
            {
                Console.Write("Error. Reingrese nro de pisos: ");
                success = int.TryParse(Console.ReadLine(), out nroPisosPiramide);
            }


            //Comienzo Programa
            for (int i = 1; i <= nroPisosPiramide; i++)
            {
                for ( a = 0; a < contador; a++)
                {
                    Console.Write("*");
                }
                contador += 2;
                Console.Write("\n");
            }


            //Final
            Console.ReadKey();
        }
    }
}
