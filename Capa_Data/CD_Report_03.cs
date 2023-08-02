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
    public class CD_Report_03
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable DT_ListarProductosMasVendidosdeMesConCategoria()
        {
            SqlCommand cmd = new SqlCommand("sp_ListarProdMasVendidosConCategoria3", CE.Conexion());
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
