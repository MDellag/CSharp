using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {

        private string numero;


        private NumeroBinario(string num)
        {
            numero = num;
        }

        #region Prohibido Usar
        //public string Numero
        //{
        //    get { return this.numero; }
        //}
        #endregion


        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double decim =((double) nd) + Conversor.BinarioDecimal(nb.numero);
            return  Conversor.DecimalBinario(decim);           
        }

        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double decim = ((double)nd) - Conversor.BinarioDecimal(nb.numero);

            return Conversor.DecimalBinario(decim);
        }


        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return nb.numero == Conversor.DecimalBinario((double)nd);
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        #region Implicit - Explicit
        public static implicit operator NumeroBinario(string numero)
        {
            NumeroBinario aux = new NumeroBinario(numero);
            return aux;
        }

        public static explicit operator string(NumeroBinario num)
        {
            return num.numero;
        }
        #endregion

    }
}
