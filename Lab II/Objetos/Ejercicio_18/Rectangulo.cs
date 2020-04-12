using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {

            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = vertice1;
            this.vertice4 = vertice3;

           /* Esto puede que no sea valido en el Constructor. 
            * En caso de que no lo sea, se puede setear area y perimetro en 0, y hacer la cuenta dentro
            * del metodo Area() y Perimetro() con un Bool flag; que verifique que tengan un valor.
            */
            float bas = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float alt = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

            this.area = bas * alt;
            this.perimetro = bas * alt * 2;

        }


        public float Area()
        { 
            return this.area;
            
        }


        public float Perimetro()
        {            
            return this.perimetro;
        }
    }
}
