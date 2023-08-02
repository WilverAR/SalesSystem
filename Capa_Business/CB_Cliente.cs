using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Data;
using Capa_Entity;
using System.Data;

namespace Capa_Business
{
    public class CB_Cliente
    {
        CD_Cliente obj_client = new CD_Cliente();

        public DataTable SP_Listar_Client_X()
        {
            return obj_client.SP_Listar_Client();
        }

        public String SP_Mantenimiento_Client_X(CE_Client obj, string accion)
        {
            return obj_client.SP_Mantenimiento_Client(obj, accion);
        }

        public DataTable SP_Search_Client_X(string search)
        {
            return obj_client.SP_Search_Client(search);
        }

        public DataTable SP_ToList_Columna_Client_X()
        {
            return obj_client.SP_ToList_Columna_Client();
        }

        public DataTable SP_Cliente_Verificar_Uso(int Id_Cliente)
        {
            return obj_client.SP_Cliente_Verificar_Uso(Id_Cliente);
        }
    }
}
