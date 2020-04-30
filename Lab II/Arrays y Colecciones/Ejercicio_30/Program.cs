using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_30";


            Competencia competen = new Competencia(20, 5);

            AutoF1 auto1 = new AutoF1(1, "Ford");
            AutoF1 auto2 = new AutoF1(2, "Chevrolet");
            AutoF1 auto3 = new AutoF1(3, "VolksWagen");
            AutoF1 auto4 = new AutoF1(4, "Audi");
            AutoF1 auto5 = new AutoF1(5, "Mercedes Benz");


            if (competen + auto1 && competen + auto2 && competen + auto3 && competen + auto4 && competen + auto5)
            {
                Console.Write(competen.MostrarDatos());
            }


            Console.ReadKey();
        }
    }
}
