using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Ejercicio_19";

            Sumador operation = new Sumador(534);

            int a = (int) operation;


           // Console.Write(operation.Sumar("asdasd", "qweqwe"));
           // Console.Write(operation.Sumar(10, 7));
           Console.Write(a);
            

            Console.ReadKey();
        }
    }
}
