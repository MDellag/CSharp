using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda un txt del string actual en la ubicacion dada en el parametro archivo.
        /// retorna boolean si se concreto o no la operacion
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool guardo = false;

            using (StreamWriter writer = new StreamWriter(archivo, true))
            {
                writer.WriteLine(texto);
                guardo = true;
            }

            return guardo;
        }
    }
}
