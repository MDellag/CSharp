using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores
        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
            : base()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }
        #endregion

        /// <summary>
        /// Agrega 2 clases a la Queue clasesDelDia del objeto
        /// Este metodo es llamado en el Constructor de instancia
        /// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                //int valorClase = random.Next(0, 3);
                switch (random.Next(0, 3))
                {
                    case 0: this.clasesDelDia.Enqueue(Universidad.EClases.Programacion); break;
                    case 1: this.clasesDelDia.Enqueue(Universidad.EClases.Laboratorio); break;
                    case 2: this.clasesDelDia.Enqueue(Universidad.EClases.Legislacion); break;
                    case 3: this.clasesDelDia.Enqueue(Universidad.EClases.SPD); break;
                } 
            }
        }


        #region Datos de Profesor
        /// <summary>
        /// Muestra todos los datos del Profesor
        /// tanto datos persona como de profesor
        /// 
        /// Metodo protegido que se hace publico en ToString()
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder inf = new StringBuilder();

            inf.Append(base.MostrarDatos());
            inf.AppendFormat(ParticiparEnClase());

            return inf.ToString();
        }

        /// <summary>
        /// Hace publico todos los datos de Profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

        /// <summary>
        /// Muestra las Clases en las que ensenia el Profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            List<Universidad.EClases> list = clasesDelDia.ToList();
            return string.Format("Clases del dia: {0} - {1}\n\n", list[0], list[1]);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un Profesor y una EClase son iguales si el profesor 
        /// Ensenia esa materia
        /// Retorna Boolean True o False
        /// </summary>
        /// <param name="p"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor p, Universidad.EClases clase)
        {
            bool elProfeEnsenia = false;
            List<Universidad.EClases> aux = p.clasesDelDia.ToList();

            for (int i = 0; i < 2; i++)
            {
                if (aux[i] == clase)
                {
                    elProfeEnsenia = true;
                } 
            }

            return elProfeEnsenia;
        }

        /// <summary>
        /// Negacion del operador ==
        /// Llama al mismo y niega el resultado
        /// </summary>
        /// <param name="p">profesor</param>
        /// <param name="clase">EClases</param>
        /// <returns></returns>
        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            return !(p == clase);
        }
        #endregion
    }
}
