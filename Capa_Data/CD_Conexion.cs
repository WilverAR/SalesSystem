using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Data
{
    public class CD_Conexion
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_conexion"].ConnectionString);

        public SqlConnection Conexion()
        {
            return conexion;
        }
    }
}
