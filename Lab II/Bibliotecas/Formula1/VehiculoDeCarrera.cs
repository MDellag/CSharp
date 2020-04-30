using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        

        public short Numero
        {
            get { return this.numero; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();

            string enCarrera;
            if (enCompetencia)
                enCarrera = "SI";
            else
                enCarrera = "NO";

            info.Append($"Nro Vehiculo:   {this.numero}\n");
            info.Append($"Escudo:         {this.escuderia}\n");
            info.Append($"Combustible:    {this.cantidadCombustible}\n");
            info.Append($"En Carrera:     {enCarrera}\n");
            info.Append($"Vueltas Rest:   {this.vueltasRestantes}\n");

            return info.ToString();
        }


        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool success = false;

            if (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
            {
                success = true;
            }
            return success;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
