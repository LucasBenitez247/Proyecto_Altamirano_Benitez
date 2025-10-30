using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Vendedor
{
    public partial class HistorialVentasUserControl : UserControl
    {
        public HistorialVentasUserControl()
        {
            InitializeComponent();
            CargarVentas();
        }
        private void CargarVentas()
        {
            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false; // Importante para que use tus columnas

            try
            {
                // Obtener la lista de ventas desde la capa de negocio
                CN_Venta cnVenta = new CN_Venta();
                List<Venta> listaVentas = cnVenta.Listar();

                if (listaVentas == null)
                {
                    MessageBox.Show("No se pudieron cargar las ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recorrer la lista y añadir cada venta al DataGridView
                foreach (Venta venta in listaVentas)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        venta.Fecha_venta.ToString("dd/MM/yyyy HH:mm"), // Columna CFecha
                        $"{venta.Nombre_cliente} {venta.Apellido_cliente}", // Columna CCliente
                        venta.Total_venta.ToString("0.00"), // Columna CTotal
                        venta.Tipo_documento, // Columna CTipoDocumento
                        "Ver Detalle" // Columna CDetalle (Texto del botón)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la columna del botón "Detalle"
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                // pasar un ID de venta si es necesario
                // int idVenta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdVenta"].Value);

                // Abre la ventana DetalleVenta como formulario modal
                DetalleVenta detalleForm = new DetalleVenta();
                detalleForm.ShowDialog();
            }
        }

    }
}
