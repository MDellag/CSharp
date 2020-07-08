using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_67
{
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo;

        public bool Activo
        {
            get {
                return !(this.hilo is null) && this.hilo.IsAlive;
            }

            set
            {
                if (!(this.hilo is null) && value == false && this.hilo.IsAlive )
                {
                    hilo.Abort();
                }
                else if ((this.hilo is null || !this.hilo.IsAlive) && value == true)
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
            }
        }

        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }



        private void Corriendo()
        {
            while(true)
            {
                
                if (this.EventoTiempo != null)
                {
                    Thread.Sleep(this.intervalo);
                    this.EventoTiempo.Invoke();
                }
            }
        }

       
    }
}
