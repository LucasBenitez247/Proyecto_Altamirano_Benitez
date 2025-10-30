using CapaEntidad;
using CapaNegocio; // <-- AÑADIDO: Necesario para CN_Venta
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class VentasVendedorUserControl : UserControl
    {
        int stockDisponible = 0;
        private int idClienteSeleccionado = 0; // <-- AÑADIDO: Para guardar el ID del cliente

        // --- IMPORTANTE ---
        // Debes pasar el objeto del usuario logueado a esta propiedad
        // desde tu formulario principal (PerfilVendedor) cuando este control se carga.
        public Usuario UsuarioActual { get; set; }

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

                // --- AÑADIDO ---
                // Guarda el ID del cliente seleccionado
                idClienteSeleccionado = cliente.Id_cliente;
            }
        }

        private void FormBusqueda_ProductoSeleccionado(object sender, Producto producto)
        {
            if (producto != null)
            {
                // Rellena los TextBox de producto
                TCodProducto.Text = producto.Id_producto.ToString();
                TProducto.Text = producto.Nombre_producto;
                TPrecioVenta.Text = producto.Precio_producto.ToString("0.00", CultureInfo.InvariantCulture); // Formato con 2 decimales
                stockDisponible = producto.Stock_producto; // Guarda el stock actual para validaciones futuras
                // Acciones adicionales después de seleccionar el producto
                NUDCantidad.Value = 1; // Resetea cantidad
                NUDCantidad.Select(); // Pone el foco en cantidad para añadir rápido
            }
        }

        // --- MÉTODO MODIFICADO ---
        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente
            if (string.IsNullOrWhiteSpace(TNombre.Text) || idClienteSeleccionado == 0)
            {
                MessageBox.Show("Busque y seleccione un cliente primero.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IBtnBuscarClientes.Focus();
                return;
            }

            // Validar que el usuario (vendedor) esté identificado
            if (UsuarioActual == null)
            {
                MessageBox.Show("Error: No se pudo identificar al vendedor logueado. Asegúrese de asignar el 'UsuarioActual' al cargar este control.", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Carrito no vacío
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos al carrito.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validar Total
            if (!decimal.TryParse(TTotal.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal totalVenta) || totalVenta <= 0)
            {
                MessageBox.Show("El total de la venta no es válido.", "Total Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar Pago
            if (!decimal.TryParse(TPagarCon.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal pagoCon) || pagoCon < totalVenta)
            {
                MessageBox.Show("El monto ingresado en 'Pagar con' es insuficiente o inválido.", "Monto de Pago Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TPagarCon.Focus(); // Pone el foco en el campo de pago
                return;
            }

            // --- Lógica para guardar la venta en la base de datos ---

            // 1. Crear el objeto Venta (Entidad)
            Venta nuevaVenta = new Venta()
            {
                Id_cliente = idClienteSeleccionado,
                Id_usuario = UsuarioActual.Id_usuario, // ID del vendedor logueado
                Tipo_documento = CBTipo_Documento.Text, // Asumiendo que usas el texto (Ej: "Boleta")
                Fecha_venta = DTPFecha_venta.Value, // Formato compatible con SQL
                Total_venta = totalVenta
            };

            // 2. Crear la lista de Detalles de Venta (Entidad)
            List<Detalle_venta> listaDetalles = new List<Detalle_venta>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                Detalle_venta detalle = new Detalle_venta()
                {
                    // Id_venta se asignará en la capa de datos (CD_Venta)
                    Id_producto = Convert.ToInt32(row.Cells["CCodigo"].Value),
                    Precio_unitario = Convert.ToDecimal(row.Cells["CPrecio"].Value, CultureInfo.InvariantCulture),
                    Cantidad = Convert.ToInt32(row.Cells["CCantidad"].Value)
                };
                listaDetalles.Add(detalle);
            }

            // 3. Llamar a la Capa de Negocio para registrar
            CN_Venta cnVenta = new CN_Venta();
            string mensajeError = string.Empty;

            bool resultado = cnVenta.RegistrarVenta(nuevaVenta, listaDetalles, out mensajeError);

            // 4. Mostrar resultado
            if (resultado)
            {
                MessageBox.Show($"Venta registrada exitosamente.\nTotal: {totalVenta:C}\nPaga con: {pagoCon:C}\nCambio: {TCambio.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioCompleto(); // Limpia todo el formulario
            }
            else
            {
                // Muestra el error específico devuelto por la capa de negocio/datos
                MessageBox.Show($"No se pudo registrar la venta:\n{mensajeError}", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecalcularTotalYCambio()
        {
            CalcularTotalCarrito(); // Calcula y actualiza TTotal
            CalcularCambio();      // Calcula y actualiza TCambio basado en el nuevo TTotal y TPagarCon
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
                // Usar CultureInfo.InvariantCulture para asegurar que el '.' sea el separador decimal
                if (!decimal.TryParse(TPrecioVenta.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out precioVenta))
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
                    int cantidadNuevaTotal = cantidadActual + cantidad; // Nueva cantidad total


                    if (cantidadNuevaTotal > stockDisponible)
                    {
                        MessageBox.Show($"No hay suficiente stock para agregar {cantidad} más. Disponible: {stockDisponible}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCamposProducto();
                        return;
                    }


                    decimal subtotalActual = precioVenta * cantidadNuevaTotal;

                    // Actualiza la fila existente
                    dataGridView1.Rows[filaExistenteIndex].Cells["CCantidad"].Value = cantidadNuevaTotal;
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

                // Recalcula el total del carrito y el cambio
                RecalcularTotalYCambio();

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
            stockDisponible = 0; // Resetea stock disponible
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

                if (row.Cells[nombreColumnaSubtotal].Value != null &&
                    decimal.TryParse(row.Cells[nombreColumnaSubtotal].Value.ToString(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal subtotal))
                {
                    total += subtotal;
                }
            }

            TTotal.Text = total.ToString("0.00", CultureInfo.InvariantCulture);
        }

        // --- AÑADIDO: Método para limpiar todo el formulario ---
        private void LimpiarFormularioCompleto()
        {
            // Limpiar campos de cliente
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            TDireccion.Clear();
            idClienteSeleccionado = 0; // Resetea el ID del cliente

            // Limpiar campos de producto
            LimpiarCamposProducto(); // Usa el método que ya tenías

            // Limpiar carrito (DataGridView)
            dataGridView1.Rows.Clear();

            // Limpiar totales y pago
            TTotal.Text = "0.00";
            TPagarCon.Clear();
            TCambio.Text = "0.00";

            // Opcional: Resetear fecha y tipo de documento si es necesario
            DTPFecha_venta.Value = DateTime.Now;
            CBTipo_Documento.SelectedIndex = -1; // O al índice 0 si tienes uno por defecto
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

            // Configuración inicial de campos
            TTotal.Text = "0.00";
            TCambio.Text = "0.00";
            CBTipo_Documento.SelectedIndex = 0; // Selecciona "Boleta" por defecto si es el único item
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
                        // Recalcular total y cambio después de eliminar
                        RecalcularTotalYCambio();
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

        private void TPagarCon_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            // Intenta convertir el texto de TTotal a decimal
            // Usamos CultureInfo.InvariantCulture para asegurar que use '.' como separador decimal
            if (!decimal.TryParse(TTotal.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal totalAPagar))
            {
                TCambio.Clear(); // Si el total no es válido, limpia el cambio
                return;
            }

            // Intenta convertir el texto de TPagarCon a decimal
            if (decimal.TryParse(TPagarCon.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal pagoCon))
            {
                // Verifica si el monto pagado es suficiente
                if (pagoCon >= totalAPagar)
                {
                    decimal cambio = pagoCon - totalAPagar;
                    // Muestra el cambio formateado con dos decimales
                    TCambio.Text = cambio.ToString("0.00", CultureInfo.InvariantCulture);
                }
                else
                {
                    // Si no es suficiente, muestra 0.00
                    TCambio.Text = "0.00";

                }
            }
            else
            {
                // Si el monto pagado no es un número válido, limpia el cambio o muestra 0.00
                TCambio.Text = "0.00";
            }
        }
    }
}