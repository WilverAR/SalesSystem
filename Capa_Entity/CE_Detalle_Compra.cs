using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entity
{
    public class CE_Detalle_Compra
    {
        public int Id_Product { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Compra { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public string Talla { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
