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
    public class CD_Venta
    {
        CD_Conexion CE = new CD_Conexion();

        public void SP_Crear_Venta(CE_Venta obj_v)
        {
            SqlCommand cmd = new SqlCommand("SP_Create_Venta", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", obj_v.Id_Cliente);
            cmd.Parameters.AddWithValue("@Tipo_Comprobante", obj_v.Tipo_Comprobante);
            cmd.Parameters.AddWithValue("@Zona", obj_v.Zona_Venta);

            CE.Conexion().Open();
            cmd.ExecuteNonQuery();
            CE.Conexion().Close();
        }

        public DataTable SP_Crear_Venta_DT(CE_Venta obj_v)
        {
            SqlCommand cmd = new SqlCommand("SP_Create_Venta_DT", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", obj_v.Id_Cliente);
            cmd.Parameters.AddWithValue("@Tipo_Comprobante", obj_v.Tipo_Comprobante);
            cmd.Parameters.AddWithValue("@Zona", obj_v.Zona_Venta);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Column_ID_V()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_ID_Venta", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Venta()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Venta", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Delete_Venta_DT(int Id_Venta)
        {
            SqlCommand cmd = new SqlCommand("SP_Delete_Venta_DT", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Venta", Id_Venta);

            CE.Conexion().Open();
            cmd.ExecuteNonQuery();
            CE.Conexion().Close();

            return "Se eliminó la venta correctamente";
        }
    }
}
