using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Herramientas;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace TestParaAplicaciones
{
    class TestConsole
    {
        static void Main(string[] args)
        {

            #region Ejemplo Buscador de Palabras
            //Dictionary<string, int> dic = new Dictionary<string, int>();

            //bool continuar = true;
            //string s, palabra = "";

            //while (continuar)
            //{
            //    //Ingreso de palabra
            //    Console.Write("Ingrese una palabra: ");
            //    palabra = Console.ReadLine();


            //    /* ************************************ */
            //    int i = 0;
            //    bool palab = true;

            //    while (palab)
            //    {

            //        string aux = "";
            //        for (int k = i; k < palabra.Length; k++)
            //        {
            //            if (palabra[k] != ' ')
            //            {
            //                aux += palabra[k];
            //                i = k;
            //            }
            //            else
            //            {
            //                i = k+1;
            //                break;
            //            }
            //        }

            //        if (dic.ContainsKey(aux))
            //            dic[aux]++;

            //        else
            //            dic.Add(aux, 1);

            //        if (i == palabra.Length -1)
            //            palab = false;

            //    }

            //    /* ************************************ */

            //    //Verifica si la Key ya se encuentra
            //    //if (dic.ContainsKey(palabra))
            //    //{
            //    //    dic[palabra]++;
            //    //}
            //    //else
            //    //    dic.Add(palabra, 1);


            //    do
            //    {   //verifica si desea continuar ingresando palabras
            //        Console.Write("\n\nSeguir S/N: ");
            //         s = Console.ReadLine();

            //        if (s == "s")
            //            continuar = true;
            //        else if(s == "d")
            //            continuar = false;

            //    } while (s != "s" && s != "d");
            //}



            ////imprime las palabras
            //foreach (KeyValuePair<string, int> item in dic)
            //{
            //    Console.Write("\n" + item.Key + " " + item.Value);
            //}
            #endregion

            #region Func Lambda
            //Func<double, double> pepe = a => (a * a) / 2;

            //Console.Write(pepe(10));
            #endregion

            #region Listas | Queue | Stack
            //List<int> asd = new List<int>();

            //short cantidad = 4;

            //Queue<int> cola = new Queue<int>();
            ////Stack<int> pila = new Stack<int>();

            //for (int i = 0; i <= cantidad; i++)
            //{
            //    cola.Enqueue(i);
            //}

            //Console.WriteLine(cola.Dequeue());
            //Console.WriteLine(cola.Dequeue());

            //foreach (int item in cola)
            //{
            //    pila.Push(item);
            //}

            //foreach (int item in pila)
            //{
            //    Console.Write($"{item}, ");
            //}
            #endregion

            #region Exceptions
            //try     //InnerException es se produjo una exception y yo le quiero implementar una nueva.
            //{
            //    Console.Write("Ingrese un numero: ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("Ingrese un numero: ");
            //    int j = int.Parse(Console.ReadLine());
            //    int k = a / j;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    // throw;
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            #endregion

            #region test polimorfismo
            //TestBaseClass a = new TestBaseClass(1);
            //Console.WriteLine(a.MandarMsj());

            //TestBaseClass b = new TestDerivedClass("", 2);
            //Console.WriteLine(b.Teach());

            //TestDerivedClass c = new TestDerivedClass("", 2);
            //Console.WriteLine(c.Contar());

            //if (a is TestDerivedClass)
            //{
            //    Console.WriteLine("TestBase1 es TestDerived Class");
            //}
            //if (b is TestDerivedClass)
            //{
            //    Console.WriteLine("TestBase2 es TestDerived Class");
            //}
            //if (c is TestDerivedClass)
            //{
            //    Console.WriteLine("TestDerv es TestDerived Class");
            //}

            //** TESTEO DE POLIMORFISMO CON PERSONA() Y MASCOTA() **//

            //Persona per = new Persona();

            //Mascota perro = new Mascota("Firu", Animal.Especie.Perro);
            //Animal gato = new Mascota("Felix", Animal.Especie.Gato);
            //Mascota huron = new Mascota("Alfajor", Animal.Especie.Huron);


            //per[0] = perro;
            //per[1] = gato;
            //per[2] = huron;

            //Console.WriteLine(per.ToString());
            /* ************************************************* */

            //Dictionary<int, Persona> dic = new Dictionary<int, Persona>();
            //Stack pila = new Stack();

            //Persona persona1 = new Alumno(111, 333);
            //Persona persona2 = new Alumno(222, 444);
            //Persona persona3 = new Alumno(333, 555);

            //dic.Add(persona1.Id, persona1);
            //dic.Add(persona2.Id, persona2);
            //dic.Add(persona3.Id, persona3);

            //foreach (KeyValuePair<int, Persona> per in dic)
            //{
            //    pila.Push(per.Key);
            //}

            //Console.WriteLine(pila.Pop());


            #endregion

            #region Test Implicit | Explicit
            //pp a = new pp();
            //pp b = new pp();
            //TestBaseClass c = new TestBaseClass(3);

            //string strC = (string)c; //Para probar el explicit / implicit

            //Console.WriteLine(a.SchoolYear);
            //Console.WriteLine(pp.ed);
            //Console.WriteLine((string)c);

            //Console.WriteLine(a.ToString());
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(a.Equals(b));
            #endregion

            #region Ficheros
            StreamWriter fichero;

            /* *************** Creacion y Escritura de un fichero ************* */
            //fichero = File.CreateText("Prueba.txt"); //crea el fichero
            //fichero.WriteLine("Prueba WriteLine");
            //fichero.Write("Prueba Write 1 ");
            //fichero.Write("Prueba Write 2\n ");
            //fichero.WriteLine("Prueba WriteLine 2 ");
            //fichero.Close();

            //StreamReader fich;
            //string linea;
            //fich = File.OpenText("Prueba.txt");  // abre el fichero
            //linea = fich.ReadLine();
            //Console.WriteLine(linea); //Lee la primera linea
            //Console.WriteLine(fich.ReadLine()); // Lee la 2da linea
            //Console.WriteLine(fich.ReadLine()); // Lee la 3ra linea
            //fich.Close();

            StreamReader ficher;

            //ficher = File.OpenText("Prueba.txt");
            //string line;

            /* ------------- Formar larga de leer todo el fichero ------------- */
            //do
            //{
            //    line = ficher.ReadLine();
            //    if (line != null)
            //    {
            //        Console.WriteLine(line);
            //    }

            //} while (line != null);
            //ficher.Close();

            /* ------------- Formar corta de leer todo el fichero ------------- */
            //Console.Write(ficher.ReadToEnd());
            //ficher.Close();

            /* -------- Modificacion de un fichero ------------- */

            //fichero = File.AppendText("Prueba.txt");
            //fichero.WriteLine("Probando AppendText");
            //fichero.Close();

            /* ------------- Saber si fichero existe ------------- */
            //string nombreFichero, lin;
            //Console.Write("Ingrese el nombre del fichero: ");
            //nombreFichero = Console.ReadLine();

            //try
            //{
            //    ficher = File.OpenText(nombreFichero);
            //    Console.WriteLine("\n"+ficher.ReadToEnd());
            //    ficher.Close();
            //}
            //catch (Exception exp)
            //{
            //    Console.WriteLine("El Fichero '{0}' no puedo ser abierto \n\nHa habido un error: {1}  ",nombreFichero, exp.Message);
            //    return; //si ponemos esto cierra el programa de 1
            //}


            #endregion

            #region Enviroment
            //string[] drives = Environment.GetLogicalDrives();
            //Console.WriteLine("Unidades Logicas: {0}", String.Join(", ", drives));
            #endregion

            //TestClass a = new TestClass("zzz", TestClass.ESex.Masculino);

            //Console.WriteLine(a.ToString());

            #region Regex
            //string path = "SegundoParcialUtn/XMlTest/Testinregex/Pacientes.xml";
            //string[] words = path.Split('/');
            //string patron = ".xml";

            //string finis = string.Empty;

            //Regex regex = new Regex(patron);

            //MatchCollection match; 

            //foreach (var word in words)
            //{
            //    match = regex.Matches(word);

            //    if (match.Count > 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        finis += word +"/";
            //    }

            //}

            //Console.WriteLine(finis);
            #endregion

            #region Threads test
            TestThreads a = new TestThreads("Jelou");

            #endregion


            Console.ReadKey();
        }



        
}
}
