using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Automovil : Vehiculo
    {
        
        private int cantidadPasajeros;

        public Automovil(short cantidadPasajeros, short cantidadMarchas, short cantidadPuertas, Vehiculo.Colores color)
            : base(4, cantidadMarchas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat(base.ToString());
            info.AppendFormat($"Cantidad Pasajeros: {this.cantidadPasajeros}");

            return info.ToString();
        }
    }

    
}
