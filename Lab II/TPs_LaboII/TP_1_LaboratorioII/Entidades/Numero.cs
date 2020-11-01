using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores
        //Constructor por defecto.
        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion


        /**@Brief: Valida que el valor recibido sea numero, y lo retorna
         *         en formato double.
         * @Param: string strNumero: valor al evaluar.
         * @return: 
         */
        public static double ValidarNumero(string strNumero)
         {
            double retorno;

            if (strNumero != String.Empty && Double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            else{
                return 0;
            }
         }


        /**@Brief: Asigna un valor al atributo numero, previa validacion.
         * @param: void
         * @return void.
         */ 
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #region Operadores
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;
            
            else
                return num1.numero / num2.numero;
        }
#endregion
    }
}
