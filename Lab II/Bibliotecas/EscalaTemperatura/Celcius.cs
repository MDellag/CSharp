using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaTemperatura
{
    public class Celcius
    {
        private double grados;

        #region Constructor
        public Celcius(double grados)
        {
            this.grados = grados;
        }
        #endregion

        #region Gets - Sets
        public double Grados
        {
            get { return this.grados; }
        }
        #endregion

        #region Implicit
        public static implicit operator Celcius(double grados)
        {
            Celcius _celcius = new Celcius(grados);
            return _celcius;
        }
        #endregion

        #region Convertidor Celcius
        public static double ConvertToCelcius(Fahrenheit f)
        {
            double _toCelcius =  (f.Grados - 32) * 5 / 9 ; 
            return _toCelcius;
        }

        public static double ConvertToCelcius(Kelvin k)
        {
            Fahrenheit kelv = Fahrenheit.ConvertToFahrenheit(k);
            return ConvertToCelcius(kelv);
        }
        #endregion

        #region Suma | Resta
        public static double operator +(Celcius c, Fahrenheit f)
        {
            return c.grados + ConvertToCelcius(f);
        }

        public static double operator -(Celcius c, Fahrenheit f)
        {
            return c.grados - ConvertToCelcius(f);
        }

        public static double operator +(Celcius c, Kelvin k)
        {
            return c.grados + ConvertToCelcius(k);
        }

        public static double operator -(Celcius c, Kelvin k)
        {
            return c.grados - ConvertToCelcius(k);
        }
        #endregion
    }
}
