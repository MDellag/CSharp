using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Temporizador temporizador = new Temporizador();

            temporizador.Intervalo = 1500;

            temporizador.EventoTiempo += cuentaAtras;

            temporizador.Activo = true;
            
        }

        static void cuentaAtras()
        {
            int b = 35;

            while(b >= 0)
            {
                
                Console.WriteLine(b--);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
