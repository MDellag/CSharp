using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public static class PaqueteDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDao()
        {
            conexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = correo-sp-2017; Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }


        /// <summary>
        /// Inserta un paquete en la base de datos y retorna true
        /// caso contrario lanza una exception
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InsertarPaquete(Paquete p)
        {
            string query = string.Format("INSERT INTO Paquetes VALUES('{0}', '{1}', 'Dellagiovanna Mauricio')", p.DireccionEntrega, p.TrakingID);
            try
            {

                conexion.Open();
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception innerExc)
            {
                throw new Exception(innerExc.Message, innerExc);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
