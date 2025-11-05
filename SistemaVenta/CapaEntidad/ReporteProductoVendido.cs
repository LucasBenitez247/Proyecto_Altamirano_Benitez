using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteProductoVendido
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int StockActual { get; set; }
    }
}
