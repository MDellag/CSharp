using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscalaTemperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_21";

            Fahrenheit _fahrenheit = 78d;
            Celcius _celcius = 23d;
            Kelvin _kelvin = 517d;

            double valorCel = _celcius + _fahrenheit,
                   valorFahr = _fahrenheit + _kelvin,
                   valorKel = _kelvin - _celcius;

            StringBuilder operations = new StringBuilder();

            operations.AppendFormat("\n\nSuma Celcius + Fahrenheit: {0:##.##}°C ", valorCel);
            operations.AppendFormat("\n\nSuma Fahrenheit + Kelvin: {0:##.##}°F ", valorFahr);
            operations.AppendFormat("\n\nResta Kelvin - Celcius: {0:##.##}°K ", valorKel);

            Console.WriteLine("\nFahrenheit: {0}° \nCelcius: {1}° \nKelvin: {2}°",_fahrenheit.Grados, _celcius.Grados, _kelvin.Grados);

            Console.Write(operations.ToString());
            Console.ReadKey();
        }
    }
}
