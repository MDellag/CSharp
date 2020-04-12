using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
using EscalaTemperatura;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        

        private void btnConvCelcius_Click(object sender, EventArgs e)
        {
            double _celcius;

            if (Validacion.validTxtWithNum(txtCelcius.Text))
            {
                _celcius = double.Parse(txtCelcius.Text);
                Celcius temperature = _celcius;
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("{0:#.##}°C", _celcius);
                txtCelciusToCelcius.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°F", Fahrenheit.ConvertToFahrenheit(temperature));
                txtCelciusToFahrenheit.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°K", Kelvin.ConvertToKelvin(temperature));
                txtCelciusToKelvin.Text = cadena.ToString();
            }
            else
                MessageBox.Show("El campo esta vacio o contiene un valor incorrecto");     

        }

        private void btnConvFahrenheit_Click(object sender, EventArgs e)
        {
            double _Fahrenheit;

            if (Validacion.validTxtWithNum(txtFahrenheit.Text))
            {
                _Fahrenheit = double.Parse(txtFahrenheit.Text);
                Fahrenheit temperature = _Fahrenheit;
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("{0:#.##}°C", Celcius.ConvertToCelcius(temperature));
                txtFahrenheitToCelcius.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°F", _Fahrenheit);
                txtFahrenheitToFahrenheit.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°K", Kelvin.ConvertToKelvin(temperature));
                txtFahrenheitToKelvin.Text = cadena.ToString();
            }
            else
                MessageBox.Show("El campo esta vacio o contiene un valor incorrecto");
        }

        

        private void btnConvKelvin_Click(object sender, EventArgs e)
        {
            double _Kelvin;

            if (Validacion.validTxtWithNum(txtKelvin.Text))
            {
                _Kelvin = double.Parse(txtKelvin.Text);
                Kelvin temperature = _Kelvin;
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("{0:#.##}°C", Celcius.ConvertToCelcius(temperature));
                txtKelvinToCelcius.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°F", Fahrenheit.ConvertToFahrenheit(temperature));
                txtKelvinToFahrenheit.Text = cadena.ToString();
                cadena.Clear();

                cadena.AppendFormat("{0:#.##}°K", _Kelvin);
                txtKelvinToKelvin.Text = cadena.ToString();
            }
            else
                MessageBox.Show("El campo esta vacio o contiene un valor incorrecto");
        }
    }
}
