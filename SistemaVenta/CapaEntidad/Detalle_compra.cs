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
    }
}
