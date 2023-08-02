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
    public class CB_Update_Stock
    {
        CD_Update_Stock update = new CD_Update_Stock();

        public DataTable SP_Update_S_X(string name, int stock)
        {
            return update.SP_Update_S(name, stock);
        }
    }
}
