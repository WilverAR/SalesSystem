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
    public class CB_Venta
    {
        CD_Venta obj_vent = new CD_Venta();
        
        public void SP_Create_Venta_X(CE_Venta obj)
        {
            obj_vent.SP_Crear_Venta(obj);
        }

        public DataTable SP_Crear_Venta_DT(CE_Venta obj)
        {
            return obj_vent.SP_Crear_Venta_DT(obj);
        }

        public DataTable SP_ToList_Columna_Venta_X()
        {
            return obj_vent.SP_ToList_Column_ID_V();
        }

        public DataTable SP_ToList_Venta()
        {
            return obj_vent.SP_ToList_Venta();
        }

        public String SP_Delete_Venta_DT(int Id_Venta)
        {
            return obj_vent.SP_Delete_Venta_DT(Id_Venta);
        }
    }
}
