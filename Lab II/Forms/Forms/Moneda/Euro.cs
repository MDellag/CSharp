using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        //variables
        private double cantidad;
        private static double cotizRespectoDolar;


        #region Constructores
        //Constructor N_1
        static Euro()
        {
            cotizRespectoDolar = 0.91;

        }

        //Constructor N_2
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        

        //Constructor N_3
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Gets
        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static void SetCotizacion(double valor)
        {
            cotizRespectoDolar = valor;
        }
        #endregion

        #region Overloads

        //EURO == DOLAR
        public static bool operator ==(Euro e, Dolar d)
        {
            return d.GetCantidad() == Dolar.ConvertToDolar(e);
        }


        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }



        //EURO == PESOS
        public static bool operator ==(Euro e, Pesos p)
        {
            return Dolar.ConvertToDolar(e) == Dolar.ConvertToDolar(p);
        }


        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }


        //EURO == EURO
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }


        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        #endregion

        #region  Operadores Suma y Resta

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = new Euro( (Dolar.ConvertToDolar(e) + d.GetCantidad()) * Euro.GetCotizacion());
            return aux;
        }


        public static Euro operator +(Euro e, Pesos p)
        {
            Euro aux = new Euro((Dolar.ConvertToDolar(e) + Dolar.ConvertToDolar(p)) * Euro.GetCotizacion());
            return aux;
        }


        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = new Euro((Dolar.ConvertToDolar(e) - d.GetCantidad()) * Euro.GetCotizacion());
            return aux;
        }


        public static Euro operator -(Euro e, Pesos p)
        {
            Euro aux = new Euro((Dolar.ConvertToDolar(e) - Dolar.ConvertToDolar(p)) * Euro.GetCotizacion());
            return aux;
        }

        #endregion

        #region Implicit - Explicit
        /**@Brief Permite crear un nuevo Dolar
         *  EJ: Dolar dls = 100d ;  (100d es un double)
         *  
         *  @Param double d = cantidad de dolares ej 100 dolares
         *  @Return = aux = new Dolar(x);
        */
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }


        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(Dolar.ConvertToDolar(e));
        }


        public static explicit operator Pesos(Euro e)
        {
           return new Pesos(Dolar.ConvertToDolar(e) * Pesos.GetCotizacion());

        }
        #endregion
    }
}
