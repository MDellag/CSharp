using CorreoException;
using Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        /// <summary>
        /// Agrega un paquete al correo si este aun no esta en el
        /// crea un thread en caso de que el paqute no este en el correo.
        /// lo agrega a la lsita de threads mockPaquetes y lo inicializa
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            if (c != null && !(p is null))
            {
                bool contiene = false;
                foreach (Paquete paquet in c.Paquetes)
                {
                    if (paquet == p)
                    {
                        contiene = true;
                        break;
                    }
                }

                if (!contiene)
                {
                    c.Paquetes.Add(p);
                    Thread threadPaquete = new Thread(p.MockCicloDeVida);
                    threadPaquete.Start();
                    c.mockPaquetes.Add(threadPaquete);
                }
                else
                    throw new TrackingIdRepetidoException("Tracking id ya registrado en el correo.");

            }
            return c;
        }

        /// <summary>
        /// Muestra todos los datos de los paquetes
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            Correo courier = (Correo)elementos;
            StringBuilder info = new StringBuilder();
            foreach (Paquete item in courier.Paquetes)
            {
                info.AppendFormat(item.ToString() + " ({0})\n", item.Estado.ToString());
            }

            return info.ToString();
        }

        /// <summary>
        /// Cierra todos los hilos si estan abiertos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                if (hilo != null && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }


    }
}
