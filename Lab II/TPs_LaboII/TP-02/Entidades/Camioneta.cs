using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// COnstructor del Tipo Camioneta
        /// </summary>
        /// <param name="marca">Se le asigna una marca de las habilitadas en Vehiculo.EMarca</param>
        /// <param name="codigo">patente o nro de motor</param>
        /// <param name="color">color del vehiculo</param>
        public Camioneta(Vehiculo.EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }
        #endregion

        #region Propiedad
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region Mostrar
        /// <summary>
        /// Muestra todos los datos del TIpo Camioneta
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
