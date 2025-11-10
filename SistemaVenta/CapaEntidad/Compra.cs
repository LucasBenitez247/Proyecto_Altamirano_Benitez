using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Compra
    {
        public int Id_compra { get; set; }

        public int Id_usuario { get; set; }

        public int Id_producto { get; set; }

        public int Id_proveedor { get; set; }
        public int Nro_orden { get; set; }
        public DateTime Fecha_compra { get; set; }
        public float Total_compra { get; set; }
    }
}
