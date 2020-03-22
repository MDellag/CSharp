using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";

            int numero = 20;
            string cadena;
            double numPerfecto;

            for (int i = 1; i <= numero; i++)
            {
                numPerfecto = Math.Pow(2, i - 1) * (Math.Pow(2, i) - 1) ;

                cadena = numPerfecto.ToString();

                if (cadena.Substring(cadena.Length -1) == "6" || cadena.Substring(cadena.Length -1) == "8")
                {

                    Console.Write("Nro Perfecto {0}: {1} \n", i, numPerfecto);
                }
            }

            Console.ReadKey();
        }
    }
}
