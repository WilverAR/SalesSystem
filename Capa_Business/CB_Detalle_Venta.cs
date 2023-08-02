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
    public class CB_Detalle_Venta
    {
        CD_Detalle_Venta obj_venta = new CD_Detalle_Venta();

        public DataTable SP_ToList_Venta_X()
        {
            return obj_venta.SP_ToList_Venta();
        }

        public String SP_Mantenimiento_Venta_X(CE_Detalle_Venta obj, string accion)
        {
            return obj_venta.SP_Mantenimiento_Venta(obj, accion);
        }

        public DataTable SP_ToList_Detalle_Venta_ID(int Id_Venta)
        {
            return obj_venta.SP_ToList_Detalle_Venta_ID(Id_Venta);
        }
    }
}
