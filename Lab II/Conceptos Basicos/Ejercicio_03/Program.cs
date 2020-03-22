using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            int numero;
            int contador = 0;
            bool isPrimo = false;
            

            Console.Write("Ingrese el rango de numeros primos: ");
            bool success = Int32.TryParse(Console.ReadLine(), out numero);
            Console.Write("\n\n");

            while (!success || numero < 1)
            {
                Console.Write("Error. Reingrese un Numero valido: ");
                success = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Write("\n\n");
            }

            for (int i = 1; i <= numero; i++)
            {
                for (int e = 1; e <= numero; e++)
                {
                   
                   if (i % e == 0)
                   {
                        contador++;

                        if (contador == 3)
                        {
                            isPrimo = true;
                            contador = 0;
                            break;                      
                        }
                   }
                    
                }
                if(isPrimo == false)
                {
                    Console.Write("{0} - ", i);
                }

                isPrimo = false;
            }

            Console.ReadKey();

        }
    }
}
