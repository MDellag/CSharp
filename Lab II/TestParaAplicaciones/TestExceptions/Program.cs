using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exceptions Basico
            //Ejemplo de Exceptions basico
            int num1, num2, resultado;


            //Programa donde se ingresan 2 numeros por partes, si el 1ro es diferente de numero,
            // se lanza la excepcion FormatException, y continua el programa y pide el 2do numero
            // si el numero es 0 o una letra lanza exception
            //try
            //{
            //    Console.Write("Digite un numero: ");
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("\n\nDigite otro numero: ");
            //    num2 = Convert.ToInt32(Console.ReadLine());

            //    resultado = num1 / num2;
            //    Console.Write("\n\nSu division es: {0}", resultado);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("\nNo es un numero valido");
            //    // throw;   //Este throw hace q se muestre el error en el ide
            //    try
            //    {
            //        Console.Write("\n\nDigite otro numero: ");
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        num1 = 0;
            //        resultado = num1 / num2;
            //        Console.Write("\n\nSu division es: {0}", resultado);
            //    }
            //    catch (DivideByZeroException)
            //    {

            //        Console.WriteLine("\nNo es posible dividir por 0");
            //    }
            //    catch(FormatException)
            //    {
            //        Console.WriteLine("\nOtra vez ingresaste algo que no es un numero PELOTUDO!");
            //    }

            //}

            #endregion

            #region innerException
            string stacktraceT = string.Empty;
            Aizencito a1 = new Aizencito("Carita", 100);
            Aizencito a2 = new Aizencito("Cara", 100);

            try
            {
                //bool a = a1 == a2;
                //Console.WriteLine(a);
                Aizencito.AizenMasAizen(a1, a2);
                Console.WriteLine("all ok");
            }
            catch (Exception e)
            {
                while (e.InnerException != null)
                {
                    stacktraceT += e.StackTrace.ToString() + "\n";
                    e = e.InnerException;
                }
                Console.WriteLine(stacktraceT);
                Console.WriteLine(e.Message);
            }

            #endregion


            Console.ReadKey();
        }
    }
}
