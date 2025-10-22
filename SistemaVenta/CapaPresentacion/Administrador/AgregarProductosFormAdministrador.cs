using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Administrador
{
    public partial class AgregarProductosFormAdministrador : Form
    {
        public AgregarProductosFormAdministrador()
        {
            InitializeComponent();
        }

        private void AgregarProductosFormAdministrador_Load(object sender, EventArgs e)
        {
            // Configurar el ComboBox de Categorias
            CN_Producto cnProducto = new CN_Producto();
            List<Categoria_producto> categorias = cnProducto.obtenerCategoria();
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "Descripcion_categoria"; // Muestra la descripción en el ComboBox
            cboCategoria.ValueMember = "Id_categoria"; //El valor real es el Id
            cboCategoria.SelectedIndex = -1;

            // Configurar el ComboBox de Estado
            List<Estado> listaEstados = ObtenerEstados();
            cboEstado.DataSource = listaEstados;
            cboEstado.DisplayMember = "Estado_descripcion";
            cboEstado.ValueMember = "Estado_usuario";

           
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
                
                Nombre_producto = txtNombre.Text,
                Descripcion_producto = txtDescripcion.Text,
                Precio_producto = decimal.Parse(txtPrecio.Text),
                Estado_producto = ((Estado)cboEstado.SelectedItem).Estado_usuario,
                Stock_producto = int.Parse(txtStock.Text),
                Categoria_producto = ((Categoria_producto)cboCategoria.SelectedItem).Id_categoria
        };

            // Llamar al método para agregar el producto
            // Llamar al método para agregar el producto

            try
            {
                CN_Producto cnProducto = new CN_Producto();
                bool resultado = cnProducto.RegistrarProducto(nuevoProducto);
                if (resultado)
                {
                    MessageBox.Show("Producto registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarFormulario();
                    this.DialogResult = DialogResult.OK;
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



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            AgregarProductosFormAdministrador.ActiveForm.Close();
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

            
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Muestra error si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, ""); // Limpia el error si está correcto
            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Muestra error si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProvider1.SetError(txtPrecio, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtPrecio, ""); // Limpia el error si está correcto
            }

            // Permitir dígitos, control (como Backspace), y un solo punto o coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Muestra error si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                errorProvider1.SetError(txtStock, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtStock, ""); // Limpia el error si está correcto
            }

            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            //Muestra error si no se ha seleccionado nada
            if (cboEstado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboEstado, "Seleccione un estado.");
            }
            else
            {
                errorProvider1.SetError(cboEstado, ""); // Limpia el error si está correcto
            }
        }

        private void cboCategoria_Leave(object sender, EventArgs e)
        {
            //Muestra error si no se ha seleccionado nada
            if (cboCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboCategoria, "Seleccione una categoría.");
            }
            else
            {
                errorProvider1.SetError(cboCategoria, ""); // Limpia el error si está correcto
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
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

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            // Validar que se haya seleccionado un estado
            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que se haya seleccionado una categoría
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public List<Estado> ObtenerEstados()
        {
            return new List<Estado>
    {
        new Estado { Estado_usuario = 1, Estado_descripcion = "Inactivo" },
        new Estado { Estado_usuario = 2, Estado_descripcion = "Activo" }
    };
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
