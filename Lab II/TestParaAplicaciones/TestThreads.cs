using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestParaAplicaciones
{
    public class TestThreads
    {
        public TestThreads(string msj)
        {
            Thread tr = new Thread(new ParameterizedThreadStart(imprime));
            tr.Start(msj);
        }
        void imprime(object o)
        {
            Console.WriteLine((string)o);
        }
    }
}
