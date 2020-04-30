using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol;

namespace Ejercicio_35
{
    class TestFutbol_35
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_35";

            DateTime date = new DateTime(1999, 05, 30);
                
            DirectorTecnico d = new DirectorTecnico("Hernan", date);

            Jugador j = new Jugador(3949393, "David", 14, 5);


            Console.WriteLine(d.MostrarDatos());
            Console.WriteLine(j.MostrarDatos());

            Console.ReadKey();
        }
    }
}
