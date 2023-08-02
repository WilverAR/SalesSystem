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
    public class CD_Detalle_Compra
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_ToList_Compra()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Compra", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Registrar_Compra(CE_Detalle_Compra obj_buy, string accion)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Compra", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Producto", obj_buy.Id_Product);
            cmd.Parameters.AddWithValue("@Id_Proveedor", obj_buy.Id_Proveedor);
            cmd.Parameters.AddWithValue("@Id_Compra", obj_buy.Id_Compra);
            cmd.Parameters.AddWithValue("@Cantidad", obj_buy.Cantidad);
            cmd.Parameters.AddWithValue("@Marca", obj_buy.Marca);
            cmd.Parameters.AddWithValue("@Talla", obj_buy.Talla);
            cmd.Parameters.AddWithValue("@Total", obj_buy.Total);
            cmd.Parameters.AddWithValue("@Fecha", obj_buy.Fecha);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 1).Value = accion;

            CE.Conexion().Open();
            cmd.ExecuteNonQuery();
            CE.Conexion().Close();

            string message = "";

            switch (accion)
            {
                case "1": message = "Dato agregado correctamente"; break;
                case "2": message = "Dato editado correctamente"; break;
                case "3": message = "Dato eliminado correctamente"; break;
            }
            return message;
        }

        public DataTable SP_ToList_Columna_Compra()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_Buy", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Detalle_Compra_ID(int Id_Compra)
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Detalle_Compra_ID", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Compra", Id_Compra);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
