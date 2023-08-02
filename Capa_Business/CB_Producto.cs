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
    public class CB_Producto
    {
        CD_Producto obj_product = new CD_Producto();

        public DataTable SP_Listar_Product_X()
        {
            return obj_product.SP_Listar_Product();
        }

        public String SP_Mantenimiento_Product_X(CE_Product obj, string accion)
        {
            return obj_product.SP_Mantenimiento_Product(obj, accion);
        }

        public DataTable SP_Search_Products_X(string search)
        {
            return obj_product.SP_Search_Products(search);
        }

        public DataTable SP_ToList_Column_Product_X()
        {
            return obj_product.SP_ToList_Columna_Product();
        }

        public DataTable SP_Producto_Verificar_Uso(int Id_Producto)
        {
            return obj_product.SP_Producto_Verificar_Uso(Id_Producto);
        }
    }
}
