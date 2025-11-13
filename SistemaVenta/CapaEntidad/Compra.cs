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

        public int Id_proveedor { get; set; }
        public int Nro_orden { get; set; }
        public DateTime Fecha_compra { get; set; }
        public float Total_compra { get; set; }

        // atributos que no estan en la tabla
        public string Nombre_usuario { get; set; }       // Nombre del usuario que realizó la compra
        public string Nombre_proveedor { get; set; }     // Nombre del proveedor de la compra

        public int Nro_documento_proveedor { get; set; }      // Número de documento del proveedor

        public List<Detalle_compra> Detalle_compra { get; set; }
    }
}
