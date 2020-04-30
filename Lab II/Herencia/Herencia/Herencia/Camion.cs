using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Camion : Vehiculo
    {

        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadMarchas, short pesoCarga, Vehiculo.Colores color)
            : base(cantidadRuedas,cantidadMarchas, 2, color)
        {
            this.pesoCarga = pesoCarga;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat(base.ToString());
            info.AppendFormat($"Peso Carga: {this.pesoCarga} Toneladas");

            return info.ToString();
        }
    }
}
