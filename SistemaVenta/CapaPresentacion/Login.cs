using CapaPresentacion.Dueño_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Administrador;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void BtnVendedor_Click(object sender, EventArgs e)
        {
            PerfilVendedor PerfilVendedor_Inicio = new PerfilVendedor();
            PerfilVendedor_Inicio.Show();
        }

        private void BtnDueñoNegocio_Click(object sender, EventArgs e)
        {
            PerfilDueñoNegocio perfilDueñoNegocio = new PerfilDueñoNegocio();   
            perfilDueñoNegocio.Show();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
           PerfilAdministrador perfilAdministrador = new PerfilAdministrador();
              perfilAdministrador.Show();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {

            List<Usuario> Test = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Mail_usuario == TxtMail_usuario.Text && u.Contrasenia_usuario == TxtClave.Text).FirstOrDefault();

           

            if (ousuario != null)
            {
                // Supongamos que los IDs de perfil son:
                // 1 = Administrador
                // 2 = Vendedor
                // 3 = Dueño de Negocio

                if (ousuario.Id_perfil == 1)
                {
                    PerfilAdministrador frmAdmin = new PerfilAdministrador();
                    frmAdmin.Show();
                }
                else if (ousuario.Id_perfil == 2)
                {
                    PerfilVendedor frmVend = new PerfilVendedor();
                    frmVend.Show();
                }
                else if (ousuario.Id_perfil == 3)
                {
                    PerfilDueñoNegocio frmDueno = new PerfilDueñoNegocio();
                    frmDueno.Show();
                }

                // Ocultar el login si querés que no quede abierto
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
