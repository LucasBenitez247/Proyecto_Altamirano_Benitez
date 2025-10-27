using CapaEntidad;
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
        int stockDisponible = 0;
        public VentasVendedorUserControl()
        {
            InitializeComponent();
        }

       
        private void IBtnBuscarClientes_Click(object sender, EventArgs e)
        {
            using (BuscarClientes buscarClientes = new BuscarClientes())
            {
                //  Suscribe el método local al evento del otro formulario 
                buscarClientes.ClienteSeleccionado += FormBusqueda_ClienteSeleccionado;

                // Mostrar el formulario como un diálogo modal
                buscarClientes.ShowDialog(this);

                //  Desuscribirse después de que se cierre
                buscarClientes.ClienteSeleccionado -= FormBusqueda_ClienteSeleccionado;
            }
        }
        private void IBtnBuscarProductos_Click(object sender, EventArgs e)
        {
            using (BuscarProducto formBusquedaProd = new BuscarProducto())
            {
                // Suscríbe al evento ProductoSeleccionado ANTES de mostrar
                formBusquedaProd.ProductoSeleccionado += FormBusqueda_ProductoSeleccionado;
                formBusquedaProd.ShowDialog(this); // Muestra como diálogo
                // Desuscríbe después de cerrar
                formBusquedaProd.ProductoSeleccionado -= FormBusqueda_ProductoSeleccionado;
            }
        }
        // Este es el método que se ejecutará cuando se seleccione un cliente en el otro form
        private void FormBusqueda_ClienteSeleccionado(object sender, Cliente cliente)
        {
            if (cliente != null)
            {
                // Actualiza los TextBox en ESTE UserControl con los datos recibidos
                TNombre.Text = cliente.Nombre_cliente;
                TApellido.Text = cliente.Apellido_cliente;
                TDni.Text = cliente.Dni_cliente;
                TDireccion.Text = cliente.Direccion_cliente;
                
            }
        }

        private void FormBusqueda_ProductoSeleccionado(object sender, Producto producto)
        {
            if (producto != null)
            {
                // Rellena los TextBox de producto
                TCodProducto.Text = producto.Id_producto.ToString();
                TProducto.Text = producto.Nombre_producto;
                TPrecioVenta.Text = producto.Precio_producto.ToString("0.00"); // Formato con 2 decimales
                stockDisponible = producto.Stock_producto; // Guarda el stock actual para validaciones futuras
                // Acciones adicionales después de seleccionar el producto
                NUDCantidad.Value = 1; // Resetea cantidad
                NUDCantidad.Select(); // Pone el foco en cantidad para añadir rápido
            }
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TDireccion.Text) ||   
                string.IsNullOrWhiteSpace(TTotal.Text)
                )
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            // Valida que se haya seleccionado un producto (TCodProducto no esté vacío)
            // y la cantidad sea válida (mayor que 0)
            if (string.IsNullOrWhiteSpace(TCodProducto.Text) || !int.TryParse(TCodProducto.Text, out int idProdSeleccionado) || idProdSeleccionado <= 0)
            {
                MessageBox.Show("Busque y seleccione un producto válido primero.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Poner foco en el botón de búsqueda
                // IBtnBuscarProductos.Focus();
                return;
            }

            if (NUDCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor que cero.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDCantidad.Focus();
                return;
            }
            
           //Valida stock
            if (NUDCantidad.Value > stockDisponible)
            {
                 MessageBox.Show($"No hay suficiente stock. Disponible: {stockDisponible}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            

            try
            {
                // Obtiene datos del producto seleccionado (de los TextBoxes)
                int idProducto = idProdSeleccionado; // Ya validado arriba
                string nombreProducto = TProducto.Text;
                decimal precioVenta;
                if (!decimal.TryParse(TPrecioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("El precio del producto no es válido.", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int cantidad = (int)NUDCantidad.Value;
                decimal subtotal = precioVenta * cantidad;

                // --- Lógica para añadir o actualizar en el carrito (dataGridView) ---

                bool productoYaExiste = false;
                int filaExistenteIndex = -1;
               
                string nombreColumnaCodigo = "CCodigo"; 

                // Busca si el producto ya está en el carrito
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Ignora la fila para agregar nuevos datos
                    if (row.Cells[nombreColumnaCodigo].Value != null &&
                        Convert.ToInt32(row.Cells[nombreColumnaCodigo].Value) == idProducto)
                    {
                        productoYaExiste = true;
                        filaExistenteIndex = row.Index;
                        break;
                    }
                }

                if (productoYaExiste)
                {
                    
                    int cantidadActual = Convert.ToInt32(dataGridView1.Rows[filaExistenteIndex].Cells["CCantidad"].Value);
                    cantidadActual += cantidad;
                    decimal subtotalActual = precioVenta * cantidadActual;

                    // Actualiza la fila existente
                    dataGridView1.Rows[filaExistenteIndex].Cells["CCantidad"].Value = cantidadActual;
                    dataGridView1.Rows[filaExistenteIndex].Cells["CSubTotal1"].Value = subtotalActual;
                }
                else
                {
                    
                    dataGridView1.Rows.Add(new object[] {
                        nombreProducto,         // CNombre
                        idProducto,             // CCodigo
                        precioVenta,            // CPrecio
                        cantidad,               // CCantidad
                        subtotal,               // CSubTotal1
                        "Eliminar"              // CEliminar 
                    });
                }

                // Limpia los campos de producto para la siguiente selección
                LimpiarCamposProducto();

                // Recalcula el total del carrito
                CalcularTotalCarrito();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato del precio o la cantidad: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto al carrito: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        // Limpia los campos de selección de producto
        private void LimpiarCamposProducto()
        {
            TCodProducto.Clear();
            TProducto.Clear();
            TPrecioVenta.Clear();
            NUDCantidad.Value = 1; 
            IBtnBuscarProductos.Focus(); // Pone el foco de nuevo en el botón buscar producto
        }

        // Calcula y muestra el total del carrito
        private void CalcularTotalCarrito()
        {
            decimal total = 0;
            
            string nombreColumnaSubtotal = "CSubTotal1"; 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Evita errores si la fila es la de "nueva fila"
                if (row.IsNewRow) continue;

                if (row.Cells[nombreColumnaSubtotal].Value != null && decimal.TryParse(row.Cells[nombreColumnaSubtotal].Value.ToString(), out decimal subtotal))
                {
                    total += subtotal;
                }
            }
           
            TTotal.Text = total.ToString("0.00");
        }

        private void VentasVendedorUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            if (dataGridView1.Columns["CEliminar"] is DataGridViewButtonColumn buttonColumn)
            {
                // Hace que el botón sea plano para mostrar mejor el color de fondo
                buttonColumn.FlatStyle = FlatStyle.Flat;

                // Establece el color de fondo de la celda/botón a rojo
                buttonColumn.DefaultCellStyle.BackColor = Color.Red;

                // Establece el color del texto del botón a blanco para mejor contraste
                buttonColumn.DefaultCellStyle.ForeColor = Color.White;

                //  Establece colores para cuando la celda/botón está seleccionada
                buttonColumn.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                buttonColumn.DefaultCellStyle.SelectionForeColor = Color.White;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string nombreColumnaEliminar = "CEliminar"; 

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == nombreColumnaEliminar)
            {
                // Pregunta confirmación 
                if (MessageBox.Show("¿Quitar este producto del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Evita eliminar la fila "nueva" si existe
                    if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        CalcularTotalCarrito(); // Recalcular total después de eliminar
                    }
                }
            }

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el mouse está sobre una fila válida y sobre la columna del botón eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["CEliminar"].Index)
            {
                // Cambia el cursor del DataGridView a Mano
                dataGridView1.Cursor = Cursors.Hand;
  
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Siempre restaura el cursor a su valor predeterminado al salir de una celda
            dataGridView1.Cursor = Cursors.Default;
        }
    }
}
