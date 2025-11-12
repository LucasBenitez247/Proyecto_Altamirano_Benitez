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
    public partial class ComprasUserControlAdministrador : UserControl
    {
        private Usuario usuarioActual;
        public ComprasUserControlAdministrador(Usuario usuario)
        {
            InitializeComponent();
            this.setUsuario(usuario);
        }

        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            AgregarNuevaCompra agregarCompraForm = new AgregarNuevaCompra(usuarioActual);
            agregarCompraForm.ShowDialog();

        }

        public void setUsuario(Usuario usuario)
        {
            this.usuarioActual = usuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IBtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);

            string criterio = cboBuscarPor.SelectedItem?.ToString()?.Trim().ToLower();
            string textoBuscar = TBuscar.Text.Trim();

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                return;
            }

            if (criterio != "todos")
            {
                if (string.IsNullOrWhiteSpace(textoBuscar))
                {
                    MessageBox.Show("El campo de búsqueda no puede estar vacío.");
                    return;
                }

                if (criterio == "nro. orden" || criterio == "total compra")
                {
                    if (!textoBuscar.All(char.IsDigit))
                    {
                        MessageBox.Show("Solo se permiten números para el criterio seleccionado.");
                        return;
                    }
                }
                else
                {
                    if (!textoBuscar.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("Solo se permiten letras para el criterio seleccionado.");
                        return;
                    }
                }
            }

            CargarReporteCompras(fechaInicio, fechaFin, criterio, textoBuscar.ToLower());
        }




        private void ComprasUserControlAdministrador_Load(object sender, EventArgs e)
        {

            panel2.Size = new Size(2000, 500); // Ajustá según tu diseño
            
            dgvCompras.ScrollBars = ScrollBars.Both;
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.ReadOnly = true;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.MultiSelect = false;


            panel2.AutoScroll = true;

        }

        private void CargarReporteCompras(DateTime fechaInicio, DateTime fechaFin, string criterio, string textoBuscar)
        {
            dgvCompras.Rows.Clear();
            CN_Compra negocio = new CN_Compra();
            List<ReporteCompra> listaReporte = negocio.ObtenerReporte(fechaInicio, fechaFin);

            IEnumerable<ReporteCompra> listaFiltrada = listaReporte;

            if (criterio != "todos" && !string.IsNullOrWhiteSpace(textoBuscar))
            {
                switch (criterio)
                {
                    case "proveedor":
                        listaFiltrada = listaFiltrada.Where(r => r.RazonSocialProveedor?.ToLower().Contains(textoBuscar) == true);
                        break;
                    case "usuario":
                        listaFiltrada = listaFiltrada.Where(r => r.nombreUsuario?.ToLower().Contains(textoBuscar) == true);
                        break;
                    case "nro. orden":
                        listaFiltrada = listaFiltrada.Where(r => r.NroOrden.ToString().Contains(textoBuscar));
                        break;
                    case "producto":
                        listaFiltrada = listaFiltrada.Where(r => r.nombreProducto?.ToLower().Contains(textoBuscar) == true);
                        break;
                    case "total compra":
                        if (decimal.TryParse(textoBuscar, out decimal total))
                            listaFiltrada = listaFiltrada.Where(r => r.totalCompra == total);
                        else
                        {
                            MessageBox.Show("Total Compra debe ser un número válido.");
                            return;
                        }
                        break;
                }
            }

            foreach (ReporteCompra reporte in listaFiltrada)
            {
                dgvCompras.Rows.Add(new object[]
                {
            reporte.FechaRegistro,
            reporte.NroOrden,
            reporte.totalCompra,
            reporte.nombreUsuario,
            reporte.RazonSocialProveedor,
            reporte.codigoProducto,
            reporte.nombreProducto,
            reporte.cantidadProducto,
            reporte.categoriaProducto,
            reporte.precioCompra,
            reporte.subtotal
                });
            }
        }

        private void cboBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cboBuscarPor.SelectedItem?.ToString()?.Trim().ToLower();

            if (criterio == "todos")
            {
                TBuscar.Text = "";
                TBuscar.Enabled = false;
            }
            else
            {
                TBuscar.Enabled = true;
            }
        }
       
}
}
