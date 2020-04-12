using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Functions;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertBinary_Click(object sender, EventArgs e)
        {
            if (Validacion.txtNotEmpty(txtBinarioToDecimal.Text) && Validacion.isBinary(txtBinarioToDecimal.Text))
            {
                txtConvertedToDecimal.Text = Conversor.BinarioDecimal(txtBinarioToDecimal.Text).ToString();
            }
            else
                MessageBox.Show("El valor ingresado no es Binario");
        }

        private void btnConvertDecimal_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(txtDecimalToBinario.Text))
            {
                double decim = double.Parse(txtDecimalToBinario.Text);
                txtConvertedToBinary.Text = Conversor.DecimalBinario(decim);
            }
            else
                MessageBox.Show("El valor ingresado no es Decimal");
        }
    }
}
