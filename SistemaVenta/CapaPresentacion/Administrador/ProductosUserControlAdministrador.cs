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

namespace CapaPresentacion.Administrador
{
    public partial class pnlProductos : UserControl
    {
        private List<Producto> listaProductos = new List<Producto>();
        private List<Categoria_producto> listaCategorias = new List<Categoria_producto>();
        private List<Estado_producto> listaEstados = new List<Estado_producto>();

        public pnlProductos()
        {
            InitializeComponent();
            inicializarControles(); // Inicializar controles del comboBox
            cargarDatos(); // Cargar datos desde la capa de negocio
            cargarProductos(); // Cargar productos en el DataGridView
        }

        private void inicializarControles()
        {
            // Configurar el ComboBox con las opciones "Producto" y "Fecha"
            cboBuscarPor.Items.Add("Nombre");
            cboBuscarPor.Items.Add("Categoría");
            cboBuscarPor.Items.Add("Descripción");

            dgvProductos.Columns["Modificar"].DefaultCellStyle.NullValue = "Modificar";
            dgvProductos.Columns["Eliminar"].DefaultCellStyle.NullValue = "Eliminar";
        }
        private void lblHasta_Load(object sender, EventArgs e)
        {


        }

        private void cargarProductos()
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


        private void lHasta_Click(object sender, EventArgs e)
        {

        }

        private void cboBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            AgregarProductosFormAdministrador agregarProductosForm = new AgregarProductosFormAdministrador();
            
            if (agregarProductosForm.ShowDialog() == DialogResult.OK)
            {
                cargarDatos(); // Este método debe volver a consultar la base de datos y actualizar el DataGridView
                cargarProductos();   // Vuelve a llenar el DataGridView con la lista actualizada
            }

        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text) && (cboBuscarPor.SelectedItem?.ToString()?.ToLower() != "fecha"))
            {
                errorProvider1.SetError(txtBuscador, "Ingrese un valor para buscar");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        /** 
         * Metodo para cargar los datos de productos, categorias y estados desde la capa de negocio.
        */
        private void cargarDatos()
        {
            dgvProductos.AllowUserToAddRows = false;
            listaProductos = new CN_Producto().listarProductos();
            listaCategorias = new CN_Producto().obtenerCategoria();
            listaEstados = new CN_Producto().listarEstados();
        }


        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscador.Text.Trim().ToLower(); // Convertir el texto a minúsculas para una comparación insensible a mayúsculas/minúsculas
            dgvProductos.Rows.Clear(); // Limpiar el DataGridView antes de mostrar los resultados filtrados

            /**
             * evaluar el criterio de búsqueda seleccionado en el ComboBox
             */
            var listaFiltrada = listaProductos.Where(p =>
            {
                switch (cboBuscarPor.SelectedItem.ToString())
                {
                    case "Nombre":
                        return p.Nombre_producto.ToLower().Contains(texto);
                    case "Categoría":
                        var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == p.Categoria_producto); // Buscar la categoría correspondiente
                        return categoria != null && categoria.Descripcion_categoria.ToLower().Contains(texto); // Verificar si la descripción de la categoría contiene el texto buscado
                    case "Descripción":
                        return p.Descripcion_producto.ToLower().Contains(texto);
                    default:
                        return false;
                }
            }).ToList();

            foreach (var producto in listaFiltrada)
            {
                var categoria = listaCategorias.FirstOrDefault(c => c.Id_categoria == producto.Categoria_producto);
                var estadoEncontrado = listaEstados.FirstOrDefault(est => est.Id_estado_producto == producto.Estado_producto);

                string nombreCategoria = categoria != null ? categoria.Descripcion_categoria : "Sin categoría";
                string nombreEstado = estadoEncontrado != null ? estadoEncontrado.Descripcion_estado_producto : "Sin estado";

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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; // Ignorar clics en el encabezado
            }
            else
            {
                if (e.ColumnIndex == dgvProductos.Columns["Modificar"].Index)
                {
                    // Obtener los datos del producto seleccionado
                    Producto producto = new Producto();
                    producto.Id_producto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                    producto.Nombre_producto = dgvProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    producto.Descripcion_producto = dgvProductos.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                    producto.Precio_producto = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["precio"].Value);
                    producto.Stock_producto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["stock"].Value);
                    producto.Categoria_producto = listaCategorias.FirstOrDefault(c => c.Descripcion_categoria == dgvProductos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString())?.Id_categoria ?? 0;
                    producto.Estado_producto = listaEstados.FirstOrDefault(es => es.Descripcion_estado_producto == dgvProductos.Rows[e.RowIndex].Cells["Estado"].Value.ToString())?.Id_estado_producto ?? 0;
                    
                    ModificarProductosFormAdministrador modificarProductosForm = new ModificarProductosFormAdministrador(producto);
                    modificarProductosForm.ShowDialog();

                     // Recargar los datos después de la modificación
                     cargarDatos();
                     cargarProductos();
                }
                else if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index)
                {
                    try
                    {
                        if (MessageBox.Show("Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                            string mensaje = string.Empty;
                            Producto producto = new Producto()
                            {
                                Id_producto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["idProducto"].Value)
                            };

                            bool respuesta = new CN_Producto().eliminarProducto(producto.Id_producto);

                            if (respuesta)
                            {
                                mensaje = "Producto eliminado correctamente.";
                                dgvProductos.Rows.RemoveAt(e.RowIndex); // Eliminar la fila del DataGridView
                            } else
                            {
                                mensaje = "No se pudo eliminar el producto.";
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Error de base de datos: " + sqlEx.Message);
                        // Aquí puedes registrar el error o mostrar detalles técnicos si estás en modo desarrollador
                    }
                    catch (FormatException formatEx)
                    {
                        MessageBox.Show("El ID del producto no tiene un formato válido: " + formatEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                    }
                }

            }


        }

    }
}

