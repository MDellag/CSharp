using Interfaces;
using System;
using System.Threading;

namespace Entidades
{
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
    public class Paquete : IMostrar<Paquete>
    {
        /// <summary>
        /// Estado del paquete
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #region Atributos
        private string direccionEntrega;
        private string trackingID;
        private EEstado estado;

        public delegate void DelegadoPaquete(object objeto, EventArgs e);
        public event DelegadoPaquete InformaEstado;

        public delegate void DelegadoException(string msj);
        public event DelegadoException EventoException;
        #endregion

        #region Propiedades
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public string TrakingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        /// <summary>
        /// Muestra los datos del paquete y si ha sido entregado o en viaje, etc
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete paquete = (Paquete)elemento;
            return string.Format("{0} para {1}", paquete.trackingID, paquete.direccionEntrega);
        }

        /// <summary>
        /// Muestra la informacion del paquete haciendo referencia a this
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Crea un nuevo ciclo del estado del paquete, cada 4 segundos
        /// cambia de estado ingresado a enviaje, y de enviaje a entregado
        /// una vez entregado el paquete se guarda en la base de datos
        /// </summary>
        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        break;
                    
                    
                }
                this.InformaEstado.Invoke(this.estado, EventArgs.Empty);
            }
            try
            {
                PaqueteDao.InsertarPaquete(this);
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                string stacktraceT = string.Empty;

                while (e.InnerException != null)
                {
                    stacktraceT += e.StackTrace.ToString() + "\n\n";
                    e = e.InnerException;
                }
                this.EventoException("Error al insertarPaquete en Base de Datos\n\n" + stacktraceT);
            }
           
        }

        #region Operadores
        /// <summary>
        /// Un paquete sera igual a otro solo si su TrackingID coincide
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool sonIguales = false;

            if (p1.TrakingID == p2.TrakingID)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
