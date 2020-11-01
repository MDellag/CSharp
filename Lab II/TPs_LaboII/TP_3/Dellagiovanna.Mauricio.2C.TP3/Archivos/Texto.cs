using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<String>
    {
        /// <summary>
        /// Guarda los datos de un objeto en un .txt
        /// En el directorio especificado en el argumento archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool guardo = false;
            StreamWriter writer = File.CreateText(archivo);
            writer.Write(datos);
            writer.Close();

            return guardo;
        }

        /// <summary>
        /// Lee un archivo .txt en el directorio Especificado
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true or false</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool leyo = false;
            StreamReader reader;
            reader = new StreamReader(archivo);

            datos = reader.ReadToEnd();
            reader.Close();
            return leyo;
        }
    }
}
