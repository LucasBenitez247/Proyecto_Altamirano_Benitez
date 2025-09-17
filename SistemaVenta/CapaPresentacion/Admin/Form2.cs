using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Admin
{
    public partial class formGestionUsuarios : Form
    {
        public formGestionUsuarios()
        {
            InitializeComponent();
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductros_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_MouseEnter(object sender, EventArgs e)
        {
            
            btnAgregarUsuario.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnAgregarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarUsuario.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void formGestionUsuarios_Load(object sender, EventArgs e)
        {
            btnAgregarUsuario.BackColor = Color.FromArgb(82, 82, 92);
            btnEliminarUsuario.BackColor = Color.FromArgb(82, 82, 92);
            btnVerUsuarios.BackColor = Color.FromArgb(82, 82, 92);
            btnModificarUsuarios.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnEliminarUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarUsuario.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnEliminarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarUsuario.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnVerUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnVerUsuarios.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnVerUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnVerUsuarios.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnModificarUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnModificarUsuarios.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnModificarUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnModificarUsuarios.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            UserControlGestionUsuario gestionUsuario = new UserControlGestionUsuario();
            panelinfo.Controls.Add(gestionUsuario);
            
        
        
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            UserControlConsutarUsuarios consultarUsuarios = new UserControlConsutarUsuarios();
            panelinfo.Controls.Add(consultarUsuarios);
        }
    }
}
