using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entity
{
    public class CE_Venta
    {
        public int Id_Venta { get; set; }
        public int Id_Cliente { get; set; }
        public string Tipo_Comprobante { get; set; }
        public string Zona_Venta { get; set; }
    }
}
