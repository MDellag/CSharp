using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParaAplicaciones
{
    public class TestDerivedClass : TestBaseClass
    {


        private string nombre;

        public TestDerivedClass(string nombre, int num)
            : base(num)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public override string Teach()
        {
            return "Un profe puede enseniar en un colegio.";
        }

        public string Contar()
        {
            return "1, 2, 3, 4, 5\n";
        }
    }
}
