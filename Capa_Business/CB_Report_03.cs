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
    public class CB_Report_03
    {
        CD_Report_03 report = new CD_Report_03();

        public DataTable N_ListarProductosmasVendidosDelMesConCategoria()
        {
            return report.DT_ListarProductosMasVendidosdeMesConCategoria();
        }
    }
}
