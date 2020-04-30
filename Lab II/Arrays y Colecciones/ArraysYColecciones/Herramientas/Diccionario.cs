using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Diccionario
    {
        /**@Brief: retorna una palabra de un texto
         * @Param string texto a recorrer
         */ 
        public static string RetornarPalabras(string texto)
        {
            string aux = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    aux += texto[i];
                }
                if (i < texto.Length-1 && texto[i+1] == ' ')
                {
                    aux += "\n";
                }
            }
            return aux;
        }

        public static string RetornarPalabra(string texto)
        {
            string aux = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    aux += texto[i];
                }
                else
                    break;
            }
            return aux;
        }

        /**@Brief: Cuenta palabras a partir del texto dado.
         * @Param: string texto a recorrer.
         * @Return: cantidad de palabras encontradas.
         */ 
        public static int ContadorDePalabras(string texto)
        {
            string a = texto;
            //string b;
            int contador = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == ' ')
                {
                    contador++;
                }
                if (i == a.Length - 1)
                {
                    contador++;
                }

            }
            return contador;
        }



        /**@Brief: Agrega palabras a un diccionario <string int> Si la palabra ya existe, cuenta
         *          la cantidad encontrada
         * @Param: string texto a recorrer. Dictionary<string int> diccionario a agregar las palabras
         * @Return: void
         */
        public static void AgregarYContarPalabras(Dictionary<string, int> dic, string texto)
        {
            int i = 0;
            bool palabraEncontrada = true;

            while (palabraEncontrada)
            {

                string aux = "";
                for (int k = i; k < texto.Length; k++)
                {
                    if (texto[k] != ' ')
                    {
                        aux += texto[k];
                        i = k;
                    }
                    else 
                    {
                        if (k <= texto.Length - 2)
                        {
                            i = k + 1;
                        }
                        else
                            i = k;
                        break;
                    }
                    
                }

                if (dic.ContainsKey(aux))
                    dic[aux]++;

                else
                    dic.Add(aux, 1);

                if (i == texto.Length - 1)
                    palabraEncontrada = false;

            }
        }


        /**@Brief: Crea un string con la informacion de los Key and Values de un Dictionary<string int>
         * @Param: Dictionary a evaluar
         * @Return: string con todos los datos encontrados
         */
        public static string InfoDiccionario(Dictionary<string, int> dic)
        {
            StringBuilder strTexto = new StringBuilder();

            foreach (KeyValuePair<string, int> item in dic)
            {
                strTexto.AppendFormat($"Key: {item.Key}  Value: {item.Value}\n");
            }

            return strTexto.ToString();
        }



        public static Dictionary<string, int> OrdenarDictionaryByValue(Dictionary<string, int> dic)
        {
            Dictionary<string, int> aux = new Dictionary<string, int>();

            foreach (var item in dic.OrderByDescending(key => key.Value))
            {
                aux.Add(item.Key, item.Value);
            }

            return aux;
        }
    }
}
