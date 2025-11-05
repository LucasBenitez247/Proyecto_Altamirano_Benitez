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
            cargarComboBox();
        }

        private void AgregarProductosFormAdministrador_Load(object sender, EventArgs e)
        {
            txtCodigoProducto.Focus();
            this.AcceptButton = BtnRegistrar; // Establece el botón "Registrar" como el botón predeterminado
            this.CancelButton = btnCancelar; // Establece el botón "Cancelar" como el botón predeterminado al presionar Esc

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
                Codigo_producto = txtCodigoProducto.Text,
                Nombre_producto = txtNombre.Text,
                Descripcion_producto = txtDescripcion.Text,
                Estado_producto = ((Estado)cboEstado.SelectedItem).Estado_usuario,
                Talle_producto = cboTalle.Enabled ? ((Talle_producto)cboTalle.SelectedItem).Id_talle_producto : 0,
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
            
            // Permitir dígitos, control (como Backspace), y un solo punto o coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
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
            txtCodigoProducto.Clear();

            cboEstado.SelectedIndex = -1; // Deselecciona cualquier ítem seleccionado en el ComboBox de estado
            cboCategoria.SelectedIndex = -1;

            cboTalle.DataSource = null; // Limpia los ítems del ComboBox de talles
            cboTalle.Enabled = false;

            txtCodigoProducto.Focus(); // Establece el foco en el campo de código de producto
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoriaSeleccionada = cboCategoria.SelectedItem as Categoria_producto;
            if (categoriaSeleccionada != null)
            {
                cargarTallesPorCategoria(categoriaSeleccionada.Descripcion_categoria);
            }
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
        private void cargarComboBox()
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
            cboTalle.Enabled = false;
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

        private void cboTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

   
