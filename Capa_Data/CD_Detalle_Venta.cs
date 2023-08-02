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
    public class CD_Detalle_Venta
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_ToList_Venta()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Detalle_Venta", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Mantenimiento_Venta(CE_Detalle_Venta obj, string accion)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Detalle_Venta", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Producto", obj.Id_Producto);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", obj.Precio);
            cmd.Parameters.AddWithValue("@Total", obj.Total);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            cmd.Parameters.AddWithValue("@Id_Venta", obj.Id_Venta);
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

        public DataTable SP_ToList_Detalle_Venta_ID(int Id_Venta)
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Detalle_Venta_ID", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Venta", Id_Venta);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
