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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Mauricio Dellagiovanna del Curso 2°C";
            
            InitializeComponent();
        }


        /// <summary>
        /// Limpia los textBox Label y ComboBox del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }


        /// <summary>
        /// Realiza una operacion acorde a los 2 numeros pasado por argumento
        /// y el operador 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

           return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Llama al metodo Operar y asigna el valor devuelto por dicho metodo a
        /// la propiedad text del label (lblResultado)
        /// 
        /// Si algun textBox esta vacio o tiene una letra en lugar de numeros,
        /// Este se seteara automaticamente en 0, en la propiedad SetNumero de la clase
        /// Numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            lblResultado.Text = resultado.ToString();
        }


        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Convierte el resultado en caso de existir y ser valido, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            }
        }


        /// <summary>
        /// Convierte el resultado en caso de existir y ser valido, a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }
    }
}
