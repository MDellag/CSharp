using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int minValor, int maxValor)
        {
            bool success = false;

            if (valor >= minValor && valor <= maxValor)
            {
                success = true;
            }

            return success;
        }
    }
}
