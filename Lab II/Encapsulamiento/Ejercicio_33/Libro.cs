using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public int Length
        {
            get { return paginas.Count; }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < paginas.Count)
                {
                    return this.paginas[index];
                }
                else
                    return "";
            }
            set
            {
                if (index >= paginas.Count)
                {
                    paginas.Add(value); 
                }
                else if (index < paginas.Count)
                {
                    paginas[index] = value;
                }
            }

            
        }
       
    }
}
