using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerzas;

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :base(numero, escuderia)
        {
            this.caballosDeFuerzas = caballosDeFuerza;
        }

        
        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerzas; }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool success = false;

            if (a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                success = true;
            }
            return success;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


        public override string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();

            info.Append(base.MostrarDatos());
            info.Append($"Caballos de Fuerza: {this.CaballosDeFuerza}\n\n");

            return info.ToString();
        }


    }
}
