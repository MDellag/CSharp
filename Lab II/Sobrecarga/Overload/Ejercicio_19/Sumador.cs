using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        int cantidadSumas;

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int numero)
        {
            this.cantidadSumas = numero;
        }


        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++ ;

            return a + b;
        }


        public static explicit operator int (Sumador sum)
        {
            return sum.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }


        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }
    }
}
