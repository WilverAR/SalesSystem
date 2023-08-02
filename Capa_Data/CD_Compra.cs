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
    public class CD_Compra
    {
        CD_Conexion CE = new CD_Conexion();

        public void SP_Crear_Compra(CE_Compra obj_v)
        {
            SqlCommand cmd = new SqlCommand("SP_Create_Compra", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tipo_Comprobante", obj_v.Tipo_Comprobante);

            CE.Conexion().Open();
            cmd.ExecuteNonQuery();
            CE.Conexion().Close();
        }

        public DataTable SP_ToList_Column_ID_C()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_ID_Compra", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Compra_N()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Compra_N", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Delete_Compra_DT(int Id_Compra)
        {
            SqlCommand cmd = new SqlCommand("SP_Delete_Compra_DT", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Compra", Id_Compra);

            CE.Conexion().Open();
            cmd.ExecuteNonQuery();
            CE.Conexion().Close();

            return "Se eliminó la compra correctamente";
        }

        public DataTable SP_Create_Compra_DT(CE_Compra obj_c)
        {
            SqlCommand cmd = new SqlCommand("SP_Create_Compra_DT", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tipo_Comprobante", obj_c.Tipo_Comprobante);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
