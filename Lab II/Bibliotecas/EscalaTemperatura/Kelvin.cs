using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaTemperatura
{
    public class Kelvin
    {
        private double grados;

       // private static double gradosRespectoFahrenheit;

       public  Kelvin(double grados)
        {
            this.grados = grados;
        }


        public double Grados
        {
            get { return this.grados;  }
        }

        #region Convert To Kelvin
        public static double ConvertToKelvin(Fahrenheit f)
        {
            return (f.Grados + 459.67) * 5 / 9;
        }

        public static double ConvertToKelvin(Celcius c)
        {
            Fahrenheit fahrenheit = Fahrenheit.ConvertToFahrenheit(c);
            return ConvertToKelvin(fahrenheit);
        }
        #endregion

        #region Implicit | Explicit
        public static implicit operator Kelvin(double grados)
        {
            Kelvin _kelvin = new Kelvin(grados);
            return _kelvin;
        }


        #endregion

        #region Suma | Resta

        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k.Grados + ConvertToKelvin(f);
        }

        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k.grados - ConvertToKelvin(f);
        }

        public static double operator +(Kelvin k, Celcius c)
        {
            return k.Grados + ConvertToKelvin(c);
        }

        public static double operator -(Kelvin k, Celcius c)
        {
            return k.Grados - ConvertToKelvin(c);
        }
        #endregion
    }
}
