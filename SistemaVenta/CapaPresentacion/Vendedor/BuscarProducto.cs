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

namespace CapaPresentacion.Vendedor
{

    public partial class BuscarProducto : Form
    {
        public event EventHandler<Producto> ProductoSeleccionado;

        private List<Producto> listaProductos = new List<Producto>();
        private List<Categoria_producto> listaCategorias = new List<Categoria_producto>();
        private List<Estado_producto> listaEstados = new List<Estado_producto>();
        public BuscarProducto()
        {
            InitializeComponent(); 
            cargarDatos();  
            CargarProductos();

            // Conectamos los eventos para manejar el texto placeholder
            this.TBuscarCliente.Enter += new System.EventHandler(this.TBuscarCliente_Enter);
            this.TBuscarCliente.Leave += new System.EventHandler(this.TBuscarCliente_Leave);
        }
        private void CargarProductos()
        {
         
            dgvProductos.Rows.Clear();

            foreach (var producto in listaProductos)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto); // Buscar la categoría correspondiente
                var estado = listaEstados.FirstOrDefault(e => e.Id_estado_producto == producto.Estado_producto); // Buscar el estado correspondiente

                string nombreCategoria = categoria != null ? categoria.Descripcion_categoria : "Sin categoría"; // Manejar caso de categoría no encontrada
                string nombreEstado = estado != null ? estado.Descripcion_estado_producto : "Sin estado"; // Manejar caso de estado no encontrado

                // Agregar fila al DataGridView
                dgvProductos.Rows.Add(
                    producto.Id_producto,
                    producto.Nombre_producto,
                    producto.Descripcion_producto,
                    nombreEstado,
                    producto.Precio_producto,
                    producto.Stock_producto,
                    nombreCategoria
                );
            }
        }
        private void cargarDatos()
        {
            dgvProductos.AllowUserToAddRows = false;
            listaProductos = new CN_Producto().listarProductos();
            listaCategorias = new CN_Producto().obtenerCategoria();
            listaEstados = new CN_Producto().listarEstados();
        }

        private void IBtnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar clic en encabezado
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                try
                {
                    
                    Producto productoSeleccionado = new Producto
                    {
                        Id_producto = Convert.ToInt32(fila.Cells["idProducto"].Value ?? 0),     
                        Nombre_producto = fila.Cells["nombre"].Value?.ToString() ?? "", 
                        Precio_producto = Convert.ToDecimal(fila.Cells["precio"].Value ?? 0),
                        Descripcion_producto = fila.Cells["descripcion"].Value?.ToString() ?? "", 
                        Stock_producto = Convert.ToInt32(fila.Cells["stock"].Value ?? 0)         
                    };

                    // Disparar el evento
                    OnProductoSeleccionado(productoSeleccionado);

                    // Cerrar el formulario
                    this.Close();
                }
                catch (KeyNotFoundException knfEx) // Error común si el nombre de la columna es incorrecto
                {
                    MessageBox.Show($"Error: No se encontró la columna con el nombre '{knfEx.Message}'. Verifica la propiedad 'Name' de las columnas en el diseñador del DataGridView y compárala con el código.",
                                   "Error Nombre Columna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidCastException castEx)
                {
                    MessageBox.Show($"Error al convertir el valor de una celda. Verifica los tipos de datos.\nDetalle: {castEx.Message}", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        protected virtual void OnProductoSeleccionado(Producto producto)
        {
            ProductoSeleccionado?.Invoke(this, producto);
        }

        private void TBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = TBuscarCliente.Text.ToLower().Trim();

            // Evitar filtrar si el texto es el placeholder
            if (textoBusqueda == "buscar productos...")
            {
                return;
            }

            // 1. Filtrar la lista en memoria (listaProductos)
            List<Producto> productosFiltrados = listaProductos.Where(p =>
                p.Nombre_producto.ToLower().Contains(textoBusqueda)
            ).ToList();

            // 2. Limpiar la grilla
            dgvProductos.Rows.Clear();

            // 3. Cargar la grilla con los productos filtrados
            foreach (var producto in productosFiltrados)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto);
                var estado = listaEstados.FirstOrDefault(est => est.Id_estado_producto == producto.Estado_producto);

                string nombreCategoria = categoria != null ? categoria.Descripcion_categoria : "Sin categoría";
                string nombreEstado = estado != null ? estado.Descripcion_estado_producto : "Sin estado";

                dgvProductos.Rows.Add(
                    producto.Id_producto,
                    producto.Nombre_producto,
                    producto.Descripcion_producto,
                    nombreEstado,
                    producto.Precio_producto,
                    producto.Stock_producto,
                    nombreCategoria
                );
            }
        }

        private void TBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (TBuscarCliente.Text == "Buscar Productos...")
            {
                TBuscarCliente.Text = "";
                TBuscarCliente.ForeColor = Color.Black; // Cambia el color al escribir
            }
        }

        private void TBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBuscarCliente.Text))
            {
                TBuscarCliente.Text = "Buscar Productos...";
                TBuscarCliente.ForeColor = Color.Gray; // Color del placeholder
                CargarProductos(); // Vuelve a mostrar todos los productos si se vacía
            }
        }
    }
}

