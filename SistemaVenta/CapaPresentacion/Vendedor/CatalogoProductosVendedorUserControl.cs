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
    public partial class CatalogoProductosVendedorUserControl : UserControl
    {
        public CatalogoProductosVendedorUserControl()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            string connectionString = @"Server=localhost;Database=BD_SISTEMA_VENTA;Trusted_Connection=True;";
            //imagen_producto,
            string query = "SELECT  nombre_producto, categoria_producto, descripcion_producto, precio_producto, stock_producto FROM productos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // No crear columnas automáticas
                    DGCatalogoProductos.AutoGenerateColumns = false;

                    // Mapear columnas existentes con las de la BD
                    CNombre.DataPropertyName = "nombre_producto";
                    CDescripcion.DataPropertyName = "descripcion_producto";
                    CCategoria.DataPropertyName = "categoria_producto";
                    CPrecio.DataPropertyName = "precio_producto";
                    CStock.DataPropertyName = "stock_producto";

                    // Asignar el DataTable al DataGridView
                    DGCatalogoProductos.DataSource = dt;

                    // Formatear precio como moneda
                    CPrecio.DefaultCellStyle.Format = "C2";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }

       
        private void CatalogoProductosVendedorUserControl_Load_1(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void DGCatalogoProductos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGCatalogoProductos.Columns[e.ColumnIndex].Name == "CCategoria" && e.Value != null)
            {
                int idCategoria = Convert.ToInt32(e.Value);

                switch (idCategoria)
                {
                    case 1:
                        e.Value = "Remeras";
                        break;
                    case 2:
                        e.Value = "Buzos";
                        break;
                    case 3:
                        e.Value = "Gorras";
                        break;
                    case 4:
                        e.Value = "Autos Coleccionables";
                        break;
                    default:
                        e.Value = "Sin Categoria";
                        break;
                }

                e.FormattingApplied = true;
            }
        }
    }
}
