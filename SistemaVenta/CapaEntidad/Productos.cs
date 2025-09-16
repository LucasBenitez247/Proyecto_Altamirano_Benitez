using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Productos
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public decimal Precio_producto { get; set; }
        public int Estado_producto { get; set; }
        public int Stock_producto { get; set; }
        public string Categoria_producto { get; set; }  


    }
}
