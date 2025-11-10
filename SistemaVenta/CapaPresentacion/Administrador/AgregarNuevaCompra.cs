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
    public partial class AgregarNuevaCompra : Form
    {
        private Producto productoGlobal = new Producto();
        private float total;
        private Usuario usuarioActual;


        public AgregarNuevaCompra(Usuario pUsuario = null)
        {
            InitializeComponent();
            this.setUsuarioActual(pUsuario);
            setTotalCompra(0);
            MessageBox.Show("Usuario actual: " + usuarioActual?.Nombre_usuario);
        }

        public void setUsuarioActual(Usuario usuario)
        {
            this.usuarioActual = usuario;
        }
        private float getTotalCompra()
        {
            return total;
        }

        private void setTotalCompra(float value)
        {
            total = value;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay compras para registrar.");
                return;
            }

            CN_Compra negocio = new CN_Compra();
            List<Compra> listaCompras = new List<Compra>();

            // Validar existencia en la base de datos
           
            /*
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                
                Compra compra = new Compra
                {
                    Id_producto = Convert.ToInt32(row.Cells["Id_producto"].Value),
                    Nro_orden = Convert.ToInt32(row.Cells["Nro_orden_compra"].Value),
                    Id_proveedor = row.Cells["Proveedor"].Value.ToString(),
                    Id_usuario = usuarioActual.Id_usuario,
                    Fecha_compra = DateTime.Now,
                    Precio_compra = Convert.ToSingle(row.Cells["Precio_compra"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Total_compra = 
                };
                listaCompras.Add(compra);
            }*/
        }

        private void IBtnBuscarProveedores_Click(object sender, EventArgs e)
        {
            
            Lista_de_proveedores lista_De_Proveedores = new Lista_de_proveedores();
            
            lista_De_Proveedores.IdSeleccionado += proveedor =>
            {
                TProveedor.Text = proveedor.Razon_social.ToString();
            };
            lista_De_Proveedores.ShowDialog();
        }

        private void AgregarNuevaCompra_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscarCodProducto_Click(object sender, EventArgs e)
        {
            ListaProductos listaProductos = new ListaProductos();
            listaProductos.productoSeleccionado += producto =>
            {
                productoGlobal = producto;
                TCodProducto.Text = producto.Codigo_producto.ToString();
                TProducto.Text = producto.Nombre_producto.ToString();
            };
            listaProductos.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Compra negocio = new CN_Compra();

            // Validar que el texto sea un número entero
            if (!int.TryParse(TNroOrden.Text.Trim(), out int nroOrden))
            {
                MessageBox.Show("Ingrese un número de orden válido.");
                return;
            }

            // Validar precio de compra
            if (!float.TryParse(TPrecioCompra.Text.Trim(), out float precioCompra))
            {
                MessageBox.Show("Ingrese un precio de compra válido.");
                return;
            }

            float subtotal = precioCompra * Convert.ToSingle(NUDCantidad.Value);
            setTotalCompra(getTotalCompra() + subtotal);

            if (validarCampos())
            {
                dgvCompras.Rows.Add(
                    productoGlobal.Id_producto,
                    TCodProducto.Text,
                    TProducto.Text,
                    TProveedor.Text,
                    TPrecioVenta.Text,
                    TPrecioCompra.Text,
                    NUDCantidad.Value.ToString(),
                    subtotal.ToString("0.00")
                );

                MessageBox.Show("Compra agregada exitosamente.");
                TTotalPagar.Text = getTotalCompra().ToString("0.00");
                limpiarCampos();
            }
        }

        private bool validarCampos()
        {
            if(TNroOrden.Text == "" ||
               TProveedor.Text == "" ||
               TCodProducto.Text == "" ||
               TProducto.Text == "" ||
               TPrecioCompra.Text == "" ||
               TPrecioVenta.Text == "" ||
               NUDCantidad.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return false;
            } 
            return true;
        }

        private void limpiarCampos()
        {
            
            TProveedor.Clear();
            TCodProducto.Clear();
            TProducto.Clear();
            TPrecioCompra.Clear();
            TPrecioVenta.Clear();
            NUDCantidad.Value = 1;
        }

        private void TNroOrden_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNroOrden.Text))
            {
                errorProvider1.SetError(TNroOrden, "Debe completar este campo.");
            }
            else
            {
                errorProvider1.SetError(TNroOrden, "");
            }
        }

        private void TNroOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada

            }
        }

        private void TPrecioCompra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TPrecioCompra.Text))
            {
                errorProvider1.SetError(TNroOrden, "Debe ingresar el Precio de Compra!.");
            }
            else
            {
                errorProvider1.SetError(TNroOrden, "");
            }
        }

        private void TProveedor_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TProveedor.Text))
            {
                errorProvider1.SetError(TProveedor, "Debe seleccionar un proveedor.");
            }
            else
            {
                errorProvider1.SetError(TProveedor, "");
            }
        }

        private void TCodProducto_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TCodProducto.Text))
            {
                errorProvider1.SetError(TCodProducto, "Debe seleccionar un producto.");
            }
            else
            {
                errorProvider1.SetError(TCodProducto, "");
            }
        }

        private void TPrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TPrecioVenta.Text))
            {
                errorProvider1.SetError(TPrecioVenta, "Debe ingresar el Precio de Venta!.");
            }
            else
            {
                errorProvider1.SetError(TPrecioVenta, "");
            }
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no sea encabezado y que sea la columna del botón
            if (e.RowIndex >= 0 && dgvCompras.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta fila?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Restar el subtotal eliminado al total
                    float subtotalEliminado = Convert.ToSingle(dgvCompras.Rows[e.RowIndex].Cells["CSubTotal"].Value);
                    setTotalCompra(getTotalCompra() - subtotalEliminado);
                    TTotalPagar.Text = getTotalCompra().ToString("0.00");

                    // Eliminar la fila
                    dgvCompras.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
