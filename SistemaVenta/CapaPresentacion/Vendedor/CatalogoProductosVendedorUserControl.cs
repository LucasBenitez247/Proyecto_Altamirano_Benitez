using CapaEntidad;
using CapaNegocio;
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
        private List<Producto> listaProductos = new List<Producto>();
        private List<Categoria_producto> listaCategorias = new List<Categoria_producto>();
        private List<Estado_producto> listaEstados = new List<Estado_producto>();
        public CatalogoProductosVendedorUserControl()
        {
            InitializeComponent();
            dgvProductos.AllowUserToAddRows = false; // Desactivar fila vacía
            TBBuscar.ForeColor = Color.Gray; // Color del placeholder
            CBBuscarPor.SelectedIndex = 0; // Pone "Nombre" como selección por defecto

            // Cargar datos y conectar eventos
            cargarDatos();
            CargarGrilla(listaProductos); // Carga inicial con todos los productos

            // --- CONECTAR EVENTOS ---
            this.TBBuscar.Enter += new System.EventHandler(this.TBBuscar_Enter);
            this.TBBuscar.Leave += new System.EventHandler(this.TBBuscar_Leave);
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            this.CBBuscarPor.SelectedIndexChanged += new System.EventHandler(this.CBBuscarPor_SelectedIndexChanged);
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            cargarDatos();
            CargarProductos();
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
        private void CargarGrilla(List<Producto> productosAMostrar)
        {
            dgvProductos.Rows.Clear();
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;

            if (productosAMostrar == null) return;

            foreach (var producto in productosAMostrar)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto);

                
                var estado = listaEstados.FirstOrDefault(e => e.Id_estado_producto == producto.Estado_producto);
               

                string nombreCategoria = categoria != null ? categoria.Descripcion_categoria : "Sin categoría";
                string nombreEstado = estado != null ? estado.Descripcion_estado_producto : "Sin estado";

                
                dgvProductos.Rows.Add(
                    producto.Id_producto,
                    producto.Nombre_producto,
                    producto.Descripcion_producto,
                    nombreEstado,
                    producto.Precio_producto.ToString("0.00"), // Formatear precio
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

        private void FiltrarGrilla()
        {
            string textoBusqueda = TBBuscar.Text.ToLower().Trim();
            string criterio = CBBuscarPor.SelectedItem.ToString();

            if (textoBusqueda == "buscar productos...")
            {
                return;
            }

            // Filtrar la lista productos
            List<Producto> productosFiltrados = listaProductos.Where(p =>
            {
                // Si quisiero filtrar solo activos
                /*
                var estado = listaEstados.FirstOrDefault(est => est.Id_estado_producto == p.Estado_producto);
                bool estaActivo = (estado != null && estado.Descripcion_estado_producto.ToLower() == "activo");
                if (!estaActivo) return false; 
                */

                if (criterio == "Nombre")
                {
                    return p.Nombre_producto.ToLower().Contains(textoBusqueda);
                }
                else if (criterio == "Categoria")
                {
                    var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == p.Categoria_producto);
                    return categoria != null && categoria.Descripcion_categoria.ToLower().Contains(textoBusqueda);
                }
                return false;
            }).ToList();

            // Cargar la grilla con los resultados
            CargarGrilla(productosFiltrados);
        }

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            if (TBBuscar.Text == "Buscar productos...")
            {
                TBBuscar.Text = "";
                TBBuscar.ForeColor = Color.FromArgb(224, 224, 224); // Letra blanca
            }
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBBuscar.Text))
            {
                TBBuscar.Text = "Buscar productos...";
                TBBuscar.ForeColor = Color.Gray; // Letra gris
                CargarGrilla(listaProductos); // Mostrar todos los productos si se vacía
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        private void CBBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }
    }
}
