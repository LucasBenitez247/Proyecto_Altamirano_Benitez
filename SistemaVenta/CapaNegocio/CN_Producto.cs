using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        public bool RegistrarProducto(Producto producto)
        {
            try
            {
                CD_Producto cdProducto = new CD_Producto(); // Capa de datos
                cdProducto.insertarProducto(producto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria_producto> obtenerCategoria()
        {
            CD_Producto cdProducto = new CD_Producto();
            return cdProducto.categoriaProducto();
        }

        public List<Producto> listarProductos()
        {
            CD_Producto cdProducto = new CD_Producto();
            return cdProducto.productos();
        }

        public List<Estado_producto> listarEstados()
        {
            CD_Producto cdProducto = new CD_Producto();
            return cdProducto.ObtenerEstados();
        }
    }
}
