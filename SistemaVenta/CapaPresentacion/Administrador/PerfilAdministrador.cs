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
    public partial class PerfilAdministrador : Form
    {
        public PerfilAdministrador()
        {
            InitializeComponent();
        }
        private void AbrirUserControl(UserControl uc)
        {
            PContenedor.Controls.Clear();   // borra lo que había
            uc.Dock = DockStyle.Fill;           // ocupa todo el panel
            PContenedor.Controls.Add(uc);   // agrega el nuevo control
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new InicioUserControlAdministrador());
        }

        private void BtnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new GestionUsuarioUserControlAdministrador());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ComprasUserControlAdministrador());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new GestionProveedorUserControlAdministrador());
        }

        

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           AbrirUserControl(new ReportesUserControlAdministrador());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
