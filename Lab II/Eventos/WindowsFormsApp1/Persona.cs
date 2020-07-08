using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;

        public Persona()
        {
            nombre = "";
            apellido = "";
        }

        public string Nombre
        {
            set
            {
                if (this.nombre != value)
                {
                    nombre = value;
                    this.EventoString.Invoke(Mostrar());
                }
            }

            get { return this.nombre; }
        }

        public string Apellido
        {
            set
            {
                if (this.apellido != value)
                {
                    apellido = value;
                    this.EventoString.Invoke(Mostrar());
                }
            }
            get { return this.apellido; }
        }

        
        public string Mostrar()
        {

            return string.Format("Nombre: {0}  Apellido: {1}", nombre, apellido);
        }
    }
}
