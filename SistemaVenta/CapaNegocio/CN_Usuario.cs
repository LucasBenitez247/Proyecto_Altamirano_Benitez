using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objCapaDatos = new CD_Usuario();

        public bool Registrar(Usuario usuario)
        {
            return objCapaDatos.Registrar(usuario);
        }

        public List<Usuario> Listar()
        {
            return objCapaDatos.Listar();
        }

        // Agrega este método para exponer Eliminar
        public bool Eliminar(int idUsuario)
        {
            return objCapaDatos.Eliminar(idUsuario);
        }
    }
}
