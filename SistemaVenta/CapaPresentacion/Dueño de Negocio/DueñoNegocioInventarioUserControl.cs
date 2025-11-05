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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Dueño_de_Negocio
{
    public partial class DueñoNegocioInventarioUserControl : UserControl
    {
        public DueñoNegocioInventarioUserControl()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.DueñoNegocioInventarioUserControl_Load);
        }

        private void DueñoNegocioInventarioUserControl_Load(object sender, EventArgs e)
        {
            // Conectar el botón de búsqueda
            BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // Establecer fechas por defecto (ej. el último mes)
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;

            // Hacer que los TextBox sean de solo lectura
            TTotalProductos.ReadOnly = true;
            TStock.ReadOnly = true;

            // Cargar datos por primera vez
            CargarEstadisticas(DtpFechaInicio.Value, DtpFechaFin.Value);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DtpFechaInicio.Value.Date;
            DateTime fechaFin = DtpFechaFin.Value.Date.AddDays(1).AddTicks(-1); // Incluye todo el día final

            CargarEstadisticas(fechaInicio, fechaFin);
        }

        private void CargarEstadisticas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteProductoVendido> datos = new CN_Producto().GetProductosMasVendidos(fechaInicio, fechaFin);

            // Limpia los controles
            chart1.Series.Clear();
            TTotalProductos.Text = "N/A";
            TStock.Text = "N/A";

            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas para este rango de fechas.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Llena los paneles de resumen (Producto más vendido)
            if (datos.Count > 0)
            {
                TTotalProductos.Text = datos[0].Producto; // Muestra el nombre
                TStock.Text = datos[0].StockActual.ToString(); // Muestra el stock actual
            }

            // Llena el gráfico (Estadísticas de Inventario)
            chart1.ChartAreas[0].AxisX.Title = "Productos";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";

            Series serieVentas = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column // Gráfico de Columnas
            };

            foreach (var item in datos)
            {
                // Añadimos el producto (X) y la cantidad vendida (Y)
                serieVentas.Points.AddXY(item.Producto, item.Cantidad);
            }

            chart1.Series.Add(serieVentas);
        }
    }
}
