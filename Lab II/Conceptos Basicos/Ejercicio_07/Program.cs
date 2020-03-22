using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";

            DateTime localDate = DateTime.Now;
            DateTime birthday;
            TimeSpan difference;
            bool success;

            Console.Write("Ingrese Fecha de nacimiento MM/DD/YY: ");
            success = DateTime.TryParse(Console.ReadLine(), out birthday);

            while (!success)
            {
                Console.Write("Error. Reingrese Fecha MM/DD/YY: ");
                success = DateTime.TryParse(Console.ReadLine(), out birthday);
            }

                

            difference = localDate - birthday;

            Console.Write("La cantidad de dias vividos es de: {0}", difference);

            Console.ReadKey();

        }
    }
}
