using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_57
{
     [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {
           
        }

        public Persona(string name, string surname)
        {
            this.apellido = surname;
            this.nombre = name;
        }

        public static void Guardar(Persona p)
        {
            Stream stream; ;       //ojbeto que serializara
            IFormatter writer;           //objeto que escribira EN xml


            //indocamos el tipo de objeto a serializar
            writer = new BinaryFormatter();

            //Indicamos la ubicacion del archivo XML y su codificacion
            stream = new FileStream(@"S:/log.dat", FileMode.Create);

            //Serializamos el objeto P en el archivo contenido en writer
            writer.Serialize(stream, p);

            //cerramos
            stream.Close();
        }

        public static Persona Leer(string path)
        {
            Persona p;

            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(@"S:/log.dat", FileMode.Open, FileAccess.Read);

            p = (Persona)formater.Deserialize(stream);

            stream.Close();

            return p;
        }

        #region XMLVersion
        //public static void Guardar(Persona p)
        //{
        //    XmlTextWriter writer;           //objeto que escribira EN xml
        //    XmlSerializer serializer;       //ojbeto que serializara

        //    //Indicamos la ubicacion del archivo XML y su codificacion

        //    writer = new XmlTextWriter(@"C:/Users/Nehl/Desktop/pepe.xml", Encoding.UTF8);

        //    //indocamos el tipo de objeto a serializar
        //    serializer = new XmlSerializer(typeof(Persona));

        //    //Serializamos el objeto P en el archivo contenido en writer
        //    serializer.Serialize(writer, p);

        //    //cerramos
        //    writer.Close();
        //}

        //public static Persona Leer(string path)
        //{
        //    Persona p;

        //    XmlTextReader xmlReader;
        //    XmlSerializer serializer;

        //    xmlReader = new XmlTextReader(path);

        //    serializer = new XmlSerializer(typeof(Persona));

        //    p = (Persona)serializer.Deserialize(xmlReader);

        //    xmlReader.Close();

        //    return p;
        //}
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}", this.apellido);

            return sb.ToString();
        }
    }
}
