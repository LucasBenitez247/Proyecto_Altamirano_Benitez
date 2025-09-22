using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class VentasVendedorUserControl : UserControl
    {
        public VentasVendedorUserControl()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            string connectionString = @"Server=localhost;Database=BD_SISTEMA_VENTA;Trusted_Connection=True;";
            //imagen_producto,
            string query = "SELECT  nombre_producto, precio_producto, stock_producto FROM productos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // No crear columnas automáticas
                    dataGridView2.AutoGenerateColumns = false;

                    // Mapear columnas existentes con las de la BD
                   // DWCImagen.DataPropertyName = "imagen_producto";
                    DWCNombre.DataPropertyName = "nombre_producto";
                    DWCPrecio.DataPropertyName = "precio_producto";
                    DWCStock.DataPropertyName = "stock_producto";

                    // Asignar el DataTable al DataGridView
                    dataGridView2.DataSource = dt;

                    // Formatear precio como moneda
                    DWCPrecio.DefaultCellStyle.Format = "C2";

                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }
        private void VentasVendedorUserControl_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void IBtnBuscarClientes_Click(object sender, EventArgs e)
        {
            BuscarClientes buscarClientes = new BuscarClientes();
            buscarClientes.ShowDialog();
        }
    }
}
