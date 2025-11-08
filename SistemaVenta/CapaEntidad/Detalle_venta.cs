using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Detalle_venta
    {
        public int Id_detalle_venta { get; set; }
        public int Id_venta { get; set; }
        public int Id_producto { get; set; }
        public decimal Precio_unitario { get; set; }
        public int Cantidad { get; set; }

        //no estan en la base de datos , solo los almacena tempralmente
        public string Nombre_producto { get; set; }
        // Propiedad calculada para el subtotal
        public decimal Subtotal { get { return Precio_unitario * Cantidad; } }

    }
}
