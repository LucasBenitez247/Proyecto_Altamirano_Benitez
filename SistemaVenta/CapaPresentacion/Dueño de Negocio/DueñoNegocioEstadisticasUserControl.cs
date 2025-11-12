using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Dueño_de_Negocio
{
    public partial class DueñoNegocioEstadisticasUserControl : UserControl
    {
        public DueñoNegocioEstadisticasUserControl()
        {
            InitializeComponent();
            
            this.Load += new System.EventHandler(this.DueñoNegocioEstadisticasUserControl_Load);
        }

        private void DueñoNegocioEstadisticasUserControl_Load(object sender, EventArgs e)
        {
            
            BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // Establecer fechas por defecto  (el último mes)
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;

            // Cargar datos por primera vez
            CargarDashboard(DtpFechaInicio.Value, DtpFechaFin.Value);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DtpFechaInicio.Value.Date;
            DateTime fechaFin = DtpFechaFin.Value.Date.AddDays(1).AddTicks(-1); // Incluye todo el día final

            CargarDashboard(fechaInicio, fechaFin);
        }

        private void CargarDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                CargarVentasPorMes(fechaInicio, fechaFin);
                CargarVentasPorDia(fechaInicio, fechaFin);
                CargarClientesFrecuentes(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cargaar ventas por mes
        private void CargarVentasPorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentasPorMes> datos = new CN_Venta().GetVentasPorMes(fechaInicio, fechaFin);

            // Limpiar gráfico
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisX.Title = "Mes";
            chart2.ChartAreas[0].AxisY.Title = "Total Ventas ($)";

            Series serieVentas = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column // Gráfico de Columnas
            };

            foreach (var item in datos)
            {
                serieVentas.Points.AddXY(item.Mes, item.Total);
            }

            chart2.Series.Add(serieVentas);
        }


        private void CargarVentasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentasPorDia> datos = new CN_Venta().GetVentasPorDia(fechaInicio, fechaFin);

            // Limpiar gráfico
            CDiasVentas.Series.Clear();
            CDiasVentas.ChartAreas[0].AxisX.Title = "Día de la Semana";
            CDiasVentas.ChartAreas[0].AxisY.Title = "Total Vendido ($)";

            Series serieDias = new Series("Total Vendido")
            {
                ChartType = SeriesChartType.Column // Gráfico de Columnas
            };

            foreach (var item in datos)
            {
                serieDias.Points.AddXY(item.DiaSemana, item.TotalVentas);
            }

            CDiasVentas.Series.Add(serieDias);
        }


        private void CargarClientesFrecuentes(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteClienteFrecuente> datos = new CN_Cliente().GetClientesFrecuentes(fechaInicio, fechaFin);

            // Limpiar lista
            LBClientesFrecuentes.Items.Clear();

            if (datos.Count == 0)
            {
                LBClientesFrecuentes.Items.Add("No hay datos...");
            }

            foreach (var item in datos)
            {
                LBClientesFrecuentes.Items.Add($"{item.Cliente} ({item.Compras} compras)");
            }
        }
    }
}
