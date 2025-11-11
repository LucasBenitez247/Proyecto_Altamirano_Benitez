using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra datos = new CD_Compra();

        public bool ExisteNroOrden(int nroOrden)
        {
            return datos.ExisteNroOrden(nroOrden);
        }

        public List<CompraPorCategoria> ObtenerInformePorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            CD_Compra datos = new CD_Compra();
            return datos.ObtenerTotalPorCategoria(fechaInicio, fechaFin);
        }

        public List<Compra> ObtenerCompras()
        {
            return datos.ObtenerCompras();
        }

        public List<Detalle_compra> ObtenerDetalleCompra(int idCompra)
        {
            return datos.ObtenerDetalleCompra(idCompra);
        }
        public ProductoMasVendido ObtenerProductoMasVendido()
        {
            return new CD_Compra().ObtenerProductoMasVendido();
        }

        public List<GastoMensualCompras> ObtenerEvolucionMensual(int anio)
        {
            return new CD_Compra().ObtenerGastoMensual(anio);
        }


        public int RegistrarCompra(Compra compra)
        {
            // Validaciones opcionales
            if (compra == null || compra.Detalle_compra == null || !compra.Detalle_compra.Any())
                throw new Exception("La compra debe tener al menos un producto.");

            if (compra.Total_compra <= 0)
                throw new Exception("El total de la compra debe ser mayor a cero.");

            // Calcular total si no viene precargado
            compra.Total_compra = compra.Detalle_compra.Sum(d => d.Precio_compra);

            // Llamar a la capa de datos
            return datos.InsertarCompra(compra);
        }

        public List<ReporteCompra> ObtenerReporte(DateTime fechaInicio, DateTime fechaFin)
        {
            return datos.ListarReporte(fechaInicio, fechaFin);
        }
    }
} 
