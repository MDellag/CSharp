using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

           //Alumno[] alumn = new Alumno[3];
            Alumno susi = new Alumno();
            Alumno diosito = new Alumno();
            Alumno marito = new Alumno();

            susi.setApellido("Susi");
            susi.setNombre("Siri");
            susi.setLegajo(10001);

            diosito.setApellido("Borges");
            diosito.setNombre("Diosito");
            diosito.setLegajo(10002);


            marito.setApellido("Espa");
            marito.setNombre("Marito");
            marito.setLegajo(10003);

            susi.Estudiar(7, 10);
            marito.Estudiar(5, 7);
            diosito.Estudiar(4, 4);

            susi.CalcularFinal();
            marito.CalcularFinal();
            diosito.CalcularFinal();

            Console.Write(susi.Mostrar());
            Console.Write(marito.Mostrar());
            Console.Write(diosito.Mostrar());
            #region vector Alumno
            /*
            alumn[0].setLegajo(10001);
            alumn[0].setApellido("Samura");
            alumn[0].setNombre("Sai");
            

            alumn[0].Estudiar(4, 5);


            alumn[1].setApellido("Cardz");
            alumn[1].setNombre("Marito");
            alumn[1].setLegajo(10002);

            alumn[1].Estudiar(3, 8);


            alumn[2].setApellido("Borges");
            alumn[2].setNombre("Diosito");
            alumn[2].setLegajo(10003);

            alumn[2].Estudiar(7, 9); */

            #endregion



            Console.ReadKey();
        }
    }
}
