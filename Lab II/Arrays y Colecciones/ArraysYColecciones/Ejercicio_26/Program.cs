using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            List<int> myList = new List<int>();
            

            for (int i = 0; i < 20; i++)
            {
                int a = rnd.Next(-100, 100);

                if (a != 0)
                {
                    myList.Add(a); 
                }
            }

            foreach (int e in myList)
            {
                Console.Write(e + " ");
            }

            Console.Write("\n\n"); 
            myList.Sort(Ordenar);
           
            foreach (int item in myList)
            {
                if (item > 0)
                {
                    Console.Write(item + " ");
                }
            }

            myList.Sort();
            Console.Write("\n\n");
            foreach (int item in myList)
            {
                if (item < 0)
                {
                    Console.Write(item + " ");
                }
            }


            Console.ReadKey();
        }


        /**@Brief ordenamiento Decreciente
         * @param: int a, int b
         * @return -1 si a es mayor a b
         *          1 si a es menor a b
         *          0 si son iguales
         */
        static int Ordenar(int a, int b)
        {
             int aux;

            if (a > b)
            {
                aux = 1;
            }
            else if (a < b)
            {
                aux = -1;
            }
            else
            {
                aux = 0;
            }

            return -aux;
        }
    }
}
