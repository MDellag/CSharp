using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        //Variables
        private  byte     nota1;
        private  byte     nota2;
        private  float    notaFinal;
        private  string   apellido;
        private  string   nombre;
        private  int      legajo;

        

        //Getters & Setters
        public void setNota1(byte nota1)
        {
            this.nota1 = nota1;
        }

        public byte getNota1()
        {
            return this.nota1;
        }


        public void setNota2(byte nota2)
        {
            this.nota2 = nota2;
        }

        public byte getNota2()
        {
            return this.nota2;
        }


        public void setNotaFinal(float notaFinal)
        {
            this.notaFinal = notaFinal;
        }

        public float getNotaFinal()
        {
            return this.notaFinal;
        }


        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getApellido()
        {
            return this.apellido;
        }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }


        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        public int getLegajo()
        {
            return this.legajo;
        }


        // forma de que el random no ponga siempre el mismo valor
        static Random rnd = new Random();

        //Methods

        public  void CalcularFinal()
        {
           

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                setNotaFinal(rnd.Next(4, 10));
            }else
            {
                setNotaFinal(-1);
            }
        }


        public void Estudiar(byte nota1, byte nota2)
        {
            setNota1(nota1);
            setNota2(nota2);
        }


        public string Mostrar()
        {
            string leyendaAlumno = "";

            if (getNotaFinal() != -1)
            {
                leyendaAlumno = "\n\nLegajo:" + getLegajo().ToString() + "\nApellido: " + getApellido() + "\nNombre: " + getNombre() + 
                                 "\nNota 1: " + getNota1().ToString() + "\nNota 2: "+ getNota2().ToString() + "\nNota Final: " + getNotaFinal().ToString();
            }
            else
            {
                leyendaAlumno = "\n\nLegajo:" + getLegajo().ToString() + "\nApellido: " + getApellido() + "\nNombre: " + getNombre() +
                                 "\nNota 1: " + getNota1().ToString() + "\nNota 2: " + getNota2().ToString() + "\nNota Final: Desaprobado";
            }


            return leyendaAlumno;
        }
    }
}
