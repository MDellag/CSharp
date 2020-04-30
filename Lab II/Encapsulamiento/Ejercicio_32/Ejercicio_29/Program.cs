using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_29";

            Equipo team = new Equipo(11, "Petones");

            Jugador j1 = new Jugador(3949, "Marian");
            Jugador j2 = new Jugador(3842, "Juan");
            Jugador j3 = new Jugador(3562, "Palomo");
            Jugador j4 = new Jugador(3304, "Nico");
            Jugador j5 = new Jugador(2422, "Marciano", 50, 104);

            
            if( team + j1 )
            {
                Console.Write(j5.MostrarDatos());
            }

            


            Console.ReadKey();
        }
    }
}
