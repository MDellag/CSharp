using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    #pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    public class Jornada
    {
        #region Atributos
        private Universidad.EClases clase;
        private List<Alumno> alumnos;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        #endregion

        #region Constructores
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            Clase = clase;
            Instructor = instructor;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Una Jornada es Igual a un Alumno si este Ya esta en la Jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>true or false</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool participa = false;
            foreach ( Alumno alumn in j.Alumnos)
            {
                if (alumn == a)
                {
                    participa = true;
                    break;
                }
            }
            return participa;
        }

        /// <summary>
        /// Negacion del Operador IGUAL entre Jornada y Alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>true or false</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un ALumno a la Jornada si este aun no esta.
        /// Si se encuentra en esta, se lanza la Expcetion AlumnoRepetido
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>objeto Jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.Alumnos.Add(a);
            
            else
                throw new AlumnoRepetidoException();

            return j;
        }
        #endregion

        /// <summary>
        /// Hace publico los datos de la Jornada
        /// Mostrando el Profesor, la clase dada
        /// Y los alumnos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append("\nJORNADA: \n");
            info.AppendFormat($"CLASE:\t{this.Clase}\n");
            info.AppendFormat($"DATOS DEL PROFESOR:\t\n{this.Instructor}\n\n");
            info.Append("ALUMNOS DE LA CLASE: \n");
            foreach (Alumno alumn in this.Alumnos)
            {
                info.Append(alumn.ToString() + "\n");
            }

            info.Append(">----------------------------------------< \n");
            return info.ToString();
        }

        #region Guardar y Leer
        /// <summary>
        /// Guarda en un archivo .txt los datos de la Jornada
        /// En el directorio actual con el nombre Jornada.txt
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();
            return  text.Guardar(Environment.CurrentDirectory + "\\Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Lee el archivo del directorio actual Jornada.txt
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string texto = string.Empty;

            try
            {
                Texto read = new Texto();
                read.Leer(Environment.CurrentDirectory + "\\Jornada.txt", out texto);
                
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }

            return texto;   
        }
        #endregion
    }
}
