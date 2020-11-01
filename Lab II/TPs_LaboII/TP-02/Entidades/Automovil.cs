using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        #region Enum
        /// <summary>
        /// Tipo de Automovil
        /// </summary>
        public enum ETipo 
        { 
            Monovolumen,
            Sedan
        }
        #endregion

        #region Atributo
        /// <summary>
        /// Proviene del enumerador ETipo 
        /// </summary>
        private ETipo tipo;
        #endregion

        #region Constructor
        /// <summary>
        /// Por defecto, TIPO será Monovolumen, y asigna la marca, codigo y color
        /// </summary>
        /// <param name="marca">Una de las marcas de Vehiculo.EMarca</param>
        /// <param name="chasis">patente o nro de motor</param>
        /// <param name="color"> color del vehiculo</param>
        public Automovil(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
            tipo = ETipo.Monovolumen;
        }

        /// <summary>
        /// Este constructor, ademas, da la opcion de agregar un ETipo a gusto
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Automovil(EMarca marca, string codigo, ConsoleColor color, ETipo tipo)
            : this(marca, codigo, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Propiedad
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Mostrar
        /// <summary>
        /// Muestra toda la informacion del Automovil
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
