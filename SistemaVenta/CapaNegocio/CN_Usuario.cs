using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Modificar(Usuario u)
        {
            return new CD_Usuario().Modificar(u);
        }

    }
}
