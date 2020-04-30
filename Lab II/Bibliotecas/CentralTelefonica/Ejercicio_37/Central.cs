using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Ejercicio_37
{
    public class Central
    {
        static void Main(string[] args)
        {
            Console.Title = "Centralita";

            Centralita efectivoSi = new Centralita("Efectivo Si");

            Local L1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial L3 = new Provincial("Moron", "Bernal", 21, Provincial.Franja.Franja_1);
            Local L2 = new Local("Quilmes", 45, "San Rafael", 1.99f);
            Provincial L4 = new Provincial(Provincial.Franja.Franja_1, L2); //L2 es una llamada entonces cuenta como parametro

            //Las llamadas se iran registrando en la central
            // La central mostrara por pantalla todas las llamadas segun las vaya registrando
            efectivoSi.Llamadas.Add(L1);
            Console.WriteLine(efectivoSi.ToString());
            efectivoSi.Llamadas.Add(L2);
            Console.WriteLine(efectivoSi.ToString());
            efectivoSi.Llamadas.Add(L3);
            Console.WriteLine(efectivoSi.ToString());
            efectivoSi.Llamadas.Add(L4);
            Console.WriteLine(efectivoSi.ToString());

            efectivoSi.OrdenarLlamadas();
            Console.WriteLine(efectivoSi.ToString() + "\n\n\n\n");

            Local llamada1 = new Local("Avellaneda", 11, "Solano", 1.99f);
            efectivoSi += llamada1;

            Console.WriteLine(efectivoSi.ToString());

            Console.ReadKey();
        }
    }
}
