using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()

        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set
            {
                if (value > 1)
                {
                    this.cantidadCompetidores = value;
                }
                else
                    this.cantidadCompetidores = 2;
            }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set
            {
                if (value > 0)
                {
                    this.cantidadVueltas = value;
                }
                else
                {
                    this.cantidadVueltas = 1;
                }
            }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
            set { if (i < competidores.Count) this.competidores[i] = value; }
        }

        static Random rnd = new Random();

        //public static bool operator +(Competencia c, VehiculoDeCarrera a)
        //{
        //   // int combustible = rnd.Next(15, 100);
        //    bool succes = false;
        //    if (c.competidores.Count < c.cantidadCompetidores &&
        //        c != a)
        //    {
        //        //c.competidores.Add(a);
        //        //a.EnCompetencia = true;
        //        //a.CantidadCombustible = (short)combustible;
        //        //a.VueltasRestantes = c.cantidadVueltas;
        //        succes = true;
        //    }
        //    return succes;
        //}

        public static Competencia operator +(Competencia c, VehiculoDeCarrera a)
        {
            int combustible = rnd.Next(15, 100);
            //No hizo falta declarar otra clase Competencia = new Competencia();

            if (c.competidores.Count < c.cantidadCompetidores &&
                c != a)
            {
                if (c.Tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(Motocross))
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.CantidadCombustible = (short)combustible;
                    a.VueltasRestantes = c.cantidadVueltas;
                }
                else if (c.Tipo == TipoCompetencia.F1 && a is AutoF1)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.CantidadCombustible = (short)combustible;
                    a.VueltasRestantes = c.cantidadVueltas;
                }
                 
            }

            return c;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {

            bool succes = false;
            if (c == a)
            {
                c.competidores.Remove(a);
                a.EnCompetencia = false;
                succes = true;
            }
            return succes;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            return c.competidores.Contains(a);
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();

            info.Append($"Cantidad de Competidores: {this.cantidadCompetidores}\n");
            info.Append($"Cantidad de Vueltas     : {this.cantidadVueltas}\n\n");

            foreach (VehiculoDeCarrera item in competidores)
            {
                info.Append(item.MostrarDatos());
            }

            return info.ToString();
        }


        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
    }
}
