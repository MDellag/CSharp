using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1;

namespace Ejercicio_36
{
    class Test_Vehiculos_36
    {
        /** Revisar que no anda como deberia con el agregar..
         *  deberia agregar solo los vehiculos correspondientes a la carrera pasada por parametro
         */ 
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_36";

            VehiculoDeCarrera m1 = new Motocross(2, "Ducatti", 1250);
            Motocross m2 = new Motocross(1, "Yamaha", 1000);

            VehiculoDeCarrera a1 = new AutoF1(4, "Ferrari", 420);
            AutoF1 a2 = new AutoF1(5, "Lamborghini", 510);

            Competencia comp = new Competencia(10, 4, Competencia.TipoCompetencia.MotoCross);

            comp += m1;
            comp += m2;
            comp += a1;
            comp += a2;


            

            

            Console.WriteLine(comp.MostrarDatos()+ a1.MostrarDatos() + a2.MostrarDatos());

            


           

           // Console.ReadKey();
        }
    }
}
