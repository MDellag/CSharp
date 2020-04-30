using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_27";

            Queue<int> queu = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                int a = rnd.Next(-100, 100);
                queu.Enqueue(a);
            }


            while (queu.Count > 0)
            {
                Console.Write(queu.Dequeue() + " ");
            }



            Console.ReadKey();
        }
    }
}
