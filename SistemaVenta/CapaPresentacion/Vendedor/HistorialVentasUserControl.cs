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
        //Lista para guardar las ventas cargadas
        private List<Venta> listaVentasGlobal;

        private List<Venta> listaVentasFiltrada; // Lo que se muestra en la grilla
        public HistorialVentasUserControl()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            TBuscarCliente.ForeColor = Color.Gray; // Color del placeholder
            
            CargarVentas();

            // Conecta los eventos del TextBox
            this.TBuscarCliente.Enter += new System.EventHandler(this.TBuscarCliente_Enter);
            this.TBuscarCliente.Leave += new System.EventHandler(this.TBuscarCliente_Leave);
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);

            // Conecta el evento del botón Buscar por fecha
            this.IBtnBuscar.Click += new System.EventHandler(this.IBtnBuscar_Click);
        }
        private void CargarVentas()
        {
            try
            {
                CN_Venta cnVenta = new CN_Venta();
                listaVentasGlobal = cnVenta.Listar();

                if (listaVentasGlobal == null)
                {
                    MessageBox.Show("No se pudieron cargar las ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listaVentasGlobal = new List<Venta>();
                }

                // Al inicio, la lista filtrada es una copia de la lista global
                listaVentasFiltrada = new List<Venta>(listaVentasGlobal);

                // Aplicamos el filtro de fecha inicial (por defecto, el día de hoy)
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este método recibe una lista y la muestra
        private void CargarGrilla()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;

            if (listaVentasFiltrada == null) return;

            foreach (Venta venta in listaVentasFiltrada) // Usa la lista filtrada
            {
                dataGridView1.Rows.Add(new object[]
                {
                    venta.Fecha_venta.ToString("dd/MM/yyyy HH:mm"),
                    $"{venta.Nombre_cliente} {venta.Apellido_cliente}",
                    venta.Total_venta.ToString("0.00"),
                    venta.Tipo_documento,
                    "Ver Detalle"
                });
            }
        }
        private void AplicarFiltros()
        {
            // 1. Get text filter
            string textoBusqueda = TBuscarCliente.Text.ToLower().Trim();
            bool filtrarPorTexto = !string.IsNullOrWhiteSpace(textoBusqueda) && textoBusqueda != "buscar cliente...";

            // 2. Get date filter
            // El .Date quita la hora, asegurando que empezamos desde las 00:00:00
            DateTime fechaInicio = dateTimePicker2.Value.Date;
            // El .AddDays(1).AddTicks(-1) asegura que incluimos hasta las 23:59:59 de ese día
            DateTime fechaFin = dateTimePicker1.Value.Date.AddDays(1).AddTicks(-1);

            // 3. Start with the full list
            List<Venta> listaTemp = listaVentasGlobal;

            // 4. Apply text filter (if any)
            if (filtrarPorTexto)
            {
                listaTemp = listaTemp.Where(v =>
                    v.Nombre_cliente.ToLower().Contains(textoBusqueda) ||
                    v.Apellido_cliente.ToLower().Contains(textoBusqueda)
                ).ToList();
            }

            // 5. Apply date filter (sobre la lista ya filtrada por texto)
            listaTemp = listaTemp.Where(v =>
                v.Fecha_venta >= fechaInicio && v.Fecha_venta <= fechaFin
            ).ToList();

            // 6. Asignar a la lista global filtrada y recargar grilla
            listaVentasFiltrada = listaTemp;
            CargarGrilla();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                // Ahora usamos 'listaVentasFiltrada' que siempre está actualizada
                if (e.RowIndex < listaVentasFiltrada.Count)
                {
                    Venta ventaSeleccionada = listaVentasFiltrada[e.RowIndex];
                    DetalleVenta detalleForm = new DetalleVenta(ventaSeleccionada);
                    detalleForm.ShowDialog();
                }
            }
        }

        private void TBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void TBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (TBuscarCliente.Text == "Buscar Cliente...")
            {
                TBuscarCliente.Text = "";
                TBuscarCliente.ForeColor = Color.FromArgb(224, 224, 224); // Color de texto normal
            }
        }

        private void TBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBuscarCliente.Text))
            {
                TBuscarCliente.Text = "Buscar Cliente...";
                TBuscarCliente.ForeColor = Color.Gray;
                AplicarFiltros(); // Recarga la lista (aplicando el filtro de fecha)
            }
        }

        private void IBtnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
