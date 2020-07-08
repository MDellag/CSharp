using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
            
        }

        public void AtenderClientes()
        {
            foreach (string item in FilaClientes)
            {
                Console.WriteLine("Nombre Cliente: {0}", item);
                Thread.Sleep(2500);
            } 
        }

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public override string ToString()
        {
            return "Caja ";
        }
    }
}
