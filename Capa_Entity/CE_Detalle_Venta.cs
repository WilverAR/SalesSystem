using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entity
{
    public class CE_Detalle_Venta
    {
        public int Id_Venta { get; set; }
        public string Nombre { get; set; }
        public int Id_Producto { get; set; }
        public string Tipo_Comprobante { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
