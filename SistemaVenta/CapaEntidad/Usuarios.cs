using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Apellido_usuario { get; set; }
        public string Mail_usuario { get; set; }
        public string Telefono_usuario { get; set; }
        public string Contrasenia_usuario { get; set; }
        public int Id_perfil { get; set; }
        public int Estado_usuario { get; set; }
       
    }
}
