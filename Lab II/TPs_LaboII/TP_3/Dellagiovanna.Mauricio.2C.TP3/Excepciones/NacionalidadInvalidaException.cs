using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
        {

        }

        public NacionalidadInvalidaException(string mensaje, Exception e)
            : base(mensaje, e)
        {

        }

        public NacionalidadInvalidaException(string mensaje)
            :this(mensaje, null)
        {

        }

        public NacionalidadInvalidaException(Exception e)
            : this(null, e)
        {

        }
    }
}
