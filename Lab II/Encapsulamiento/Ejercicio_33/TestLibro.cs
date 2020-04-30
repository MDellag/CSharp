using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class TestLibro
    {
        //Indexador
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_33";

            //Libro auth = new Libro();

            Libro a = new Libro();

            a[2] = "Index 2 pag agregada";
            a[1] = "Index 1 pag agregado";
            a[3] = "Index 3";
            a[1] = "Index 1 editado";
            a[0] = "Index 0 supuestamente";
            a[2] = "Editado index 2";
            


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
    }
}
