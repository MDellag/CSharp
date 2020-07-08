using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptions
{
    public class idRepetidoExcp : Exception
    {
        public idRepetidoExcp(string msj, Exception inner)
            : base(msj, inner) { }

        public idRepetidoExcp(string msj)
            :this(msj, null) { }
    }
}
