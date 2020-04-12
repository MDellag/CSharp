using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;
using Functions;
using System.Drawing.Text;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        //Constantes
        const double defaultCotDolar = 1;
        const double defaultCotEuro = 0.91;
        const double defaultCotPeso = 64.5;

        //Variables
        private bool locked = false;
        private double dolarAmmount;
        private double euroAmmount;
        private double pesoAmmount;

        private double cotizDolar;
        private double cotizPeso;
        private double cotizEuro;
        
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
    
        }

        private void CotizacionMonedas(double dolar, double peso, double euro)
        {
            Euro.SetCotizacion(euro);
            Dolar.SetCotizacion(dolar);
            Pesos.SetCotizacion(peso);
        }
        
        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(txtCotizDolar.Text) && Validacion.validTxtWithNum(txtCotizEuro.Text)
                    && Validacion.validTxtWithNum(txtCotizPeso.Text))
            { 
                if (!locked)
                {
                    btnCotizacion.ImageIndex = 0;
                    txtCotizDolar.Enabled = false;
                    txtCotizEuro.Enabled = false;
                    txtCotizPeso.Enabled = false;
                    locked = true;

                    Double.TryParse(txtCotizDolar.Text, out cotizDolar);
                    Double.TryParse(txtCotizPeso.Text, out cotizPeso);
                    Double.TryParse(txtCotizEuro.Text, out cotizEuro);

                    CotizacionMonedas(cotizDolar, cotizPeso, cotizEuro);
                }
                else if (locked)
                {

                    btnCotizacion.ImageIndex = 1;
                    txtCotizDolar.Enabled = true;
                    txtCotizEuro.Enabled = true;
                    txtCotizPeso.Enabled = true;
                    locked = false;

                    CotizacionMonedas(defaultCotDolar, defaultCotPeso, defaultCotEuro);                    
                }
            }
            else
            {
                MessageBox.Show("Algun casillero esta vacio o contiene informacion invalida");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvPeso_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(txtPesoAmmount.Text))
            {
                double.TryParse(txtPesoAmmount.Text, out pesoAmmount);


                Pesos valorP = pesoAmmount;
                Euro valorE = Dolar.ConvertToDolar(valorP) * Euro.GetCotizacion();
                Dolar valorD = Dolar.ConvertToDolar(valorP);


                StringBuilder outputE = new StringBuilder();
                StringBuilder outputP = new StringBuilder();
                StringBuilder outputD = new StringBuilder();


                if (valorD.GetCantidad() < 0.05)
                    outputD.AppendFormat("u$s{0:#.####}", valorD.GetCantidad());
                
                else
                    outputD.AppendFormat("u$s{0:#.##}", valorD.GetCantidad());

                
                if(valorE.GetCantidad() < 0.05)
                   outputE.AppendFormat("€{0:#.####}", valorE.GetCantidad());

                else
                    outputE.AppendFormat("€{0:#.##}", valorE.GetCantidad());

                outputP.AppendFormat("${0:#.##}", valorP.GetCantidad());
                

                txtPesoToEuro.Text = outputE.ToString();
                txtPesoToPeso.Text = outputP.ToString();
                txtPesoToDolar.Text = outputD.ToString();
            }
            else
            {
                MessageBox.Show("Verifique que el monto sea correcto");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDolarAmmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDolarToEuro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvDolar_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(txtDolarAmmount.Text))
            {
                double.TryParse(txtDolarAmmount.Text, out dolarAmmount);

                Euro valor = dolarAmmount * Euro.GetCotizacion();
                Pesos valorP = dolarAmmount * Pesos.GetCotizacion();
                Dolar valorD = dolarAmmount;


                StringBuilder outputE = new StringBuilder();
                StringBuilder outputP = new StringBuilder();
                StringBuilder outputD = new StringBuilder();

                outputE.AppendFormat("€{0:##.##}", valor.GetCantidad());
                outputP.AppendFormat("${0:##.##}", valorP.GetCantidad());
                outputD.AppendFormat("u$s {0:##.##}", valorD.GetCantidad());

                txtDolarToEuro.Text = outputE.ToString();
                txtDolarToPeso.Text = outputP.ToString();
                txtDolarToDolar.Text = outputD.ToString();
            }
            else
            {
                MessageBox.Show("Verifique que el monto sea correcto");
            }
        }

        private void btnConvEuro_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(txtEuroAmmount.Text))
            {
                double.TryParse(txtEuroAmmount.Text, out euroAmmount);

                Euro valorE = euroAmmount;
                Pesos valorP = Dolar.ConvertToDolar(valorE) * Pesos.GetCotizacion();
                Dolar valorD = Dolar.ConvertToDolar(valorE);

                StringBuilder outputE = new StringBuilder();
                StringBuilder outputP = new StringBuilder();
                StringBuilder outputD = new StringBuilder();

                outputE.AppendFormat("€{0:##.##}", valorE.GetCantidad());
                outputP.AppendFormat("${0:##.##}", valorP.GetCantidad());
                outputD.AppendFormat("u$s {0:##.##}", valorD.GetCantidad());

                txtEuroToEuro.Text = outputE.ToString();
                txtEuroToPeso.Text = outputP.ToString();
                txtEuroToDolar.Text = outputD.ToString();
            }
            else
            {
                MessageBox.Show("Verifique que el monto sea correcto");
            }
        }
    }
}
