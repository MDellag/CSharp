using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para que guarde en XML los atributos deben ser publicos, caso contrario no guarda nada
            Persona mau  = new Persona("Kira", "Aizen");
            Persona mauDes;//= new Persona("Mauricio", "Dellagiovanna");

            Persona.Guardar(mau);

            mauDes = Persona.Leer(@"C:/Users/Nehl/Desktop/pepe.xml");



            Console.WriteLine(mauDes.ToString());

            Console.ReadKey();
        }
    }
}
