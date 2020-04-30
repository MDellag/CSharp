using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Persona
    {
        private long dni;
        private string nombre;


        #region Constructores
        // Constructores de la Clase Persona          
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre)
            : this(nombre)
        {
            this.dni = dni;
        }
        /* ---------------------------------- */
        #endregion


        #region Propiedades
        // Propiedades de la CLase Persona
        public long Dni
        {
            get { return this.dni; }
            set 
            {
                if (value > 0)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = 0;
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        #endregion

    }
}
