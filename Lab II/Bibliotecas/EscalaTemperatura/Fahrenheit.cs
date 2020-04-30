using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaTemperatura
{
    public class Fahrenheit
    {

        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        #region Get - Set
        public double Grados
        {
            get { return this.grados; }
        }
        #endregion

        #region Convertidor a Fahrenheit
        public static double ConvertToFahrenheit(Kelvin k)
        {
            double toFahrenheit = (k.Grados *  9/5) - 459.67;
            return toFahrenheit;
        }

        public static double ConvertToFahrenheit(Celcius c)
        {
            double toFahrenheit= (c.Grados * 9/5) + 32;
            return toFahrenheit;
        }
        #endregion

        #region Implicit 
        public static implicit operator Fahrenheit(double grados)
        {
            Fahrenheit _fahrenheit = new Fahrenheit(grados);
            return _fahrenheit;
        }
        #endregion

        #region Suma | Resta

        public static double operator +(Fahrenheit f, Celcius c)
        {
            return f.grados + ConvertToFahrenheit(c);
        }

        public static double operator -(Fahrenheit f, Celcius c)
        {
            return f.grados - ConvertToFahrenheit(c);
        }

        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f.grados + ConvertToFahrenheit(k);
        }

        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f.grados - ConvertToFahrenheit(k);
        }
        #endregion

    }
}
