using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCapaDatos = new CD_Venta();

        public bool RegistrarVenta(Venta venta, List<Detalle_venta> detalleVenta, out string mensaje)
        {
            //  añadir reglas de negocio si es necesario
            // Por ejemplo, validar que el total no sea negativo, etc.
            if (venta.Total_venta <= 0)
            {
                mensaje = "El total de la venta no puede ser cero o negativo.";
                return false;
            }

            return objCapaDatos.RegistrarVenta(venta, detalleVenta, out mensaje);
        }
        public List<Venta> Listar()
        {
            // Agregar reglas de negocio si fuera necesario
            // (ej. filtrar ventas por usuario)
            return objCapaDatos.Listar();
        }
        public List<Detalle_venta> ObtenerDetallesVenta(int idVenta)
        {
            return objCapaDatos.ObtenerDetallesVenta(idVenta);
        }
    }
}
