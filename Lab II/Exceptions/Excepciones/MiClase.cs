using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MiClase
    {
        //mas o menos bien encaminado pero no es lo que pide
        public MiClase(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        public MiClase()
        {
            try
            {
                MiClase.LanzarExceptionDivideByZero();
            }
            catch(Exception e)
            {
                 new MiClase(e);
            }
        }

        public static void LanzarExceptionDivideByZero()
        {
            throw new DivideByZeroException();
        }
    }
}
