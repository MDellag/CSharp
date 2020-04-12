using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_20";

            Dolar dls = new Dolar(12.5);
            Euro  ers = new Euro(12.5);
            Pesos ps = new Pesos(100);


            Pesos asdd = ps - dls;

            Dolar asd = dls + ers;

            Pesos valorDolar = (Pesos)dls;
            Euro euroDolar = (Euro)ps;
            Dolar dol = (Dolar)ps;

            Console.WriteLine(valorDolar.GetCantidad());
            Console.WriteLine(dol.GetCantidad());
            Console.Write(euroDolar.GetCantidad());

           // prin(GenerateN());

            Console.ReadKey();
        }

        #region ArrayList
        static ArrayList GenerateN()
        {
            ArrayList nam = new ArrayList();
            nam.Add("Gamma");
            nam.Add("Alpha");
            nam.Add("Omega");

            return nam;
        }

        static void prin(ArrayList a)
        {
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
}
