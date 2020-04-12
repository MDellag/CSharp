using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_22";

            NumeroBinario objBinario = "100101";
            NumeroDecimal objDecimal = 9;

            string asd = (string)objBinario;
            double ass = (double)objDecimal;

            double suma = objDecimal + objBinario;

            StringBuilder operations = new StringBuilder();

            operations.Append("");

            Console.WriteLine(asd + " {0}\n", Conversor.BinarioDecimal(asd));
            Console.WriteLine(ass + " {0}", Conversor.DecimalBinario(ass));


            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
