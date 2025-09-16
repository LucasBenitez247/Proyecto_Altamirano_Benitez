using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Dueño_de_Negocio
{
    public partial class PerfilDueñoNegocio : Form
    {
        public PerfilDueñoNegocio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void AbrirUserControl(UserControl uc)
        {
            PContenedor.Controls.Clear();   // borra lo que había
            uc.Dock = DockStyle.Fill;           // ocupa todo el panel
            PContenedor.Controls.Add(uc);   // agrega el nuevo control
        }
       
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new DueñoNegocioInicioUserControl());
        }
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new DueñoNegocioReportesUserControl());
        }

        private void BtnEstadistica_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new DueñoNegocioEstadisticasUserControl());
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new DueñoNegocioInventarioUserControl());
        }

       
    }
}
