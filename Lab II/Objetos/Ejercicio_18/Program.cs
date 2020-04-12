using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_18";

            Punto vert1 = new Punto(6, 3);
            Punto vert3 = new Punto(10, 7);

            Rectangulo rect = new Rectangulo(vert1, vert3);


            Console.Write("El area del rectangulo es: {0} \nEl Perimetro es: {1}", rect.Area(), rect.Perimetro() ); 

            Console.ReadKey();
        }
    }
}
