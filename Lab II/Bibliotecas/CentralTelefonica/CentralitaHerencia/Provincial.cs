using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;


        #region Constructores
        public Provincial(string origen, string destino, float duracion, Franja miFranja)
            : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
         : this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, miFranja)
        {
            
        }
        #endregion

        //Propiedad obligatoria
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float aux;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1: aux = Convert.ToSingle(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2: aux = Convert.ToSingle(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3: aux = Convert.ToSingle(this.Duracion * 0.66);
                    break;

                default: aux = 0;
                    break;
            }
            return aux;
        }

        protected override string Mostrar()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat($"Franja horaria: {this.franjaHoraria}\n");
            info.AppendFormat($"Costo Llamada: {this.CostoLlamada}\n");
            info.AppendFormat(base.Mostrar());
            return info.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }



        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
    }

    
}
