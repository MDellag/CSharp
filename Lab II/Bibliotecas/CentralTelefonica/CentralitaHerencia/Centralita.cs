using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            razonSocial = nombreEmpresa;
        }

        #region Gets
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincia
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        #endregion


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;


            //Recordar este tipo de condicion por si hay que usarlo en un futuro no muy lejano
            foreach (Llamada item in this.listaDeLlamadas)
            {
                if ((Llamada.TipoLlamada.Local == tipo || tipo == Llamada.TipoLlamada.Todas) && item is Local)
                {
                    ganancia += ((Local)item).CostoLlamada;
                }
                if ((Llamada.TipoLlamada.Provincial == tipo || tipo == Llamada.TipoLlamada.Todas) && item is Provincial)
                {
                    ganancia += ((Provincial)item).CostoLlamada;
                }
            }
            return ganancia;
        }


        //public string Mostrar()
        //{
        //    StringBuilder info = new StringBuilder();

        //    info.AppendFormat($"Razon Social: {this.razonSocial}\n");
        //    info.AppendFormat($"Ganancia Total: {this.GananciasPorTotal}\n");
        //    info.AppendFormat($"Ganancia Provincial: {this.GananciasPorProvincia}\n");
        //    info.AppendFormat($"Ganancia por Locales: {this.GananciasPorLocal}\n\n");
        //    info.AppendFormat($"--- Registro Llamada --- \n ");

        //    return info.ToString();
        //}

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat($"--------Central -------------\n");
            info.AppendFormat($"Razon Social: {this.razonSocial}\n");
            info.AppendFormat($"Ganancia Total: {this.GananciasPorTotal}\n");
            info.AppendFormat($"Ganancia Provincial: {this.GananciasPorProvincia}\n");
            info.AppendFormat($"Ganancia por Locales: {this.GananciasPorLocal}\n\n");
            info.AppendFormat($"--- Registro Llamadas --- \n ");

            foreach (Llamada item in Llamadas)
            {
                info.AppendFormat($"{item}"); //Si no anda poner item.tostring()
            }

            return info.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool contiene = false;

            foreach (Llamada item in c.Llamadas)
            {
                if (item == l)
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            Centralita aux = new Centralita();
            if (c != l)
            {
                c.AgregarLlamada(l);
                aux = c;
            }
            return aux;
        }
    }
}
