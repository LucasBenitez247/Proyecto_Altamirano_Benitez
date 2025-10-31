using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int Id_venta { get; set; }
        public int Id_cliente { get; set; }
        public int Id_usuario { get; set; }
        public string Tipo_documento { get; set; }
        public DateTime Fecha_venta { get; set; }
        public decimal Total_venta { get; set; }

        //no estan en la base de datos , solo los almacena tempralmente 
        public string Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public string Dni_cliente { get; set; }
    }
}
