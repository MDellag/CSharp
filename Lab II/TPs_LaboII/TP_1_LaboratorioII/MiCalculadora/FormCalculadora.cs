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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);

            double resultado = Calculadora.Operar(num1, num2, cmbOperador.Text);

            lblResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (Validacion.validTxtWithNum(lblResultado.Text))
            {
                double resultado = double.Parse(lblResultado.Text);
               
                lblResultado.Text = Conversor.DecimalBinario(resultado);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (Validacion.isBinary(lblResultado.Text) && Validacion.txtNotEmpty(lblResultado.Text))
            {
                lblResultado.Text = Conversor.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
        }
    }
}
