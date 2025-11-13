using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_compra
    {
        public int Id_detalle_compra { get; set; }
        public int Id_compra { get; set; }
        public int Id_producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio_compra { get; set; }

        // Atributo que no está en la tabla
        public string Nombre_producto { get; set; } // Nombre del producto

        public float Precio_venta { get; set; } // Precio de venta del producto

    }
}
