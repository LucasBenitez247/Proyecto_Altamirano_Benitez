using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class HistorialVentasUserControl : UserControl
    {
        public HistorialVentasUserControl()
        {
            InitializeComponent();
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
