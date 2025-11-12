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
        private int idProveedorSeleccionado;


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
            // Guarda el nro de orden
            int nroOrden;

            // Validar que haya productos en la compra
            if (dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la compra.");
                return;
            }

            // Validar número de orden
            if (!int.TryParse(TNroOrden.Text, out nroOrden))
            {
                MessageBox.Show("Ingrese un número de orden válido.");
                return;
            }
            // Crear instancia de CN_Compra
            CN_Compra negocio = new CN_Compra();

            // Verificar si el número de orden ya existe
            if (negocio.ExisteNroOrden(nroOrden))
            {
                MessageBox.Show("El número de orden ya existe. Ingrese uno diferente.");
                return;
            }

            // Crear la compra
            Compra compra = new Compra
            {
                Id_usuario = usuarioActual.Id_usuario,
                Id_proveedor = getIdProveedorSeleccionado(),
                Nro_orden = nroOrden,
                Fecha_compra = DateTime.Now,
                Detalle_compra = new List<Detalle_compra>()
            };

            float total = 0;

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                if (row.IsNewRow) continue;

                Detalle_compra detalle = new Detalle_compra
                {
                    Id_producto = Convert.ToInt32(row.Cells["idProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["CCantidad"].Value),
                    Precio_compra = Convert.ToSingle(row.Cells["CPrecioCompra"].Value) // ← precio unitario
                };

                // Calcular el total de la compra
                total += detalle.Cantidad * detalle.Precio_compra;

                //Agrega 1 detalle a la lista de detalles de la compra
                compra.Detalle_compra.Add(detalle);
            }

            // Asignar el total calculado a la compra
            compra.Total_compra = total;

            try
            {
                int idCompra = negocio.RegistrarCompra(compra);
                MessageBox.Show($"Compra registrada con éxito. ID generado: {idCompra}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message);
            }
        }


        private void IBtnBuscarProveedores_Click(object sender, EventArgs e)
        {
            
            Lista_de_proveedores lista_De_Proveedores = new Lista_de_proveedores();
            
            lista_De_Proveedores.IdSeleccionado += proveedor =>
            {
                TProveedor.Text = proveedor.Razon_social.ToString();
                setIdProveedorSeleccionado(proveedor.Id_proveedor);
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
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvCompras);

                fila.Cells[dgvCompras.Columns["idProducto"].Index].Value = productoGlobal.Id_producto;
                fila.Cells[dgvCompras.Columns["codProducto"].Index].Value = TCodProducto.Text;
                fila.Cells[dgvCompras.Columns["CProducto"].Index].Value = TProducto.Text;
                fila.Cells[dgvCompras.Columns["CPrecioCompra"].Index].Value = TPrecioCompra.Text;
                fila.Cells[dgvCompras.Columns["precioVenta"].Index].Value = TPrecioVenta.Text;
                fila.Cells[dgvCompras.Columns["CCantidad"].Index].Value = NUDCantidad.Value;
                fila.Cells[dgvCompras.Columns["CSubTotal"].Index].Value = subtotal.ToString("0.00");

                dgvCompras.Rows.Add(fila);


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

        private void TPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (Backspace), dígitos y un solo punto decimal
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return; // permitir
            }

            // Permitir un solo punto decimal y que no sea el primer carácter
            if (e.KeyChar == '.' && !TPrecioCompra.Text.Contains('.') && TPrecioCompra.SelectionStart > 0)
            {
                return; // permitir
            }

            // Bloquear todo lo demás (letras, espacios, símbolos)
            e.Handled = true;
        }

        private void TPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (Backspace), dígitos y un solo punto decimal
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return; // permitir
            }

            // Permitir un solo punto decimal y que no sea el primer carácter
            if (e.KeyChar == '.' && !TPrecioVenta.Text.Contains('.') && TPrecioVenta.SelectionStart > 0)
            {
                return; // permitir
            }

            // Bloquear todo lo demás (letras, espacios, símbolos)
            e.Handled = true;
        }

        private void TPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(TPrecioVenta.Text, out int precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a cero.");
                TPrecioVenta.Focus();
            }
        }

        private void TPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(TPrecioCompra.Text, out int precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a cero.");
                TPrecioCompra.Focus();
            }
        }

        public int getIdProveedorSeleccionado()
        {
            return idProveedorSeleccionado;
        }

        public void setIdProveedorSeleccionado(int idProveedor)
        {
            idProveedorSeleccionado = idProveedor;
        }

       
    }
}
