using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";

            Console.WriteLine("Calculo centro numerico\n" +
                             "-----------------------");
            // Variables
            double aumento = 1,
                numero,
                sumaAtras,
                sumaAdelante;

            // Ingreso de datos
            Console.Write("Ingrese un numero (ejemplo: 10000): ");
            numero = double.Parse(Console.ReadLine());

            // Comienzo del programa
            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (double i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (double j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadKey();
        }
    }
}
