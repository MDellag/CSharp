using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            //Variables
            float promedio;
             int    valor,
                    min = 0,
                    max = 0,
                sumador = 0;
            bool flag = false;


            //Programa
            for (int a = 0; a < 10; a++)
            {
                //Input
                Console.Write("Ingrese un valor entre -100 y 100: ");
                int.TryParse(Console.ReadLine(), out valor);

                if (Validacion.Validar(valor, -100, 100))
                {
                    if (!flag)
                    {
                        min = valor;
                        max = valor;
                       flag = true;
                    }

                    if (min > valor)
                    {
                        min = valor;
                    }

                    if (max < valor)
                    {
                        max = valor;
                    }

                    sumador += valor;

                }
            }


            promedio = sumador / 10;

            Console.Write("\n\nEl Promedio es de: {0} \nEl Num Minimo es: {1} \nEl Num Maximo es: {2}", promedio, min, max);


            Console.ReadKey();
        }




    }


   

       

    
}
