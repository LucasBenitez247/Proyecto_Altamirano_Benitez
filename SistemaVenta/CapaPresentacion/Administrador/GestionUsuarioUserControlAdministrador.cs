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
    public partial class GestionUsuarioUserControlAdministrador : UserControl
    {
        public GestionUsuarioUserControlAdministrador()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
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
                string.IsNullOrWhiteSpace(TContrasenia.Text) // ||
               // string.IsNullOrWhiteSpace(TDni.Text)
                )
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
                case "Administrador":
                    idPerfil = 1;
                    break;
                case "Vendedor":
                    idPerfil = 2;
                    break;
                case "Dueño de negocio":
                    idPerfil = 3;
                    break;
                default:
                    MessageBox.Show("Perfil inválido.");
                    return;
            }

            // Mapear estado
            int estado = CBEstado.SelectedItem.ToString() == "Activo" ? 1 : 0;

            // Crear objeto Usuario
            Usuario nuevo = new Usuario()
            {
                Nombre_usuario = TNombre.Text.Trim(),
                Apellido_usuario = TApellido.Text.Trim(),
                Mail_usuario = TCorreo.Text.Trim(),
                Contrasenia_usuario = TContrasenia.Text.Trim(),
               // Dni = TDni.Text.Trim(),
                Id_perfil = idPerfil,
                Estado_usuario = estado
            };

            // Registrar
            bool resultado = new CN_Usuario().Registrar(nuevo);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado con éxito");
                LimpiarCampos();
                CargarUsuarios(); // refresca tu DataGridView
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario");
            }
        }
    }
}
