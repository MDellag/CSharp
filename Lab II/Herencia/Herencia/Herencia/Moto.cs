using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Moto : Vehiculo
    {
        private short cilindrada;

        public Moto(short cilindrada, Colores color)
            : base(2, 5, 0, color)
        {
            this.cilindrada = cilindrada;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat(base.ToString());
            info.AppendFormat($"Cilindrada: {this.cilindrada}");

            return info.ToString();
        }
    }
}
