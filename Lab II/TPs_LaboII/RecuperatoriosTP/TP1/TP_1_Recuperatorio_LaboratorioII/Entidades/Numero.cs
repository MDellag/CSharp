using System;
using System.Linq;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        //Constructor por defecto.
        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
            : this(numero.ToString())
        {
            
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        /* ------------------------------------ */
        #endregion

        #region Propiedades
        // Propiedad Set de la clase Numero
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        /* ------------------------------------- */
        #endregion


        /// <summary>
        /// Valida que el valor recibido por parametro sea un numero
        /// y lo retornara en formato double, caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public static double ValidarNumero(string strNumero)
        {
            double retorno;

            if (!string.IsNullOrEmpty(strNumero) && Double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Verifica que una cadena string este compuesta de 0 y 1
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool EsBinario(string text)
        {
            bool success = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1')
                {
                    continue;
                }
                else
                {
                    success = false;
                    break;
                }
            }

            return success;
        }


        #region Binario -> Decimal
        /// <summary>
        /// Convierte el nro binario (string) pasado por argumento
        /// a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna el nro convertido en formato string</returns>
        public static string BinarioDecimal(string binario)
        {
            string binarioInvertido = "";
            double numToPow,
                   total = 0;

            if (EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    binarioInvertido += binario.ElementAt<Char>(i);
                }


                for (int i = 0; i < binarioInvertido.Length; i++)
                {
                    double.TryParse(binarioInvertido.ElementAt(i).ToString(), out numToPow);

                    if (numToPow == 1)
                    {
                        numToPow = Math.Pow(2, i);
                        total += numToPow;
                    }
                }

                return total.ToString();
            }
            else
            {
                return "Valor Invalido";
            }


        }
        #endregion



        #region Decimal -> Binario
        /// <summary>
        /// Convierte el nro pasado por argumento (string) a binario.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string strNumero)
        {
            double resultado,
                   output,
                   decim;
            string strBinary = "",
                    strFinal = "";


            if (double.TryParse(strNumero, out decim))
            {
                decim = Math.Abs(decim);
                do
                {
                    if (decim % 2 == 0)
                    {
                        strBinary += "0";
                    }
                    else
                    {
                        strBinary += "1";
                    }

                    output = (decim / 2) - 0.1;
                    resultado = Math.Round(output);
                    decim = Math.Round(output);

                } while (resultado > 0);

                for (int i = strBinary.Length - 1; i >= 0; i--)
                {
                    strFinal += strBinary.ElementAt<Char>(i);
                }
            }
            else
                strFinal = "Valor Invalido";


            return strFinal;
        }



        /// <summary>
        /// Convierte el nro pasado por argumento (double) a binario
        /// </summary>
        /// <param name="decim"></param>
        /// <returns></returns>
        public static string DecimalBinario(double decim)
        {
            return DecimalBinario(decim.ToString());
        }
        #endregion



        #region Operadores
        /// <summary>
        /// Resta num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Suma num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Multiplica num1 por num2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Divide num1 por num2, si num2 es 0 retorna double.minValue()
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
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
