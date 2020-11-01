using Archivos;
using ClasesAbstractas;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Jornada> Jornada
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public Jornada this[int i]
        {
            get { return Jornada[i]; }
            set { Jornada[i] = value; }
        }
        #endregion
        
        /// <summary>
        /// Unico Constructor de la clase Universidad
        /// Es 'PorDefecto'
        /// </summary>
        /// 
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }

        #region Datos de la Clase
        /// <summary>
        /// Muestra todos los datos de la universidad
        ///  -Jornada
        ///  -Profesores
        ///  -Alumnos
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder inf = new StringBuilder();

            foreach (Jornada jornadita in Jornada)
            {
                inf.Append(jornadita.ToString());
            }

            foreach (Alumno alumn in Alumnos)
            {
                inf.Append(alumn.ToString());
            }

            foreach (Profesor profe in Profesores)
            {
                inf.Append(profe.ToString());
            }

            return inf.ToString();
        }

        /// <summary>
        /// Datos de la Universidad Publicos
        /// </summary>
        /// <returns>un String con todos los datos</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #endregion


        #region Operators
        /// <summary>
        /// Una Universidad es igual a un Alumno si este este esta Inscripto
        /// </summary>
        /// <param name="g">objeto Universidad</param>
        /// <param name="a">objeto Alumno</param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool inscripto = false;
            foreach (Alumno al in g.Alumnos)
            {
                if (al == a)
                {
                    inscripto = true;
                    break;
                }
            }
            return inscripto;
        }

        /// <summary>
        /// Negacion del operador IGUAL entre Universidad y Alumno
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Una Universidad es igual a un Profesor SI Este Ensenia en esta misma
        /// </summary>
        /// <param name="g">objeto Universidad</param>
        /// <param name="p">objeto Profesor</param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor p)
        {
            bool ensenia = false;
            foreach (Profesor profe in g.Profesores)
            {
                if (profe == p)
                {
                    ensenia = true;
                    break;
                }
            }
            return ensenia;
        }

        /// <summary>
        /// Negacion del Operador IGUAL entre Universidad y Profesor
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor p)
        {
            return !(g == p);
        }

        /// <summary>
        /// Una Universidad es IGUAL a una CLase SI:
        ///  -Hay un Profesor que la Ensenia
        /// Caso contrario lanza la Exception:
        ///  -SinProfesorException()
        /// </summary>
        /// <param name="g">objeto Universidad</param>
        /// <param name="clase">enumerado ECLASE</param>
        /// <returns>objeto tipo Profesor</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor prof = null;
            foreach (Profesor profe in g.Profesores)
            {
                if (profe == clase)
                {
                    prof = profe;
                    break;
                }                    
            }
            if (prof is null)
            {
                throw new SinProfesorException();
            }
            return prof;
        }

        /// <summary>
        /// Devuelve el Primer Profesor que no ensenia la clase
        /// </summary>
        /// <param name="g">objeto Universidad</param>
        /// <param name="clase">objeto ECLASE</param>
        /// <returns>El profe que no ensenia la materia</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor prof = null;
            foreach (Profesor profe in g.Profesores)
            {
                if (profe != clase)
                {
                    prof = profe;
                }             
            }
            return prof;
        }

        /// <summary>
        ///  Agrega una EClase a una nueva JORNADA solo si existe un profesor 
        /// Que ensenie la materia y agrega a los ALumnos Inscriptos en esa Materia.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>objeto Universidad</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            if (g.Profesores != null)
            {
                Profesor profe = g == clase;
                if (!(profe is null))
                {
                    Jornada jor = new Jornada(clase, profe);
                    foreach(Alumno alumn in g.Alumnos)
                    {
                        if (alumn == clase)
                        {
                            jor.Alumnos.Add(alumn);
                        }
                    }
                    g.Jornada.Add(jor);
                }
            }
            return g;
        }

        /// <summary>
        /// Agrega un Alumno a la Universidad
        /// Si este ya existe lanza la exception AlumnoRepetidoException
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>objeto Universidad</returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
                g.Alumnos.Add(a);
            else
                throw new AlumnoRepetidoException();
            
            return g;
        }

        /// <summary>
        /// Agrega un Profesor a la Universidad si este Aun no Ensenia en esta.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <returns>objeto Universidad</returns>
        public static Universidad operator +(Universidad g, Profesor p)
        {
            if (g != p)
                g.Profesores.Add(p);

            return g;
        }
        #endregion

        #region Lectura Escritura
        /// <summary>
        /// Guarda en XML todos los datos de la universidad
        /// </summary>
        /// <param name="uni">Objeto a guardar</param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(Environment.CurrentDirectory + "\\Universidad.xml", uni);
        }

        /// <summary>
        /// Retorna un objeto de la Clase Universidad Con todos los datos 
        /// guardados anteriormente
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad uni;
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer(Environment.CurrentDirectory + "\\Universidad.xml", out uni);

            return uni;
        }
        #endregion
    }
}
