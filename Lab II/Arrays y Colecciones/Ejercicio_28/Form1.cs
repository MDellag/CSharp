using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Herramientas;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        //int contadorPalabras = 0;
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

         
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Va agregando palabras al diccionario e incrementado el valor de las veces que aparece
            // a medida que recorre el texto
            Diccionario.AgregarYContarPalabras(dic, rTxtDictionary.Text);

            //Otro diccionario
           // Dictionary<string, int> a = Diccionario.OrdenarDictionaryByValue(dic);

            StringBuilder strTexto = new StringBuilder();
            int top3 = 0;

            foreach (KeyValuePair<string , int> item in Diccionario.OrdenarDictionaryByValue(dic))
            {
                if (top3 < 3)
                {
                    strTexto.AppendFormat($"Palabra: {item.Key} - Valor: {item.Value}\n");
                    top3++;
                }
                else
                    break;
            }

            MessageBox.Show(strTexto.ToString());

            dic.Clear();
        }
    }
}
