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
    public class CD_Proveedor
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_Listar_Proveedor()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Proveedor", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Mantenimiento_Proveedor(CE_Proveedor obj, string accion)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Proveedor", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Proveedor", obj.Id_Proveedor);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("@Distrito", obj.Distrito);
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

        public DataTable SP_Search_Proveedor(string search)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Search_Proveedor", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@buscar", search);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Columna_Proveedor()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_Proveedor", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_Proveedor_Verificar_Uso(int Id_Proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_Proveedor_Verificar_Uso", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
