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
    public class CD_Cliente
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_Listar_Client()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Clients", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public String SP_Mantenimiento_Client(CE_Client obj, string accion)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Clients", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", obj.Id_Cliente);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Numero_Dni", obj.Dni);
            cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
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

        public DataTable SP_Search_Client(string search)
        {
            SqlCommand cmd = new SqlCommand("SP_Mantenimiento_Search_Clients", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@buscar", search);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_ToList_Columna_Client()
        {
            SqlCommand cmd = new SqlCommand("SP_ToList_Column_Client", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }

        public DataTable SP_Cliente_Verificar_Uso(int Id_Cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_Cliente_Verificar_Uso", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
