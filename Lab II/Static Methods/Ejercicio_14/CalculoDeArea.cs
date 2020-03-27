using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }


        public static double CalcularTriangulo(double bas, double alt)
        {
            return (bas * alt) / 2;
        }


        public static double CalcularCirculo(double radio)
        {
            const double PI = 3.14159265359;
                double area;

            area = PI * Math.Pow(radio, 2);

            return area;
        }
    }
}
