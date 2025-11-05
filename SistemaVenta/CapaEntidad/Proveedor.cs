using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int Id_proveedor { get; set; }
        public int Nro_documento_proveedor { get; set; }
        public string Razon_social { get; set; }
        public int Estado_proveedor { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}
