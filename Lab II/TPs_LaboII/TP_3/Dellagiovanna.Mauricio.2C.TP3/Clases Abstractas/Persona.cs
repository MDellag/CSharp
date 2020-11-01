using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        /// <summary>
        /// Enumerado de ENacionalidad
        /// Con los valores Argentino = 0
        ///                 Extranjero = 1
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }


        /// <summary>
        /// Atributos de la clase Persona
        /// </summary>
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        #region Propiedades

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public int DNI
        {
            get { return this.dni; }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        } 
        #endregion

        #region Metodos para Validar
        /// <summary>
        /// Valida un DNI con formato INT
        /// Variando segun la nacionalidad especificada
        /// Caso contrario lanza una exception
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }

        /// <summary>
        /// Retorna un INT Validando asi un numero de DNI
        /// Caso contrario lanza una excepcion
        /// </summary>
        /// <param name="nacionalidad">Argentino u Extranjero</param>
        /// <param name="dato">String</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int auxDato;
            bool esNumero = int.TryParse(dato, out auxDato);

            if (esNumero && dato.Length >= 1 && dato.Length <= 8)
            {
                if (nacionalidad is ENacionalidad.Argentino && auxDato >= 1 && auxDato <= 89999999)
                {
                    return auxDato;
                }
                else if (nacionalidad is ENacionalidad.Extranjero && auxDato >= 90000000 && auxDato <= 99999999)
                {
                    return auxDato;
                }
                else
                {
                    throw new NacionalidadInvalidaException("Nacionalidad Invalida");
                } 
            }
            else
            {
                throw new DniInvalidoException("El dni no cumple con los requisitos");
            }
        }

        /// <summary>
        /// Verifica que un nombre (valor string)
        /// sea apropiado y no contenga caracteres raros
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string cadena)
        {
            bool esApropiado = true;
            string retorno = string.Empty;
          
            if (!(cadena is null))
            {
                foreach (char caracter in cadena)
                {
                    if (!char.IsLetter(caracter))
                    {
                        esApropiado = false;
                        break;
                    }
                }

                if (esApropiado)
                    retorno = cadena; 
            }  
            return retorno;
        }
        #endregion

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            StringToDNI = dni;
        }

        #endregion

        /// <summary>
        /// Override del metodo ToString()
        /// Devuelve toda la informacion del Objeto Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat($"Nombre:       {this.Nombre}\n");
            info.AppendFormat($"Apellido:     {this.Apellido}\n");
            info.AppendFormat($"DNI:          {this.DNI}\n");
            info.AppendFormat($"Nacionalidad: {this.Nacionalidad.ToString()}\n");

            return info.ToString();
        }


    }
}
