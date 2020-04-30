using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        

        #region Gets
        /* *************************** */
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada { get; }
        /* ****************************** */
        #endregion

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        protected virtual string Mostrar()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat("Duracion de la llamada: {0:##.##}minutos\n", this.duracion);
            info.AppendFormat("Nro de Destino: {0}\n", this.nroDestino);
            info.AppendFormat("Nro de Origen: {0}\n\n", this.nroOrigen);

            return info.ToString();
        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int aux;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                aux = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                aux = 2;
            }
            else
            {
                aux = 0;
            }
            return aux;
        }

        

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool iguales = false;
            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino &&
                 l1.NroOrigen == l2.NroOrigen)
            {
                iguales = true;
            }
            return iguales;
        }


        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
    }

    
}
