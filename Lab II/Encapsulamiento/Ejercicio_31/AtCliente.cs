using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATalCliente;

namespace Ejercicio_31
{
    class AtCliente
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_31";
         
            Negocio jumbo = new Negocio("Jumbo");

            Cliente pepito = new Cliente(1, "Pepito");
            Cliente pancha = new Cliente(2, "Pancha");
            Cliente albertita = new Cliente(3, "Albertita");
            Cliente cabezon = new Cliente(4, "Cabezon");
            Cliente tito = new Cliente(5, "Tito");

            jumbo.Clientes = pepito;
            jumbo.Clientes = pancha;
            jumbo.Clientes = albertita;
            jumbo.Clientes = cabezon;
            jumbo.Clientes = tito;



            if (jumbo == pepito)
            {
                Console.WriteLine("Nombre: {0} -- Posicion: {1}", pepito.Nombre, pepito.Numero);
            }
            if (jumbo == pancha)
            {
                Console.WriteLine("Nombre: {0} -- Posicion: {1}", pancha.Nombre, pancha.Numero);
            }
            if (jumbo == albertita)
            {
                Console.WriteLine("Nombre: {0} -- Posicion: {1}", albertita.Nombre, albertita.Numero);
            }
            if (jumbo == cabezon)
            {
                Console.WriteLine("Nombre: {0} -- Posicion: {1}", cabezon.Nombre, cabezon.Numero);
            }
            if (jumbo == tito)
            {
                Console.WriteLine("Nombre: {0} -- Posicion: {1}", tito.Nombre, tito.Numero);
            }
            if (~jumbo)
            {
                Console.WriteLine(jumbo.Clientes.Numero);
            }





            Console.ReadKey();
        }
    }
}
