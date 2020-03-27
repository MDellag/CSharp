using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {   
        /**@Brief: Convierte el Nro pasado por argumento a binario
         * @Param: 'decim' = 242
         * @Return: el numero ya convertido.
         */
        public static string DecimalBinario(double decim)
        {
            double resultado;
            string strBinary = "",
                    strFinal = "";

            do{
                if (decim % 2 == 0)
                {
                    strBinary += "0";
                }
                else{
                    strBinary += "1";
                }

                resultado = decim / 2;
                resultado = Math.Round(resultado);
                decim = decim / 2;
                decim = Math.Round(decim);

            } while (resultado >= 1);
            
            for (int i = strBinary.Length-1; i >= 0; i--)
            {
                strFinal += strBinary.ElementAt<Char>(i);
            }

            return strFinal;
        }



        /**@Brief: Convierte el Nro Binario pasado por argumento a Decimal
         * @Param: 'binario' = 1010111
         * @Return: el numero ya convertido a Decimal.
         */
        public static double BinarioDecimal(string binario)
        {
            string binarioInvertido = "";
            double numToPow,
                   total = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                binarioInvertido += binario.ElementAt<Char>(i);
            }


            for (int i = 0; i < binarioInvertido.Length; i++)
            {
                double.TryParse(binarioInvertido.ElementAt(i).ToString(), out numToPow);

               // Console.WriteLine(numToPow);
                if (numToPow == 1)
                {
                    numToPow =  Math.Pow(2, i);
                    total += numToPow;
                }
            }


            return total;
        }
    }
}
