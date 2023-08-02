using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entity;

namespace Capa_Data
{
    public class CD_Report_02
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_Report_ToList_Stock(string categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_Producto_Busqueda_Categoria", CE.Conexion());
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
