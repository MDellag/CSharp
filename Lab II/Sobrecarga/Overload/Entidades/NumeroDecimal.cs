using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;


        private NumeroDecimal(double num)
        {
            numero = num;
        }

        #region prohibido usar
        //public double Numero
        //{
        //    get { return this.numero; }
        //}
        #endregion

        #region Operators + | - | == | !=
            /**@brief: Suma con resultado double 2 objetos. 1 tipo Num Decimal
             *          y el otro tipo Num BInario
             * @Param: Numero decimal: nd
             *         Num Binario nb
             * @Return: retorna un double con la suma de ambos. 
             */ 
        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            string binary = (string)nb;
            double decim = nd.numero + Conversor.BinarioDecimal(binary);
            return decim;
        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            double decim = nd.numero - Conversor.BinarioDecimal((string) nb);
            return decim;
        }


            /**@brief: Compara que ambos numeros Decimal - Binario sean el mismo
             * @Param: Numero decimal: nd
             *         Num Binario nb
             * @Return: True si son iguales
             *          false si no lo son.
             */
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.numero == Conversor.BinarioDecimal((string)nb);
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }
        #endregion

        #region implicit - explicit
            /**@brief: Permite declararlo como variable y asignarle un valor sin tener que usar el New
             * @Param: Double numero
             * @Return: un objeto creado con el valor asignado. 
             */
        public static implicit operator NumeroDecimal(double numero)
        {
            NumeroDecimal aux = new NumeroDecimal(numero);
            return aux;
        }

        public static explicit operator double(NumeroDecimal nd)
        {
            return nd.numero;
        }
        #endregion
    }
}
