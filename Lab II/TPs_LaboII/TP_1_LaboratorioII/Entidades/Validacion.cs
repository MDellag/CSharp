using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validacion
    {

        /**@Brief: Verifica que un objeto.Text No este vacio y 
         *          sea un numero
         * @Param: string text
         * @return true si no esta vacio y es un num
         *         false: si no se cumple alguna de las 2 condiciones
         */
        public static bool validTxtWithNum(string text)
        {
            double dbNaN;
            bool success = false;
            bool nan = double.TryParse(text, out dbNaN);

            if (text != String.Empty && nan)
            {
                success = true;
            }

            return success;
        }



        /**@Brief: Verifica que un objeto.Text No este vacio
         * @Param: string text
         * @return true si no esta vacio
         *         false: si no se cumple la conmdicion
         */
        public static bool txtNotEmpty(string text)
        {
            bool success = false;

            if (text != string.Empty)
            {
                success = true;
            }

            return success;
        }

        /**@Brief: Verifica que una cadena string sea binaria
         * @Param: string text
         * @return true: si es binaria
         *         false: si no lo es
         */
        public static bool isBinary(string text)
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


    }
}
