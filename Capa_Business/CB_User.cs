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
    public class CB_User
    {
        CD_User obj_user = new CD_User();
        
        public DataTable SP_User_PWD_UID_X(CE_User obj)
        {
            return obj_user.SP_User_PWD_UID(obj);
        }
    }
}
