using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            char opcion;
            double num1, num2;

            Console.Write("Calculadora \n----------");

            Console.Write("\n\nIngrese el primer digito: ");
            double.TryParse(Console.ReadLine(), out num1);
            

            Console.Write("\nIngrese el segundo digito: ");
            double.TryParse(Console.ReadLine(), out num2);


            Console.Write("\n\n- Suma digite '+' \n- Resta digite '-' \n- Multiplicacion digite '*' \n" +
                "- Division digite '/' \n\nOpcion: ");
            opcion = Char.Parse(Console.ReadLine());

            Console.Write("El resultado es : {0}", Calculadora.Calcular(num1, num2, opcion));
            Console.ReadKey();
        }
    }
}
