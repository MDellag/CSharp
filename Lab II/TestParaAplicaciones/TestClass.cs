using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParaAplicaciones
{
    class TestClass
    {
        public enum ESex
        {
            Masculino,
            Femenino
        }

        private List<string> lista;
        private string name;
        private ESex sexo;

        private TestClass()
        {
            lista = new List<string>();
        }

        public TestClass(string name)
            : this()
        {
            this.name = name;
        }

        public TestClass(string name, ESex sexo)
            : this(name)
        {
            this.sexo = sexo;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\n" +
                "Sexo: {1}", this.name, this.sexo.ToString());
        }

        public int elementosEnLista()
        {
            return lista.Count;
        }
    }
}
