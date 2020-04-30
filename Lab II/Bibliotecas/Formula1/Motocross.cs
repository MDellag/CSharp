using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Motocross:VehiculoDeCarrera
    {
        private short cilindrada;


        public Motocross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }


        public Motocross(short numero, string escuderia, short cilindrada)
            :base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
        }

        public static bool operator ==(Motocross m1, Motocross m2)
        {
            if (m1.Cilindrada == m2.Cilindrada)
            {
                return true;
            }
            else
                return false;
        }


        public static bool operator !=(Motocross m1, Motocross m2)
        {
            return !(m1 == m2);
        }

        public override string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();

            info.Append(base.MostrarDatos());
            info.Append($"Cilindrada: {this.Cilindrada}\n\n");

            return info.ToString();
        }
    }
}
