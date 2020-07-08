using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get { return this.caja1; }
        }

        public Caja Caja2
        {
            get { return this.caja2; }
        }

        public List<string> Clientes
        {
            get { return this.clientes; }
        }

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            clientes = new List<string>();

            clientes.Add("jose");
            clientes.Add("hit");
            clientes.Add("gohan");
            clientes.Add("kakarot");
            clientes.Add("saske");
            clientes.Add("kurumi");
            clientes.Add("tohka");
            clientes.Add("aizen");
            clientes.Add("cara");
            clientes.Add("mam");
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");
            foreach (var item in Clientes)
            {
                if (caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(item);
                    Console.WriteLine("{0} agregado a {1}", item, Caja1.ToString() + "1");
                }
                else
                {
                    caja2.FilaClientes.Add(item);
                    Console.WriteLine("{0} agregado a {1}", item, Caja1.ToString() + "2");
                }
                Thread.Sleep(1500);
            }
        }
    }
}
