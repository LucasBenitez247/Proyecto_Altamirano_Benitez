using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Administrador
{
    public partial class GestionUsuarioUserControlAdministrador : UserControl
    {
        public GestionUsuarioUserControlAdministrador()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        private int idUsuarioSeleccionado = 0; // por defecto ninguno

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            TDireccion.Clear();
            TCorreo.Clear();
            TContrasenia.Clear();
            TRContrasenia.Clear();
            CBPerfil.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;
        }
        private void CargarUsuarios()
        {
            List<Usuario> listaUsuarios = new CN_Usuario().Listar();
            DGUsuarios.DataSource = listaUsuarios;
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TCorreo.Text) ||
                string.IsNullOrWhiteSpace(TContrasenia.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (CBPerfil.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un perfil.");
                return;
            }

            if (CBEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            // Mapear perfil
            int idPerfil;
            switch (CBPerfil.SelectedItem.ToString())
            {
                case "Administrador": idPerfil = 1; break;
                case "Vendedor": idPerfil = 2; break;
                case "Dueño de negocio": idPerfil = 3; break;
                default:
                    MessageBox.Show("Perfil inválido.");
                    return;
            }

            // Mapear estado
            int estado = CBEstado.SelectedItem.ToString() == "Activo" ? 1 : 0;

            // Crear objeto Usuario (con Id si ya está seleccionado)
            Usuario usuario = new Usuario()
            {
                Id_usuario = idUsuarioSeleccionado, // clave para diferenciar entre registrar y modificar
                Nombre_usuario = TNombre.Text.Trim(),
                Apellido_usuario = TApellido.Text.Trim(),
                Mail_usuario = TCorreo.Text.Trim(),
                Contrasenia_usuario = TContrasenia.Text.Trim(),
                Id_perfil = idPerfil,
                Estado_usuario = estado
            };

            // Registrar o Modificar según corresponda
            bool resultado;
            if (idUsuarioSeleccionado == 0)
            {
                // Insert
                resultado = new CN_Usuario().Registrar(usuario);
                if (resultado) MessageBox.Show("Usuario registrado con éxito");
            }
            else
            {
                // Update
                resultado = new CN_Usuario().Modificar(usuario);
                if (resultado) MessageBox.Show("Usuario modificado con éxito");
            }

            if (resultado)
            {
                LimpiarCampos();
                CargarUsuarios(); // refresca tu DataGridView
                idUsuarioSeleccionado = 0; // resetear para volver a modo "insert"
            }
            else
            {
                MessageBox.Show("Error al guardar el usuario");
            }

        }

        private void DGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int idUsuario = Convert.ToInt32(DGUsuarios.Rows[e.RowIndex].Cells["Id_usuario"].Value);
                if (MessageBox.Show("¿Está seguro de desactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Crear un objeto usuario solo con el ID y estado inactivo
                    Usuario usuarioInactivo = new Usuario
                    {
                        Id_usuario = idUsuario,
                        Estado_usuario = 0 // 0 = Inactivo
                    };

                    bool modificado = new CN_Usuario().Modificar(usuarioInactivo);
                    if (modificado)
                    {
                        MessageBox.Show("Usuario desactivado correctamente");
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al desactivar el usuario");
                    }
                }
            }
        }

        private void DGUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que la fila seleccionada sea válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["Id_usuario"].Value);

                // Cargar datos en los TextBox
                TNombre.Text = fila.Cells["Nombre_usuario"].Value.ToString();
                TApellido.Text = fila.Cells["Apellido_usuario"].Value.ToString();
                TCorreo.Text = fila.Cells["Mail_usuario"].Value.ToString();
                TContrasenia.Text = fila.Cells["Contrasenia_usuario"].Value.ToString();

                // Para ComboBox Perfil
                int idPerfil = Convert.ToInt32(fila.Cells["Id_perfil"].Value);
                switch (idPerfil)
                {
                    case 1: CBPerfil.SelectedItem = "Administrador"; break;
                    case 2: CBPerfil.SelectedItem = "Vendedor"; break;
                    case 3: CBPerfil.SelectedItem = "Dueño de negocio"; break;
                }

                // Para ComboBox Estado
                int estado = Convert.ToInt32(fila.Cells["Estado_usuario"].Value);
                CBEstado.SelectedItem = estado == 1 ? "Activo" : "Inactivo";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider1.SetError(TNombre, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(TNombre, "");
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider2.SetError(TApellido, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider2.SetError(TApellido, "");
            }
        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string correo = TCorreo.Text;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(correo, patron))
            {
                errorProvider3.SetError(TCorreo, "Formato de correo inválido");
                // e.Cancel = false;   //  No bloquea, solo muestra error
            }
            else
            {
                errorProvider3.SetError(TCorreo, "");
            }
        }

        private void TContrasenia_TextChanged(object sender, EventArgs e)
        {
            string contrasenia = TContrasenia.Text;

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                // Si está vacío, no muestra error
                errorProvider4.SetError(TContrasenia, "");
                return;
            }

            // Patrón: mínimo 6 caracteres, al menos una letra y un número
            string patron = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";

            if (!Regex.IsMatch(contrasenia, patron))
            {
                errorProvider4.SetError(TContrasenia,
                    "La contraseña debe tener al menos 6 caracteres e incluir letras y números");
            }
            else
            {
                errorProvider4.SetError(TContrasenia, "");
            }
        }

        private void TRContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (TRContrasenia.Text != TContrasenia.Text)
            {
                errorProvider5.SetError(TRContrasenia, "Las contraseñas no coinciden");
            }
            else
            {
                errorProvider5.SetError(TRContrasenia, "");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void PFormulario_Paint(object sender, PaintEventArgs e)
        {

        

        private void TDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string direccion = TDireccion.Text.Trim();

            // Regex: al menos una letra, puede contener letras, números, espacios, guiones y º°
            string patron = @"^[a-zA-ZÁÉÍÓÚÑáéíóúñ0-9\s\-\.º°]+$";

            if (string.IsNullOrWhiteSpace(direccion))
            {
                errorProvider7.SetError(TDireccion, "La dirección no puede estar vacía");
            }
            else if (!Regex.IsMatch(direccion, patron))
            {
                errorProvider7.SetError(TDireccion, "Ingrese una dirección válida (solo letras y números)");
            }
            else
            {
                errorProvider7.SetError(TDireccion, "");
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                errorProvider6.SetError(TDni, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider6.SetError(TDni, "");
            }
        }
    }
}
