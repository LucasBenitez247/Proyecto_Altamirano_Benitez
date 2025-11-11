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
    public partial class ReportesUserControlAdministrador : UserControl
    {
        private List<Venta> listaReporteGlobal;
        public ReportesUserControlAdministrador()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            TBuscar.ForeColor = Color.Black;
            TBuscar.Text = "Buscar...";

            // Seleccionar "Vendedor" por defecto
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            // Conectar eventos
            this.IBtnBuscar.Click += new System.EventHandler(this.IBtnBuscar_Click); // Botón superior
            this.IBtnBuscar2.Click += new System.EventHandler(this.IBtnBuscar2_Click); // Botón de sub-filtro
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            this.TBuscar.Enter += new System.EventHandler(this.TBuscar_Enter);
            this.TBuscar.Leave += new System.EventHandler(this.TBuscar_Leave);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.TBuscar_TextChanged); // Re-filtra si cambia el combo

        }

        private void IBtnBuscar2_Click(object sender, EventArgs e)
        {
            AplicarFiltroEnMemoria();
        }

        private void IBtnBuscar_Click(object sender, EventArgs e)
        {
            // El .Date quita la hora, asegurando que empezamos desde las 00:00:00
            DateTime fechaInicio = DtpFechaInicio.Value.Date;
            // El .AddDays(1).AddTicks(-1) asegura que incluimos hasta las 23:59:59 de ese día
            DateTime fechaFin = DtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);

            //  Consultar la Base de Datos
            try
            {
                CN_Venta cnVenta = new CN_Venta();
                listaReporteGlobal = cnVenta.ListarReporte(fechaInicio, fechaFin);

                if (listaReporteGlobal == null)
                {
                    MessageBox.Show("No se pudieron cargar los datos del reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listaReporteGlobal = new List<Venta>(); // Evita que sea nulo
                }

                // 2. Aplicar el filtro de texto (si hay algo escrito)
                AplicarFiltroEnMemoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltroEnMemoria()
        {
            if (listaReporteGlobal == null) return; // No hacer nada si la lista principal está vacía

            string textoBusqueda = TBuscar.Text.ToLower().Trim();
            string criterio = comboBox1.SelectedItem.ToString();
            List<Venta> listaFiltrada;

            // Si el texto está vacío o es el placeholder, mostrar todo
            if (string.IsNullOrWhiteSpace(textoBusqueda) || textoBusqueda == "buscar...")
            {
                listaFiltrada = listaReporteGlobal;
            }
            else
            {
                // Aplicar filtro según el ComboBox
                if (criterio == "Vendedor")
                {
                    listaFiltrada = listaReporteGlobal.Where(v =>
                        v.Nombre_usuario.ToLower().Contains(textoBusqueda) ||
                        v.Apellido_usuario.ToLower().Contains(textoBusqueda)
                    ).ToList();
                }
                else // (criterio == "Cliente")
                {
                    listaFiltrada = listaReporteGlobal.Where(v =>
                        v.Nombre_cliente.ToLower().Contains(textoBusqueda) ||
                        v.Apellido_cliente.ToLower().Contains(textoBusqueda)
                    ).ToList();
                }
            }
            CargarGrilla(listaFiltrada);
        }

        private void CargarGrilla(List<Venta> lista)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Texto negro para legibilidad

            if (lista == null) return;

            foreach (var venta in lista)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    venta.Fecha_venta.ToString("dd/MM/yyyy"), // CFecha
                    venta.Total_venta.ToString("0.00"), // CMonto
                    $"{venta.Nombre_usuario} {venta.Apellido_usuario}", // CVendedor
                    $"{venta.Nombre_cliente} {venta.Apellido_cliente}" // CCliente
                });
            }
        }

        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroEnMemoria();
        }

        private void TBuscar_Enter(object sender, EventArgs e)
        {
            if (TBuscar.Text == "Buscar...")
            {
                TBuscar.Text = "";
                TBuscar.ForeColor = Color.Black;
            }
        }

        private void TBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBuscar.Text))
            {
                TBuscar.Text = "Buscar...";
                TBuscar.ForeColor = Color.Black;
                AplicarFiltroEnMemoria(); // Vuelve a mostrar todo
            }
        }

        private void ReportesUserControlAdministrador_Load(object sender, EventArgs e)
        {
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;
        }
    }
}
