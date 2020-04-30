using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class DirectorTecnico:Persona
    {
        private DateTime fechaNacimiento;



        #region Constructor Director Tecnico
        // -------------------------------------
        private DirectorTecnico(string nombre)
            :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        // -----------------------------------------
        #endregion

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
        }

        #region Operadores
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool iguales = false;
            if (d1.fechaNacimiento == d2.fechaNacimiento && d1.Nombre == d2.Nombre)
            {
                iguales = true;
            }
            return iguales;
        }


        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat("Nombre: {0}\n", this.Nombre);
            info.AppendFormat("Dni: {0}\n", this.Dni);
            info.AppendFormat("Fecha Nacimiento: {0}\n", this.FechaNacimiento);

            return info.ToString();
        }
    }
}
