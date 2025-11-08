using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objCapaDatos = new CD_Proveedor();

        public bool Registrar(Proveedor Proveedor)
        {
            return objCapaDatos.Registrar(Proveedor);
        }

        public List<Proveedor> Listar()
        {
            return objCapaDatos.Listar();
        }

        // Agrega este método para exponer Eliminar
        public bool Eliminar(int idProveedor)
        {
            return objCapaDatos.bajaProveedor(idProveedor);
        }

        public bool Modificar(Proveedor u)
        {
            return new CD_Proveedor().Modificar(u);
        }
    }
}
