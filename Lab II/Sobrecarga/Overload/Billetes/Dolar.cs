using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        //variables
        private double cantidad;
        private static double cotizRespectoDolar;


        #region Constructores
        //Constructor N_1
        static Dolar()
        {
            cotizRespectoDolar = 1;
            
        }

        //Constructor N_2
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }


        //Constructor N_3
        public Dolar(double cantidad, double cotizacion)
            :this(cantidad)
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

        #region ConvertToDolar
        //Metodo estatico sobrecargado para convertir moneda a dolar.
        public static double ConvertToDolar(Euro e)
        {
            double euroToDolar = e.GetCantidad() / Euro.GetCotizacion();
            return euroToDolar;
        }

        public static double ConvertToDolar(Pesos p)
        {
            double pesosToDolar = p.GetCantidad() / Pesos.GetCotizacion();
            return pesosToDolar;
        }
#endregion

        #region Overload
        //Overload Operators

        //DOLAR == EURO
        public static bool operator ==(Dolar d, Euro e)
        { 
            return d.cantidad == ConvertToDolar(e);
        }


        public static bool operator !=(Dolar d, Euro e)
        {   
            return !(d == e);
        }


        // DOLAR == DOLAR
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad() ;
        }


        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }


        // DOLAR == PESOS
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.GetCantidad() == ConvertToDolar(p); 
        }


        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
#endregion

        #region Suma - Resta
        // Operadores Suma y Resta

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.GetCantidad() + ConvertToDolar(e));
            return aux;
        }


        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.GetCantidad() + ConvertToDolar(p));
            return aux;
        }


        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.GetCantidad() - ConvertToDolar(e));
            return aux;
        }


        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.GetCantidad() - ConvertToDolar(p));
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
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }


        public static explicit operator Pesos(Dolar d)
        {
            Pesos aux = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return aux;
        }


        public static explicit operator Euro(Dolar d)
        {
            Euro aux = new Euro(d.GetCantidad() * Euro.GetCotizacion());
            return aux;
        }
#endregion
    }
}
