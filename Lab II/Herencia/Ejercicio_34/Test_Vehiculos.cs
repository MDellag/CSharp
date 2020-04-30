using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;

namespace Ejercicio_34
{
    class Test_Vehiculos
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_34";

            Vehiculo v = new Automovil(3, 5, 3, Vehiculo.Colores.Gris);
            Vehiculo m = new Moto(250, Vehiculo.Colores.Rojo);
            Vehiculo c = new Camion(8, 17, 6, Vehiculo.Colores.Blanco);

            Console.WriteLine(v.ToString() + "\n\n");
            Console.WriteLine(m.ToString() + "\n\n");
            Console.WriteLine(c.ToString() + "\n\n");


            Console.ReadKey();
        }
    }
}
