using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class DetalleCompraForm : Form
    {
        private int idCompra;
        public DetalleCompraForm(int idCompra)
        {
            InitializeComponent();
            this.setIdCompra(idCompra);
        }

        private void DetalleCompraForm_Load(object sender, EventArgs e)
        {
            cargarCompra(getIdCompra());
            var detalles = new CN_Compra().ObtenerDetalleCompra(getIdCompra());
            dgvDetalle.Rows.Clear();

            foreach (var item in detalles)
            {
                dgvDetalle.Rows.Add(
                    item.Nombre_producto,
                    item.Cantidad,
                    item.Precio_compra,
                    item.Cantidad * item.Precio_compra
                );
            }
        }

        private void cargarCompra(int IdCompra)
        {
            Compra compra = new CN_Compra().ObtenerCompras().FirstOrDefault(c => c.Id_compra == IdCompra);
            if (compra != null)
            {
                txtNroOrden.Text = compra.Nro_orden.ToString();
                txtRazonSocial.Text = compra.Nombre_proveedor;
                txtNroDocumento.Text = string.Format("{0:N0}", compra.Nro_documento_proveedor);
                txtFecha.Text = compra.Fecha_compra.ToString("dd/MM/yyyy");
                txtTotalCompra.Text = compra.Total_compra.ToString("C2", new CultureInfo("es-AR"));
            }
        }

        public void setIdCompra(int p_idCompra)
        {
            this.idCompra = p_idCompra;
        }

        public int getIdCompra()
        {
            return this.idCompra;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
