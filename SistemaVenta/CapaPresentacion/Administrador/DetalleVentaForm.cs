using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class DetalleVentaForm : Form
    {
        public DetalleVentaForm(int idVenta)
        {
            InitializeComponent();
            CargarEncabezado(idVenta);
            CargarDetalle(idVenta);
        }

        private void CargarDetalle(int idVenta)
        {
            CN_Venta negocio = new CN_Venta();
            var detalles = negocio.ObtenerDetallesVenta(idVenta);

            foreach (var d in detalles)
            {
                dgvDetalle.Rows.Add(new object[]
                {
                d.Nombre_producto,
                d.Cantidad,
                d.Precio_unitario.ToString("0.00"),
                (d.Cantidad * d.Precio_unitario).ToString("0.00")
                });
            }
        }

        // Implementar desde acá
        private void CargarEncabezado(int idVenta)
        {
            CN_Venta negocio = new CN_Venta();
            Venta venta = negocio.ObtenerVentaPorId(idVenta); // método que devuelve una sola venta

            if (venta != null)
            {
                // Vendedor completo en un solo TextBox
                txtVendedor.Text = $"{venta.Nombre_usuario} {venta.Apellido_usuario}";

                // Cliente Nombre y Apellido
                txtNombreCliente.Text = venta.Nombre_cliente;
                txtApellidoCliente.Text = venta.Apellido_cliente;
                TDni.Text = venta.Dni_cliente;
                TTipoDocumento.Text = venta.Tipo_documento;

                // Fecha en label
                TFecha.Text = $"Fecha: {venta.Fecha_venta:dd/MM/yyyy}";
            }
            else
            {
                MessageBox.Show("No se encontró la venta.");
                this.Close();
            }
        }


    }
}
