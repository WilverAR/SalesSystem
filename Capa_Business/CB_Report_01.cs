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
    public class CB_Report_01
    {
        CD_Report_01 obj_report = new CD_Report_01();

        public DataTable SP_ToList_Ventas_D_X()
        {
            return obj_report.SP_ToList_Ventas_DV();
        }

        public DataTable SP_Cantidad_Ventas_Zona_X(string search)
        {
            return obj_report.SP_Cantidad_Ventas_Zona(search);
        }
    }
}
