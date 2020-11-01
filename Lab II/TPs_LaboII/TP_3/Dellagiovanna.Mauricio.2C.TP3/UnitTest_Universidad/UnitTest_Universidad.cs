using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesInstanciables;

namespace UnitTest_Universidad
{
    [TestClass]
    public class UnitTest_Universidad
    {
        /// <summary>
        /// Valida que se instancien las Listas<>
        /// De la Clase UNIVERSIDAD
        /// Falla cuando almenos una de las 3 no Instancia.
        /// </summary>
        [TestMethod]          
        public void ValidaInstanciadoDeListas_Universidad()
        {
             bool instanciadas = true;
             Universidad univ = new Universidad();

             if (univ.Alumnos is null)
                 instanciadas = false;

             if (univ.Jornada is null)
                 instanciadas = false;

             if (univ.Profesores is null)
                 instanciadas = false;

             Assert.IsTrue(instanciadas);
        }

        /// <summary>
        /// Valida que lanze la excepcion AlumnoRepetido cuando se carga 
        /// 2 veces al mismo alumno
        /// </summary>
        [TestMethod]
        public void ValidaExcepcionAlumnoRepetido()
        {
            Universidad u = new Universidad();
            Alumno alumno1 = new Alumno(22, "Test", "Exception", "929292", ClasesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            string exception = string.Empty;

            u += alumno1;
            try
            {
                u += alumno1;
            }
            catch (AlumnoRepetidoException e)
            {
                exception = e.Message;         
            }
            Assert.AreEqual("Alumno Repetido.", exception);
        }

        /// <summary>
        /// Testea que al comparar una Universidad con una ECLase lanze la excepcion si
        /// No hay profesores que den la materia.
        /// Nota: Puede fallar ya que la asignacion de materias es ALEATORIA
        /// </summary>
        [TestMethod]
        public void ValidaExcepcionSinProfesor()
        {
            Universidad uni = new Universidad();
            Profesor profe = new Profesor();
            Jornada jor = new Jornada(Universidad.EClases.Programacion, profe);
            string excepcion = string.Empty;

            try
            {
                Profesor trying = uni == Universidad.EClases.SPD;
            }
            catch (SinProfesorException e)
            {

                excepcion = e.Message;
            }

            Assert.AreEqual("No hay profesor para la clase", excepcion);
        }
        
    }
}
