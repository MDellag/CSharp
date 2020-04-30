using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Vehiculo
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected short cantidadMarchas;
        protected Colores color;


        public Vehiculo(short cantidadRuedas, short cantidadMarchas, short cantidadPuertas, Colores color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat($"Color: {this.color}\n");
            info.AppendFormat($"Cantidad Marchas: {this.cantidadMarchas}\n");
            info.AppendFormat($"Cantidad Puertas: {this.cantidadPuertas}\n");
            info.AppendFormat($"Cantidad Ruedas: {this.cantidadRuedas}\n");

            return info.ToString();
        }

        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }
    }
}
