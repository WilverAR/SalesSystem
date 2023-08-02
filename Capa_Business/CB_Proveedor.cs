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
    public class CB_Proveedor
    {
        CD_Proveedor obj_data = new CD_Proveedor();

        public DataTable SP_Listar_Proveedor_X()
        {
            return obj_data.SP_Listar_Proveedor();
        }
        public String SP_Mantenimiento_Proveedor_X(CE_Proveedor obj, string accion)
        {
            return obj_data.SP_Mantenimiento_Proveedor(obj, accion);
        }
        public DataTable SP_Search_Proveedor_X(string search)
        {
            return obj_data.SP_Search_Proveedor(search);
        }

        public DataTable SP_ToList_Columna_Proveedor_X()
        {
            return obj_data.SP_ToList_Columna_Proveedor();
        }

        public DataTable SP_Proveedor_Verificar_Uso(int Id_Proveedor)
        {
            return obj_data.SP_Proveedor_Verificar_Uso(Id_Proveedor);
        }
    }
}
