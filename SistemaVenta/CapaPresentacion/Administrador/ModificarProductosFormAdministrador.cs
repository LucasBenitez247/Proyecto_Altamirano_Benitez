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
            cargarComboBox();
            producto = pProducto;
            txtNombre.Text = pProducto.Nombre_producto;
            txtDescripcion.Text = pProducto.Descripcion_producto;
            txtPrecio.Text = pProducto.Precio_producto.ToString();
            txtStock.Text = pProducto.Stock_producto.ToString();
            cboCategoria.SelectedValue = pProducto.Categoria_producto;
            cboEstado.SelectedValue = pProducto.Estado_producto;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            } // Validar campos antes de registrar

            // Crear una instancia del producto con los datos ingresados
            Producto nuevoProducto = new Producto
            {
                Id_producto = producto.Id_producto,
                Nombre_producto = txtNombre.Text,
                Descripcion_producto = txtDescripcion.Text,
                Precio_producto = decimal.Parse(txtPrecio.Text),
                Estado_producto = ((Estado_producto)cboEstado.SelectedItem).Id_estado_producto,
                Stock_producto = int.Parse(txtStock.Text),
                Categoria_producto = ((Categoria_producto)cboCategoria.SelectedItem).Id_categoria
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
                        string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                            string.IsNullOrWhiteSpace(txtStock.Text))

            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void limpiarFormulario()
        {
            // Limpia todos los campos del formulario
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboEstado.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        

        private void ModificarProductosFormAdministrador_Load(object sender, EventArgs e)
        {
            
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
    }
}
