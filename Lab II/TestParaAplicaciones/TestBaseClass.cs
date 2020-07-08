using Herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParaAplicaciones
{
    public class TestBaseClass 
    {
        protected int numero;

        public TestBaseClass(int num)
        {
            numero = num;
        }
        public int Numero
        {
            get { return this.numero; }
        }

        //public static explicit operator string(TestBaseClass p)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendFormat("El numero es {0}", p.numero);
        //    return sb.ToString();
        //}

        public static implicit operator string(TestBaseClass p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El numero es {0}", p.numero);
            return sb.ToString();
        }

        public string MandarMsj()
        {
            return "Msj Enviado";
        }


        public virtual string Teach()
        {
            return "Una persona puede enseniar";
        }
    }
}
