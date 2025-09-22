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
            PerfilVendedor_Inicio PerfilVendedor_Inicio = new PerfilVendedor_Inicio();
            PerfilVendedor_Inicio.Show();
        }

        private void BtnDueñoNegocio_Click(object sender, EventArgs e)
        {
            PerfilDueñoNegocio perfilDueñoNegocio = new PerfilDueñoNegocio();   
            perfilDueñoNegocio.Show();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {

        }
    }
}
