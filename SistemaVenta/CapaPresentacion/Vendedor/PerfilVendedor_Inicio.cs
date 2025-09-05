using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Vendedor;

namespace CapaPresentacion
{
    public partial class PerfilVendedor_Inicio : Form
    {
        private Timer hideTimer;
        public PerfilVendedor_Inicio()
        {
            InitializeComponent();
            hideTimer = new Timer();
            hideTimer.Interval = 200; // milisegundos de retardo antes de ocultar
            hideTimer.Tick += HideTimer_Tick;
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            var cursor = Cursor.Position;

            var btnRect = BtnClientes.RectangleToScreen(BtnClientes.ClientRectangle);
            var subMenuRect = PSubMenuClientes.RectangleToScreen(PSubMenuClientes.ClientRectangle);

            // si no está sobre el botón ni sobre el submenu => ocultar
            if (!btnRect.Contains(cursor) && !subMenuRect.Contains(cursor))
            {
                PSubMenuClientes.Visible = false;
                hideTimer.Stop();
            }
            else
            {
                hideTimer.Stop(); // si sigue encima, cancelamos el cierre
            }
        }

        private void PerfilVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Detecta Ctrl + S
            {
                Application.Exit(); 
            }
        }

      

        private void AbrirUserControl(UserControl uc)
        {
            PContenedor.Controls.Clear();   // borra lo que había
            uc.Dock = DockStyle.Fill;           // ocupa todo el panel
            PContenedor.Controls.Add(uc);   // agrega el nuevo control
        }

       


        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new VendedorInicioUserControl());
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new CatalogoProductosVendedorUserControl() );
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new HistorialVentasUserControl());
        }


        private void BtnClientes_MouseHover(object sender, EventArgs e)
        {
            PSubMenuClientes.Visible = true;
            hideTimer.Stop();
        }
        private void BtnClientes_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void PSubMenuClientes_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void OcultarSiCursorFuera()
        {
            var cursor = Cursor.Position; // posición del mouse en pantalla

            // Rectángulos convertidos a pantalla
            var btnRect = BtnClientes.RectangleToScreen(BtnClientes.ClientRectangle);
            var subMenuRect = PSubMenuClientes.RectangleToScreen(PSubMenuClientes.ClientRectangle);

            if (!btnRect.Contains(cursor) && !subMenuRect.Contains(cursor))
            {
                PSubMenuClientes.Visible = false;
            }
        }

        private void BtnClientesRegistrar_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new RegistrarClienteUserControl());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new VentasVendedorUserControl());
        }

        
    }
}
