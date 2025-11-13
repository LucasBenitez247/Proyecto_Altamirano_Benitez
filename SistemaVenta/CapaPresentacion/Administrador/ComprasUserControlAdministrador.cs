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
            TBuscar.Focus();
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
            cboBuscarPor.SelectedIndex = 0;
        }

        private void CargarReporteCompras(DateTime fechaInicio, DateTime fechaFin, string criterio, string textoBuscar)
        {
            dgvCompras.Rows.Clear();
            CN_Compra negocio = new CN_Compra();
            List<Compra> listaCompra = negocio.obtenerComprasPorFecha(fechaInicio, fechaFin);

            IEnumerable<Compra> listaFiltrada = listaCompra;

            if (criterio != "todos" && !string.IsNullOrWhiteSpace(textoBuscar))
            {
                switch (criterio)
                {
                    case "proveedor":
                        listaFiltrada = listaFiltrada.Where(r =>
                        !string.IsNullOrWhiteSpace(r.Nombre_proveedor) &&
                        Normalizar(r.Nombre_proveedor).Contains(Normalizar(textoBuscar)));

                        break;
                    case "usuario":
                        listaFiltrada = listaFiltrada.Where(r => r.Nombre_usuario?.ToLower().Contains(textoBuscar) == true);
                        break;
                    case "nro. orden":
                        listaFiltrada = listaFiltrada.Where(r => r.Nro_orden.ToString().Contains(textoBuscar));
                        break;
                    case "total compra":
                        if (decimal.TryParse(textoBuscar, out decimal total))
                        {
                            listaFiltrada = listaFiltrada.Where(r =>
                                Math.Round((decimal)r.Total_compra, 2) == Math.Round(total, 2));
                        }
                        else
                        {
                            MessageBox.Show("Total Compra debe ser un número válido.");
                            return;
                        }
                        break;
                }
            }

            foreach (Compra compra in listaFiltrada)
            {
                dgvCompras.Rows.Add(new object[]
                {
                    compra.Id_compra,
            compra.Fecha_compra.ToString("dd/MM/yyyy"),
           compra.Nro_orden,
              compra.Nombre_proveedor,
              compra.Nombre_usuario,
                compra.Total_compra.ToString("F2"),
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
        
        private void dgvCompras_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCompras.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int idCompra = Convert.ToInt32(dgvCompras.Rows[e.RowIndex].Cells["CIDCompra"].Value);
                var detalleForm = new DetalleCompraForm(idCompra);
                detalleForm.ShowDialog();
            }
        }

        // Método para normalizar texto (eliminar acentos y convertir a minúsculas)
        private string Normalizar(string texto)
        {
            return new string(texto
                .Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray())
                .ToLower()
                .Trim();
        }


        private void ComprasUserControlAdministrador_ImeModeChanged(object sender, EventArgs e)
        {

        }
    }

}

