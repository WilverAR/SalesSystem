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
    public class CD_Producto
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_Listar_Product()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Products", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Mantenimiento_Product(CE_Product obj, string accion)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Products", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Producto", obj.Id_Producto);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Stock_Inicial", obj.Stock_Inicial);
            cmd.Parameters.AddWithValue("@Stock_Actual", obj.Stock_Actual);
            cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
            cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
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

        public DataTable SP_Search_Products(string search)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Search_Products", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@buscar", search);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Columna_Product()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_ID_Product", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_Producto_Verificar_Uso(int Id_Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_Producto_Verificar_Uso", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
