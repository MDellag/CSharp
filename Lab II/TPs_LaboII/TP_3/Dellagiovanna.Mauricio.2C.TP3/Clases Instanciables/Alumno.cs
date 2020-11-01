using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores
        public Alumno()
            :base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Datos del Objeto
        /// <summary>
        /// Metodo Protected
        /// Muestra los datos del objeto Alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder info = new StringBuilder();
             info.Append(base.MostrarDatos());
            info.AppendFormat(ParticiparEnClase());
            info.AppendFormat($"Estado de CUENTA:    {this.estadoCuenta}\n\n");

            return info.ToString();
        }

        /// <summary>
        /// Devuelve un string con la Clase que toma el Alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return String.Format($"CLASE QUE TOMA:   {this.claseQueToma}\n");
        }


        /// <summary>
        /// Hace publico los datos del Objeto ALumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un Alumno es igual a una EClase solo si toma esa clase y 
        /// No es deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool sonIguales = false;
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// Un Alumno es Diferente a una EClase solo si no 
        /// Toma la EClase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            bool noSonIguales = false;
            if (a.claseQueToma != clase)
            {
                noSonIguales = true;
            }
            return noSonIguales;
        }
        #endregion
    }
}
