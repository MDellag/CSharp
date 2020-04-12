using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        //variables
        private double cantidad;
        private static double cotizRespectoDolar;


        #region Constructores


        //Constructor N_1
        static Pesos()
        {
            cotizRespectoDolar = 64.50;
        }

        //Constructor N_2
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }


        //Constructor N_3
        public Pesos(double cantidad, double cotizacion)
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
        #endregion

        #region Overloads

        //PESOS == DOLAR
        public static bool operator ==(Pesos p, Dolar d)
        {
            return d.GetCantidad() == Dolar.ConvertToDolar(p);
        }


        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }


        // PESOS == EURO
        public static bool operator ==(Pesos p, Euro e)
        {
            return Dolar.ConvertToDolar(p) == Dolar.ConvertToDolar(e);
        }


        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }


        //PESOS == PESOS
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }


        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Operadores Suma - Resta
       

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos((Dolar.ConvertToDolar(p) + d.GetCantidad()) * Pesos.GetCotizacion());
            return aux;
        }


        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos aux = new Pesos((Dolar.ConvertToDolar(e) + Dolar.ConvertToDolar(p)) * Pesos.GetCotizacion());
            return aux;
        }


        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos((Dolar.ConvertToDolar(p) - d.GetCantidad()) * Pesos.GetCotizacion());
            return aux;
        }


        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos aux = new Pesos((Dolar.ConvertToDolar(p) - Dolar.ConvertToDolar(e)) * Pesos.GetCotizacion());
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
        public static implicit operator Pesos(double d)
        {
            Pesos aux = new Pesos(d);
            return aux;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar aux = new Dolar(Dolar.ConvertToDolar(p));
            return aux;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro aux = new Euro(Dolar.ConvertToDolar(p) * Euro.GetCotizacion());
            return aux;
        }
        #endregion
    }
}
