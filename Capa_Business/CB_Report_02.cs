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
    public class CB_Report_02
    {
        CD_Report_02 report_two = new CD_Report_02();

        public DataTable SP_Report_ToList_Stock_X(string categoria)
        {
            return report_two.SP_Report_ToList_Stock(categoria);
        }
    }
}
