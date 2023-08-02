using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entity
{
    public class CE_Product
    {
        public int Id_Producto { get; set; }
        public string Nombre { get; set; }
        public int Stock_Inicial { get; set; }
        public int Stock_Actual { get; set; }
        public string Categoria { get; set; }
        public int Codigo { get; set; }
    }
}
