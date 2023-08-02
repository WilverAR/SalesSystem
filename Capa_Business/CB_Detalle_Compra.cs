using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Data;
using Capa_Entity;

namespace Capa_Business
{
    public class CB_Detalle_Compra
    {
        CD_Detalle_Compra obj_buy = new CD_Detalle_Compra();
        
        public DataTable SP_ToList_Compra_X()
        {
            return obj_buy.SP_ToList_Compra();
        }

        public String SP_Registrar_Compra_X(CE_Detalle_Compra obj, string accion)
        {
            return obj_buy.SP_Registrar_Compra(obj, accion);
        }

        public DataTable SP_ToList_Columna_Compra_X()
        {
            return obj_buy.SP_ToList_Columna_Compra();
        }

        public DataTable SP_ToList_Detalle_Compra_ID(int Id_Compra)
        {
            return obj_buy.SP_ToList_Detalle_Compra_ID(Id_Compra);
        }
    }
}
