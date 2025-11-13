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
    public partial class ListaProductos : Form
    {
        public event Action<Producto> productoSeleccionado;
        private List<Producto> listaProductos = new List<Producto>();
        private List<Categoria_producto> listaCategorias = new List<Categoria_producto>();
        private List<Estado_producto> listaEstados = new List<Estado_producto>();
        private List<Talle_producto> listaTalles = new List<Talle_producto>();
        public ListaProductos()
        {
            InitializeComponent();
            cargarProductos();
        }

        private void txtBuscador_TextChanged_1(object sender, EventArgs e)
        {
            string texto = System.Text.RegularExpressions.Regex.Replace(
                txtBuscador.Text.Trim().ToLower(), @"\s+", " ");

            dgvProductos.Rows.Clear();

            var listaFiltrada = listaProductos.Where(p =>
            {
                switch (cboBuscarPor.SelectedItem?.ToString())
                {
                    case "Nombre":
                        return !string.IsNullOrEmpty(p.Nombre_producto) &&
                               p.Nombre_producto.ToLower().Contains(texto);

                    case "Categoría":
                        var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == p.Categoria_producto);
                        return categoria != null &&
                               categoria.Descripcion_categoria.ToLower().Contains(texto);

                    case "Descripción":
                        var palabras = texto.Split(' ');
                        return !string.IsNullOrEmpty(p.Descripcion_producto) &&
                               palabras.All(palabra => p.Descripcion_producto.ToLower().Contains(palabra));


                    default:
                        return false;
                }
            }).ToList();

            foreach (var producto in listaFiltrada)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto);
                var estadoEncontrado = listaEstados.FirstOrDefault(est => est.Id_estado_producto == producto.Estado_producto);

                string nombreCategoria = categoria?.Descripcion_categoria ?? "Sin categoría";
                string nombreEstado = estadoEncontrado?.Descripcion_estado_producto ?? "Sin estado";

                dgvProductos.Rows.Add(
                    producto.Id_producto,
                    producto.Codigo_producto,
                    producto.Nombre_producto,
                    producto.Descripcion_producto,
                    nombreEstado,
                    producto.Precio_producto,
                    producto.Stock_producto,
                    nombreCategoria
                );
            }
        }


        private void cargarProductos()
        {
            dgvProductos.Rows.Clear();

            foreach (var producto in listaProductos)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto); // Buscar la categoría correspondiente
                var estado = listaEstados.FirstOrDefault(e => e.Id_estado_producto == producto.Estado_producto); // Buscar el estado correspondiente
                var talle = listaTalles.FirstOrDefault(t => t.Id_talle_producto == producto.Talle_producto); // Buscar el talle correspondiente

                string nombreCategoria = categoria != null ? categoria.Descripcion_categoria : "Sin categoría"; // Manejar caso de categoría no encontrada
                string nombreEstado = estado != null ? estado.Descripcion_estado_producto : "Sin estado"; // Manejar caso de estado no encontrado
                string nombreTalle = talle != null ? talle.Descripcion_talle : "Sin talle"; // Manejar caso de talle no encontrado

                // Agregar fila al DataGridView
                dgvProductos.Rows.Add(
                    producto.Id_producto,
                    producto.Codigo_producto,
                    producto.Nombre_producto,
                    producto.Descripcion_producto,
                    nombreEstado,
                    producto.Precio_producto,
                    producto.Stock_producto,
                    nombreCategoria,
                    nombreTalle
                );
            }
        }
        

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            inicializarControles(); // Inicializar controles del comboBox
            cargarDatos();
            cargarProductos();

        }

        private void inicializarControles()
        {
            // Configurar el ComboBox con las opciones "Producto" y "Fecha"
            cboBuscarPor.Items.Add("Nombre");
            cboBuscarPor.Items.Add("Categoría");
            cboBuscarPor.Items.Add("Descripción");
            cboBuscarPor.SelectedIndex = 0; // Seleccionar la primera opción por defecto

        }

        private void cargarDatos()
        {
            dgvProductos.AllowUserToAddRows = false;
            listaProductos = new CN_Producto().listarProductos();
            listaCategorias = new CN_Producto().obtenerCategoria();
            listaEstados = new CN_Producto().listarEstados();
            listaTalles = new CN_Producto().listarTalles();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var valorCelda = dgvProductos.Rows[e.RowIndex].Cells["idProducto"].Value?.ToString();

                if (int.TryParse(valorCelda, out int idProducto))
                {
                    Producto producto = listaProductos.FirstOrDefault(p => p.Id_producto == idProducto);

                    if (producto != null)
                    {
                        productoSeleccionado?.Invoke(producto); // Enviar el objeto completo
                        this.Close(); // Cerrar el formulario hijo
                    }
                }
            }
        }
    }
}
