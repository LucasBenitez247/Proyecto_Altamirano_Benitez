using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre_cliente { get; set; }       
        public string Apellido_cliente { get; set; }
        public string Dni_cliente { get; set; }
        public string Genero_cliente { get; set; }
        public string Correo_cliente { get; set; }
        public string Telefono_cliente { get; set; }
        public string Direccion_cliente { get; set; }
        public string Ciudad_cliente { get; set; }
        public string Provincia_cliente { get; set; }
        public int Cod_postal_cliente { get; set; }
        public int Estado_cliente { get; set; }  

    }
}
