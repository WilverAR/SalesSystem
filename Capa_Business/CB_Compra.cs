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
    public class CB_Compra
    {
        CD_Compra obj_vent = new CD_Compra();

        public void SP_Crear_Compra_X(CE_Compra obj)
        {
            obj_vent.SP_Crear_Compra(obj);
        }

        public DataTable SP_ToList_Column_ID_C()
        {
            return obj_vent.SP_ToList_Column_ID_C();
        }

        public DataTable SP_ToList_Compra_N()
        {
            return obj_vent.SP_ToList_Compra_N();
        }

        public String SP_Delete_Compra_DT(int Id_Compra)
        {
            return obj_vent.SP_Delete_Compra_DT(Id_Compra);
        }

        public DataTable SP_Create_Compra_DT(CE_Compra obj_c)
        {
            return obj_vent.SP_Create_Compra_DT(obj_c);
        }
    }
}
