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
    public class CD_User
    {
        CD_Conexion CE = new CD_Conexion();

        public DataTable SP_User_PWD_UID(CE_User obj_user)
        {
            SqlCommand cmd = new SqlCommand("SP_Psw_Uid", CE.Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Number", obj_user.Number);
            cmd.Parameters.AddWithValue("@Nombre", obj_user.Nombre);
            cmd.Parameters.AddWithValue("@Clave", obj_user.Clave);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sql.Fill(data); return data;
        }
    }
}
