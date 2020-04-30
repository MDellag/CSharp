using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Equipo
    {
        #region Atributos
        private short         cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string        nombre;
        #endregion

        #region Constructores
        /* Constructores de la Clase*/
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre         = nombre;
        }
        /* -------------------------------------- */
        #endregion


        #region Operadores
            /* Operadores de la Clase */
        public static bool operator +(Equipo e, Jugador j)
        {
            bool success = false;
            if (e.jugadores is null || !e.jugadores.Contains(j))
            {
                if ( e.jugadores.Count < e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                    success = true;
                }
                
            }
            return success;
        }

        public static bool operator -(Equipo e, Jugador j)
        {
            bool success = false;
            if (!e.jugadores.Contains(j) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Remove(j);
                success = true;
            }
            return success;
        }
        /* -------------------------------------- */
        #endregion

    }
}
