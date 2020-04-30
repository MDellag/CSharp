using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        //Propiedad obligatoria
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }


        #region Constructores
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        #endregion

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }


        #region Override
        protected override string  Mostrar()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat($"Costo Llamada: {this.CostoLlamada}\n");
            info.AppendFormat(base.Mostrar());

            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local; // return typeof(Local) == obj.GetType();   
        }

        public override string ToString()
        {
            return Mostrar();
        }
        #endregion
    }
}
