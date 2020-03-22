using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";

            //Variables
            int nroPisosPiramide;
            bool success;
            int contador = 1;
            int espacios = 55;

            //Mensaje y Parse
            Console.Write("Ingrese nro de pisos para la Piramide: ");
            success = int.TryParse(Console.ReadLine(), out nroPisosPiramide);

            Console.Write("\n\nPiramide \n---------- \n\n");

            while (!success)
            {
                Console.Write("Error. Reingrese nro de pisos: ");
                success = int.TryParse(Console.ReadLine(), out nroPisosPiramide);
            }


            //Comienzo Programa
            for (int i = 1; i <= nroPisosPiramide; i++)
            {
                //Multiplicador de string (No es facil como python -.-)
                string estrellita = String.Concat(Enumerable.Repeat("*", contador)); 
                string result = String.Concat(Enumerable.Repeat(" ", espacios));

                Console.Write("{0}", result);

                if (espacios > 0)
                 espacios -= 1; 
                
                Console.Write("{0}", estrellita);
                
                contador += 2;
                Console.Write("\n");
            }


            //Final
            Console.ReadKey();
        }
    }
}
