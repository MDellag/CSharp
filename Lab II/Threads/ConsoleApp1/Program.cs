using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void DelegadoAsignarCaja();
        delegate void DelegadoCaja1();
        delegate void DelegadoCaja2();

        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio neg = new Negocio(c1, c2);
            //neg.AsignarCaja();

            Thread d = new Thread(neg.AsignarCaja);
            Thread t = new Thread(neg.Caja1.AtenderClientes);
            Thread s = new Thread(neg.Caja2.AtenderClientes);

            t.Name = "Caja 1";
            s.Name = "Caja 2";

            d.Start();

            //espera a q finalize el thread ANTES DE CONTINUAR
            d.Join();

                if (neg.Clientes.Count > 0)
                {
                    t.Start();
                    s.Start();
                } 
             
            



            Console.ReadKey();
        }
    }
}
