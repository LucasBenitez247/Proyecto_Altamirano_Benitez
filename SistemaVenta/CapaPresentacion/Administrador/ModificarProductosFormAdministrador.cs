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
    public partial class ModificarProductosFormAdministrador : Form
    {
        private Producto producto;

        public ModificarProductosFormAdministrador()
        {
            InitializeComponent();
        }

        public ModificarProductosFormAdministrador(Producto pProducto)
        {
            InitializeComponent();
            cargarComboBox(); // Carga categorías y estados

            producto = pProducto;

            // Asignar datos básicos
            txtCodigoProducto.Text = pProducto.Codigo_producto;
            txtNombre.Text = pProducto.Nombre_producto;
            txtDescripcion.Text = pProducto.Descripcion_producto;
            cboCategoria.SelectedValue = pProducto.Categoria_producto;
            cboEstado.SelectedValue = pProducto.Estado_producto;

            // Cargar talles según la categoría
            var categoriaSeleccionada = cboCategoria.SelectedItem as Categoria_producto;
            if (categoriaSeleccionada != null)
            {
                cargarTallesPorCategoria(categoriaSeleccionada.Descripcion_categoria);

                // Asignar el talle solo después de cargar los ítems
                cboTalle.SelectedValue = pProducto.Talle_producto;
            }
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            } // Validar campos antes de registrar

            // Obtener el Id del talle seleccionado, si aplica
            int talleSeleccionado = 0;

            if (cboTalle.Enabled && cboTalle.SelectedItem != null)
            {
                Talle_producto talle = (Talle_producto)cboTalle.SelectedItem;
                talleSeleccionado = talle.Id_talle_producto;
            }

            // Crear una instancia del producto con los datos ingresados
            Producto nuevoProducto = new Producto
            { 
                Id_producto = producto.Id_producto,
                Codigo_producto = txtCodigoProducto.Text,
                Nombre_producto = txtNombre.Text,
                Descripcion_producto = txtDescripcion.Text,
                Estado_producto = ((Estado_producto)cboEstado.SelectedItem).Id_estado_producto,
                Categoria_producto = ((Categoria_producto)cboCategoria.SelectedItem).Id_categoria,
                Talle_producto = talleSeleccionado
            };

            try
            {
                CN_Producto cnProducto = new CN_Producto();
                bool resultado = cnProducto.editarProducto(nuevoProducto);
                if (resultado)
                {
                    MessageBox.Show("Producto modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                        string.IsNullOrWhiteSpace(txtCodigoProducto.Text))

            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else
            {
                if (cboTalle.Enabled && cboTalle.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un talle válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
                return true;
        }

        private void limpiarFormulario()
        {
            // Limpia todos los campos del formulario
            txtNombre.Clear();
            txtDescripcion.Clear();
            
            cboEstado.SelectedIndex = -1; // Deselecciona cualquier ítem seleccionado en el ComboBox de estado
            cboCategoria.SelectedIndex = -1;

            cboTalle.DataSource = null; // Limpia los ítems del ComboBox de talles
            cboTalle.Enabled = false;
        }

        private void cargarTallesPorCategoria(string descripcionCategoria)
        {
            if (string.IsNullOrEmpty(descripcionCategoria))
            {
                cboTalle.Items.Clear();
                cboTalle.Enabled = false;
                return;
            }

            string tipoTalle = (descripcionCategoria == "Remeras" || descripcionCategoria == "Buzos") ? "Letra" :
                               (descripcionCategoria == "Pantalones") ? "Numero" : "";

            if (!string.IsNullOrEmpty(tipoTalle))
            {
                CN_Producto cnProducto = new CN_Producto();
                List<Talle_producto> listaTalles = cnProducto.listarTalles();

                var tallesFiltrados = listaTalles
                    .Where(t => t.Tipo_talle == tipoTalle)
                    .ToList();

                cboTalle.DataSource = tallesFiltrados;
                cboTalle.DisplayMember = "Descripcion_talle";
                cboTalle.ValueMember = "Id_talle_producto";
                cboTalle.Enabled = true;
            }
            else
            {
                cboTalle.DataSource = null;
                cboTalle.Enabled = false;
            }
        }


        private void ModificarProductosFormAdministrador_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void cargarComboBox()
        {
            // Configurar el ComboBox de Categorias
            CN_Producto cnProducto = new CN_Producto();
            List<Categoria_producto> categorias = cnProducto.obtenerCategoria();
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Descripcion_categoria"; // Muestra la descripción en el ComboBox
            cboCategoria.ValueMember = "Id_categoria"; //El valor real es el Id


            // Configurar el ComboBox de Estado
            List<Estado_producto> listaEstados = cnProducto.listarEstados();
            cboEstado.DataSource = listaEstados;
            cboEstado.DisplayMember = "Descripcion_estado_producto";
            cboEstado.ValueMember = "Id_estado_producto";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Muestra error si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, ""); // Limpia el error si está correcto
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoriaSeleccionada = cboCategoria.SelectedItem as Categoria_producto;
            if (categoriaSeleccionada != null)
            {
                cargarTallesPorCategoria(categoriaSeleccionada.Descripcion_categoria);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
