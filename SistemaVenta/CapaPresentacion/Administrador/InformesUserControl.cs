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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Administrador
{
    public partial class InformesUserControl : UserControl
    {
        public InformesUserControl()
        {
            InitializeComponent();
            
        }

        private void MostrarGraficoEvolucionMensual(int anio)
        {
            var datos = new CN_Compra().ObtenerEvolucionMensual(anio);

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            chart1.ChartAreas.Add(new ChartArea("Área"));

            Series serie = new Series("Gasto mensual");
            serie.ChartType = SeriesChartType.Line;
            serie.MarkerStyle = MarkerStyle.Circle;

            foreach (var item in datos)
            {
                serie.Points.AddXY(item.Mes, item.TotalCompra);
            }

            chart1.Series.Add(serie);
            chart1.Titles.Add($"Evolución mensual del gasto - {anio}");
        }


        private void MostrarGraficoComprasPorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            CN_Compra negocio = new CN_Compra();
            var datos = negocio.ObtenerInformePorCategoria(fechaInicio, fechaFin);

            chartCompras.Series.Clear();
            chartCompras.Titles.Clear();
            chartCompras.ChartAreas.Clear();

            chartCompras.ChartAreas.Add(new ChartArea("Area"));

            Series serie = new Series("Total por categoría");
            serie.ChartType = SeriesChartType.Bar;

            foreach (var item in datos)
            {
                serie.Points.AddXY(item.Categoria, item.TotalCompra);
            }

            chartCompras.Series.Add(serie);
            chartCompras.Titles.Add("Total de compras por categoría");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            MostrarGraficoComprasPorCategoria(fechaInicio, fechaFin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = dtpCompraAnio.Value.Year;
            MostrarGraficoEvolucionMensual(anio);
        }

       
    }

}
