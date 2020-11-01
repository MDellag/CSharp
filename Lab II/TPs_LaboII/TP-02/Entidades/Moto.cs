using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        /// <summary>
        /// Constructor de la clase moto
        /// </summary>
        /// <param name="marca:">Alguna habilitada por Vehiculo.EMarca</param>
        /// <param name="codigo:">string que representa patente o nro motor</param>
        /// <param name="color:">color de COnsoleColor</param>
        public Moto(EMarca marca, string codigo, ConsoleColor color)
            :base(codigo, marca, color)
        {
        }


        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Muestra toda la informacion de este tipo de Vehiculo
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString() ;
        }
    }
}
