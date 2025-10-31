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
using System.Globalization;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging; 
using CapaPresentacion.Properties;

namespace CapaPresentacion.Vendedor
{
    public partial class DetalleVenta : Form
    {
        //Variable para guardar la venta
        private Venta ventaActual;
        private List<Detalle_venta> listaDetalles;

        public DetalleVenta()
        {
            InitializeComponent();
            
        }

        //  Nuevo constructor que recibe la venta 
        public DetalleVenta(Venta venta)
        {
            InitializeComponent();
            this.ventaActual = venta;
            // Configurar el DataGridView
           
            
            this.listaDetalles = new List<Detalle_venta>();
        }

        // Evento Load para cargar los datos 
        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (ventaActual != null)
            {
                //  Llena Información de la Venta
                TFecha.Text = ventaActual.Fecha_venta.ToString("dd/MM/yyyy HH:mm");
                TTipoDocumento.Text = ventaActual.Tipo_documento;

                // Llena Información del Cliente
                TDni.Text = ventaActual.Dni_cliente;
                TNombre.Text = ventaActual.Nombre_cliente;
                TApellido.Text = ventaActual.Apellido_cliente;

                //  Llena DataGridView con los productos (Detalles)
                CargarDetalles();
            }
        }

        // Método para cargar la grilla de productos
        private void CargarDetalles()
        {

            dataGridView1.Rows.Clear();
            CN_Venta cnVenta = new CN_Venta();

            // Usamos la variable de la clase para guardar los detalles
            this.listaDetalles = cnVenta.ObtenerDetallesVenta(ventaActual.Id_venta);

            if (this.listaDetalles == null) return;

            foreach (var detalle in this.listaDetalles)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    detalle.Nombre_producto,
                    detalle.Precio_unitario.ToString("0.00"),
                    detalle.Cantidad,
                    detalle.Subtotal.ToString("0.00") // Usamos la propiedad calculada
                });
            }
        }
        

       

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (ventaActual == null || this.listaDetalles == null)
            {
                MessageBox.Show("No hay datos de venta para imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Crear documento PDF
                PdfDocument document = new PdfDocument();
                document.Info.Title = $"Venta Nro {ventaActual.Id_venta}";
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // 2. Definir fuentes
                XFont fontTitulo = new XFont("Arial", 16, XFontStyle.Bold);
                XFont fontSubtitulo = new XFont("Arial", 12, XFontStyle.Bold);
                XFont fontNormal = new XFont("Arial", 10, XFontStyle.Regular);
                XFont fontMono = new XFont("Courier New", 10, XFontStyle.Regular); // Fuente monoespaciada para alinear números

                int yPos = 40; // Posición Y inicial
                int xMargen = 40;

                //  2.b DIBUJAR LOGO
                try
                {
                    // Cargar la imagen desde los recursos del proyecto
                    Bitmap logoBitmap = Resources.LogoF1Store;

                    // Convertir System.Drawing.Bitmap a PdfSharp.Drawing.XImage
                    XImage xLogo;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        logoBitmap.Save(ms, ImageFormat.Png); // Guardar el bitmap en un stream en formato Png
                        ms.Position = 0; // Rebobinar el stream
                        xLogo = XImage.FromStream(ms); // Cargar el XImage desde el stream
                    }

                    // Definir tamaño y posición (ej. esquina superior derecha)
                    double logoWidth = 120; // Ancho deseado en el PDF
                    double logoHeight = (logoWidth / xLogo.PixelWidth) * xLogo.PixelHeight; // Calcular alto manteniendo aspecto
                    double xLogoPos = page.Width - xMargen - logoWidth;
                    double yLogoPos = 30; // Margen superior

                    // Dibujar la imagen
                    gfx.DrawImage(xLogo, xLogoPos, yLogoPos, logoWidth, logoHeight);
                }
                catch (Exception exLogo)
                {
                    // Opcional: Manejar si el logo no se carga, pero no detener la impresión
                    Console.WriteLine("Error al cargar logo: " + exLogo.Message);
                }
                // --- FIN DIBUJAR LOGO ---
                // 3. Dibujar Título
                yPos = 80; // Bajamos el título para dar espacio al logo
                gfx.DrawString("Detalle de Venta", fontTitulo, XBrushes.Black, new XRect(0, yPos, page.Width, 0), XStringFormats.TopCenter);
                yPos += 40;

                // 4. Dibujar Info Cliente y Venta
                gfx.DrawString("Información del Cliente", fontSubtitulo, XBrushes.Black, xMargen, yPos);
                yPos += 20;
                gfx.DrawString($"Cliente: {ventaActual.Nombre_cliente} {ventaActual.Apellido_cliente}", fontNormal, XBrushes.Black, xMargen + 10, yPos);
                yPos += 15;
                gfx.DrawString($"DNI: {ventaActual.Dni_cliente}", fontNormal, XBrushes.Black, xMargen + 10, yPos);
                yPos += 30;

                gfx.DrawString("Información de la Venta", fontSubtitulo, XBrushes.Black, xMargen, yPos);
                yPos += 20;
                gfx.DrawString($"Fecha: {ventaActual.Fecha_venta.ToString("dd/MM/yyyy")}", fontNormal, XBrushes.Black, xMargen + 10, yPos);
                yPos += 15;
                gfx.DrawString($"Documento: {ventaActual.Tipo_documento}", fontNormal, XBrushes.Black, xMargen + 10, yPos);
                yPos += 30;

                // 5. Dibujar Productos (Tabla)
                gfx.DrawString("Productos", fontSubtitulo, XBrushes.Black, xMargen, yPos);
                yPos += 20;

                // Definir posiciones X para las columnas
                int xProducto = xMargen;
                int xPrecio = 300;
                int xCantidad = 380;
                int xSubtotal = 450;

                // Encabezados de tabla
                gfx.DrawString("Producto", fontNormal, XBrushes.Black, xProducto, yPos);
                gfx.DrawString("Precio Unit.", fontNormal, XBrushes.Black, xPrecio, yPos);
                gfx.DrawString("Cant.", fontNormal, XBrushes.Black, xCantidad, yPos);
                gfx.DrawString("Subtotal", fontNormal, XBrushes.Black, xSubtotal, yPos);
                yPos += 15;
                gfx.DrawLine(XPens.Black, xMargen, yPos, page.Width - xMargen, yPos); // Línea separadora
                yPos += 10;

                // Contenido de la tabla (loop)
                foreach (var detalle in this.listaDetalles)
                {
                    gfx.DrawString(detalle.Nombre_producto, fontMono, XBrushes.Black, xProducto, yPos);
                    gfx.DrawString(detalle.Precio_unitario.ToString("0.00", CultureInfo.InvariantCulture), fontMono, XBrushes.Black, xPrecio, yPos);
                    gfx.DrawString(detalle.Cantidad.ToString(), fontMono, XBrushes.Black, xCantidad, yPos);
                    gfx.DrawString(detalle.Subtotal.ToString("0.00", CultureInfo.InvariantCulture), fontMono, XBrushes.Black, xSubtotal, yPos);
                    yPos += 15;
                }

                yPos += 10;
                gfx.DrawLine(XPens.Black, xMargen, yPos, page.Width - xMargen, yPos); // Línea separadora
                yPos += 20;

                // 6. Dibujar Total
                string textoTotal = $"TOTAL: {ventaActual.Total_venta.ToString("C2", new CultureInfo("es-AR"))}";
                gfx.DrawString(textoTotal, fontTitulo, XBrushes.Black, new XRect(0, yPos, page.Width - xMargen, 0), XStringFormats.TopRight);

                //Usar SaveFileDialog para elegir dónde guardar
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf"; // Filtro para mostrar solo archivos PDF
                saveFileDialog.Title = "Guardar Detalle de Venta";
                saveFileDialog.FileName = $"Venta_{ventaActual.Id_venta}.pdf"; // Nombre sugerido

                // Mostrar el diálogo
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // El usuario hizo clic en "Guardar" y eligió una ruta
                    string filePath = saveFileDialog.FileName;

                    // Guardar el documento en la ruta elegida
                    document.Save(filePath);

                    // Abrir el PDF con el visor predeterminado
                    Process.Start(filePath);
                }
                // Si el usuario hace clic en "Cancelar", no se hace nada.

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void DetalleVenta_Load_1(object sender, EventArgs e)
        {
            if (ventaActual != null)
            {
                // 1. Llenar Información de la Venta
                TFecha.Text = ventaActual.Fecha_venta.ToString("dd/MM/yyyy");
                TTipoDocumento.Text = ventaActual.Tipo_documento;

                // 2. Llenar Información del Cliente
                TDni.Text = ventaActual.Dni_cliente;
                TNombre.Text = ventaActual.Nombre_cliente;
                TApellido.Text = ventaActual.Apellido_cliente;

                // 3. Llenar DataGridView con los productos (Detalles)
                CargarDetalles();
            }
        }

    }
}
