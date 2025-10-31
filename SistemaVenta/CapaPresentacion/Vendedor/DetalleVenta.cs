using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Globalization;

namespace CapaPresentacion.Vendedor
{
    public partial class DetalleVenta : Form
    {
        //Variable para guardar la venta
        private Venta ventaActual;


        public DetalleVenta()
        {
            InitializeComponent();
        }

        //  Nuevo constructor que recibe la venta 
        public DetalleVenta(Venta venta)
        {
            InitializeComponent();
            this.ventaActual = venta;
            // Configurar el DataGridView
            dataGridView1.AutoGenerateColumns = false;
        }

        // Evento Load para cargar los datos 
        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            if (ventaActual != null)
            {
                //  Llena Información de la Venta
                TFecha.Text = ventaActual.Fecha_venta.ToString("dd/MM/yyyy HH:mm");
                TTipoDocumento.Text = ventaActual.Tipo_documento;

                // Llena Información del Cliente
                TDni.Text = ventaActual.Dni_cliente;
                TNombre.Text = ventaActual.Nombre_cliente;
                TApellido.Text = ventaActual.Apellido_cliente;

                //  Llena DataGridView con los productos (Detalles)
                CargarDetalles();
            }
        }

        // Método para cargar la grilla de productos
        private void CargarDetalles()
        {
            dataGridView1.Rows.Clear();
            CN_Venta cnVenta = new CN_Venta();
            List<Detalle_venta> detalles = cnVenta.ObtenerDetallesVenta(ventaActual.Id_venta);

            if (detalles == null) return;

            foreach (var detalle in detalles)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    detalle.Nombre_producto,
                    detalle.Precio_unitario.ToString("0.00"),
                    detalle.Cantidad,
                    detalle.Subtotal.ToString("0.00") // Usamos la propiedad calculada
                });
            }

            // Si tuvieras un TextBox para el total en este formulario:
            // txtTotalVentaDetalle.Text = ventaActual.Total_venta.ToString("0.00");
        }

        private void DetalleVenta_Load_1(object sender, EventArgs e)
        {
            if (ventaActual != null)
            {
                // Llenar Información de la Venta
                TFecha.Text = ventaActual.Fecha_venta.ToString("dd/MM/yyyy");
                TTipoDocumento.Text = ventaActual.Tipo_documento;

                // Llenar Información del Cliente
                TDni.Text = ventaActual.Dni_cliente;
                TNombre.Text = ventaActual.Nombre_cliente;
                TApellido.Text = ventaActual.Apellido_cliente;

                // Llenar DataGridView con los productos (Detalles)
                CargarDetalles();
            }
        }

    }
}
