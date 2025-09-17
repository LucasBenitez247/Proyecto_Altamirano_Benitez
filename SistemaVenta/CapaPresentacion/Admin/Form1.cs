using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            panelOpciones.BackColor = Color.FromArgb(82, 82, 92);
            btnInicio.BackColor = Color.FromArgb(82, 82, 92);
            btnGestionUsuarios.BackColor = Color.FromArgb(82, 82, 92);
            btnPermisosYRoles.BackColor = Color.FromArgb(82, 82, 92);
            btnProductos.BackColor = Color.FromArgb(82, 82, 92);
            btnInventario.BackColor = Color.FromArgb(82, 82, 92);
            btnVentas.BackColor = Color.FromArgb(82, 82, 92);
            btnReclamos.BackColor = Color.FromArgb(82, 82, 92);
            btnReportes.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(178, 14, 14);
            
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnGestionUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnGestionUsuarios.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnGestionUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnGestionUsuarios.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnPermisosYRoles_MouseEnter(object sender, EventArgs e)
        {
            btnPermisosYRoles.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnPermisosYRoles_MouseLeave(object sender, EventArgs e)
        {
            btnPermisosYRoles.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnProductros_MouseEnter(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnProductros_MouseLeave(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnReclamos_MouseEnter(object sender, EventArgs e)
        {
            btnReclamos.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnReclamos_MouseLeave(object sender, EventArgs e)
        {
            btnReclamos.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.FromArgb(178, 14, 14);
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.FromArgb(82, 82, 92);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            formGestionUsuarios gestionUsuario = new formGestionUsuarios();
            gestionUsuario.ShowDialog();
        }

        private void btnPermisosYRoles_Click(object sender, EventArgs e)
        {
            FormPermisosYRoles formPermisosYRoles = new FormPermisosYRoles();
            formPermisosYRoles.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }
    }
}
