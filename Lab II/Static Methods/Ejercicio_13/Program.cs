using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";

            
            double dbNumDecimal;
            string strBinaryToDecimal;
            int option;

            Console.Write("1- Decimal a Binario ");
            Console.Write("\n2- Binario a Decimal");
            Console.Write("\n\nOpcion: ");
            int.TryParse(Console.ReadLine(), out option);


            
            switch(option)
            {
                case 1:
                    Console.Write("\nIngrese un nro a convertir a binario: ");
                    Double.TryParse(Console.ReadLine(), out dbNumDecimal);


                    Console.WriteLine("El numero en Binario es : {0}", Conversor.DecimalBinario(dbNumDecimal));
                    break;

                case 2:
                    Console.Write("\nIngrese un nro Binario a convertir a decimal: ");
                    strBinaryToDecimal = Console.ReadLine();

                    Console.WriteLine("El numero en Decimal es: {0}", Conversor.BinarioDecimal(strBinaryToDecimal));
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
