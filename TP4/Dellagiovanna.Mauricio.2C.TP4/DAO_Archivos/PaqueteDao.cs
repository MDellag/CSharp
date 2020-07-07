using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Archivos
{
    public static class PaqueteDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDao()
        {
            conexion = new SqlConnection(@"Data Source = .\\SQLEXPRESS; Database = correo-sp-2017; Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.Connection = conexion;    
        }
    }
}
