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
    public class CD_Report_01
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_ToList_Ventas_DV()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Venta_D", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
        
        public DataTable SP_Cantidad_Ventas_Zona(string search)
        {
            SqlCommand cmd = new SqlCommand("SP_Cant_Ventas_Zona", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", search);

            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
