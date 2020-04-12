using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            string dibujo;

            Boligrafo bolig1 = new Boligrafo(1, ConsoleColor.Red);
            Boligrafo bolig2 = new Boligrafo(1, ConsoleColor.Blue);
            Boligrafo bolig3 = new Boligrafo(2, ConsoleColor.DarkYellow);
            Boligrafo bolig4 = new Boligrafo(2, ConsoleColor.Cyan);



            if(bolig1.Pintar(10, out dibujo))
            {
                Console.Write(dibujo);
            }

            if (bolig2.Pintar(5, out dibujo))
            {
                Console.Write(dibujo);
            }if (bolig3.Pintar(5, out dibujo))
            {
                Console.Write(dibujo);
            }if (bolig4.Pintar(5, out dibujo))
            {
                Console.Write(dibujo);
            }


            Console.ReadKey();
        }
    }
}
