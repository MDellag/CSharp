using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {

        const short cantidadTintaMaxima = 100;

        ConsoleColor color;

        short tinta;

        //Constructor
        public Boligrafo(short tinta, ConsoleColor color)
        {
            SetTinta(tinta);
            this.color = color;
           // Console.ForegroundColor = color;
        }


        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }


        public void SetTinta(short tinta)
        {
            if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima && tinta >= 0 && tinta <= 100)
            {
                this.tinta += tinta;
            }
            else if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima && tinta <= 0)
            {
                this.tinta -= tinta;
            }
        }


        /**@Brief recarga la tinta a su maxima Cantidad (100)
         */ 
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }



        /**@Brief Pinta (?
         * @Param gasto = numero que representa cuanto gasto de tinta
         *        out dibujo = retorna en alguna variable de tipo String lo que dibujo
         * @Return success = true: si pudo pintar
         *                 = false: si no pudo pintar
         */
        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = "";

            Console.ForegroundColor = this.color;
            if (GetTinta() - gasto >= 0)
            {
                SetTinta(gasto);
                dibujo = String.Concat(Enumerable.Repeat("*", gasto));
                
                pudoPintar = true;
            }
            else if(GetTinta() > 0)
            { 
                dibujo = String.Concat(Enumerable.Repeat("*", GetTinta()));
                SetTinta(0);
                pudoPintar = true;
            }


            return pudoPintar;
        }
    }
}
