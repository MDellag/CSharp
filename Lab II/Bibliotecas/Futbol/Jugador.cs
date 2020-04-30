using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Jugador:Persona
    {
        #region Atributos
        private int    partidosJugados;
        private int    totalGoles;
        #endregion


        #region Constructores
        /* Constructores de la CLase Jugador */
       
        public Jugador(long dni, string nombre)
            :base(dni, nombre)
        {
            totalGoles = 0;
            partidosJugados = 0;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : base(dni, nombre)
        {
                 this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        /* -------------------------------------- */
        #endregion

        #region Propiedades
            /* Propiedades de la Clase Jugador 
             * Cuenta con 3 Propiedades de Lectura PartidosJugados;
             *                                     PromedioGoles;
             *                                     Total Goles;
             */
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }
        
        public float PromedioGoles
        {
            get
            {
                if (partidosJugados > 0)
                {
                    return (float)totalGoles / (float)partidosJugados;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        //public int Dni
        //{
        //    get { return this.dni; }
        //    set { this.dni = value; }
        //}
                                                    //Esto era del ej 29 y ya no hace falta
        //public string Nombre
        //{
        //    get { return base.Nombre; }
        //    set { this.Nombre = value; }
        //}
        /* -------------------------------------- */
        #endregion



        public string MostrarDatos()
        {
            StringBuilder datosJugador = new StringBuilder();

            datosJugador.Append($"Nombre:  --------------->  {this.Nombre}\n");
            datosJugador.Append($"Dni:     --------------->  {this.Dni}\n");
            datosJugador.Append($"Partidos Jugados: ------>  {this.PartidosJugados}\n");
            datosJugador.Append($"Total de Goles: -------->  {this.TotalGoles}\n");
            datosJugador.Append($"Promedio de Goles: ----->  {this.PromedioGoles.ToString("F2")}");

            return datosJugador.ToString();
        }



        #region Operators
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
