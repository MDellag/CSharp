using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        
        private int legajo;

        #region Constructores
        public Universitario()
            : base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            Legajo = legajo;
        }
        #endregion

        /// <summary>
        /// Esta propiedad fue agregada con el Proposito de de obtener
        /// Los legajos asignados en la Deserializacion XML
        /// Ya que sin la propiedad, asignaba el valor 0 a todos los objetos
        /// que tenian el atributo Legajo.
        /// </summary>
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Verifica si un objeto es del tipo Universitario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }

        #region Operadores
        /// <summary>
        /// Un Universitario es Igual a otro solo si son del Mismo tipo
        /// Y tienen mismo DNI O Legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool sonIguales = false;

            if (pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        /// <summary>
        /// Negacion del Operador IGUAL de Universitario 1 y Universitario 2
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>true or false</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion

        /// <summary>
        /// Muestra los datos del Universitario
        /// Tanto Persona como Universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder inf = new StringBuilder();
            inf.AppendFormat(base.ToString());
            inf.AppendFormat($"Legajo:       {this.legajo}\n");

            return inf.ToString();
        }

        
    }
}
