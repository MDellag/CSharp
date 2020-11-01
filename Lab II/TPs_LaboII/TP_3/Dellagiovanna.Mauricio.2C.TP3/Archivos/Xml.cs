using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Metodo para guardar un archivo en XML
        /// </summary>
        /// <param name="archivo">Ruta donde se creara el Archivo</param>
        /// <param name="t">Objeto a Serializar a XML</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T t)
        {
            bool guardo = false;
            try
            {
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, t);
                writer.Close();
                guardo = true;
            }
            catch (Exception innerE)
            {
                throw new ArchivosException(innerE);
            }
            return guardo;
        }

        /// <summary>
        /// Lee un archivo XML en el DIrectorio especificado
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="t"></param>
        /// <returns>true or false</returns>
        public bool Leer(string archivo, out T t)
        {
            bool leyo = false;
            try
            {
                XmlTextReader reader = new XmlTextReader(archivo); 
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                t = (T)serializer.Deserialize(reader);
                reader.Close();
                leyo = true;
            }
            catch (Exception innerE)
            {
                throw new ArchivosException(innerE);
            }
            return leyo;
        }
    }
}
