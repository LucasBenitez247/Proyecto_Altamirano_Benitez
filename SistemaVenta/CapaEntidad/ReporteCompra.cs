using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteCompra
    {

        public string FechaRegistro { get; set; }
        public int NroOrden { get; set; }
        public int totalCompra { get; set; }
        public string nombreUsuario { get; set; }
        public string RazonSocialProveedor { get; set; }
        public string codigoProducto { get; set; } 

        public string nombreProducto { get; set; }
        public int cantidadProducto { get; set; }
        public string categoriaProducto { get; set; }

        public float precioCompra { get; set; }

        public float subtotal { get; set; }

    }
}
