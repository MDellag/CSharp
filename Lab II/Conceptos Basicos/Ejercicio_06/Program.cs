using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            //Variables
            int startYear,
                finishYear;

            bool esBiciesto = false;
            
            //Input
            Console.Write("Introduzca un año de partida: ");
            startYear = int.Parse(Console.ReadLine());

            Console.Write("Introduzca un año final: ");
            finishYear = int.Parse(Console.ReadLine());

            //Comienzo programa
            for (int i = startYear; i < finishYear; i++)
            {
                if (i % 4 == 0) {
                    if (!(i % 100 == 0))
                    {
                        esBiciesto = true;
                    }
                    else if (i % 100 == 0 && i % 400 == 0)
                    {
                        esBiciesto = true;
                    }
                }

                if (esBiciesto)
                {
                    Console.WriteLine("{0} es biciesto", i);
                    esBiciesto = false;
                }
            }

            //Fin programa
            Console.ReadKey();
        }
    }
}
