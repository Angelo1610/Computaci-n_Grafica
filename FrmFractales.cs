using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Proyecto_Final
{
    public partial class FrmFractales : Form
    {
        private Fractal1 fractal1;
        private Fractal2 fractal2;
        private Fractal3 fractal3;
        private double zoomFactor1 = 1.0; // Factor de zoom para Fractal1
        private double zoomFactor2 = 1.0; // Factor de zoom para Fractal2
        private double zoomFactor3 = 1.0; //private double zoomFactor3 = 1.0;

        public FrmFractales()
        {
            InitializeComponent();
            fractal1 = new Fractal1();
            fractal2 = new Fractal2(picCanvas.Width, picCanvas.Height, 5, 0.45);
            fractal3 = new Fractal3(picCanvas.Width, picCanvas.Height, 1.0, 300);

            // Habilitar el evento MouseWheel en el formulario
            this.MouseWheel += new MouseEventHandler(FrmFractales_MouseWheel);

            // Establecer el foco en picCanvas para recibir eventos de ratón
            picCanvas.Focus();
        }

        // Método para manejar el evento de la rueda del ratón
        private void FrmFractales_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomFactor1 *= 1.1; // Zoom in para Fractal1
                zoomFactor2 /= 1.1; // Zoom in para Fractal2
                zoomFactor3 *= 1.1; // Zoom in para Fractal3
            }
            else
            {
                zoomFactor1 /= 1.1; // Zoom out para Fractal1
                zoomFactor2 *= 1.1; // Zoom out para Fractal2
                zoomFactor3 /= 1.1; // Zoom in para Fractal3
            }

            // Redibujar los fractales con el nuevo zoom
            if (picCanvas.Tag.ToString() == "Fractal1")
            {
                RedrawFractal1();
            }
            else if (picCanvas.Tag.ToString() == "Fractal2")
            {
                RedrawFractal2();
            }
            else if (picCanvas.Tag.ToString() == "Fractal3")
            {
                RedrawFractal3();
            }
        }

        private void RedrawFractal1()
        {
            Bitmap fractalImage = fractal1.GenerateFractal(picCanvas.Width, picCanvas.Height, zoomFactor1);
            picCanvas.Image = fractalImage;
            picCanvas.Tag = "Fractal1"; // Marcar que se está mostrando Fractal1
        }

        private void RedrawFractal2()
        {
            Bitmap fractalImage = fractal2.GenerateFractal(picCanvas.Width, picCanvas.Height, zoomFactor2);
            picCanvas.Image = fractalImage;
            picCanvas.Tag = "Fractal2"; // Marcar que se está mostrando Fractal2
        }

        private void RedrawFractal3()
        {
            fractal3.SetZoom(zoomFactor3);
            Bitmap fractalImage = fractal3.GenerateJuliaSet();
            picCanvas.Image = fractalImage;
            picCanvas.Tag = "Fractal3"; // Marcar que se está mostrando Fractal3
        }

        private void alternarImagenPicCanvasReferencia(int currentImageIndex)
        {
            switch (currentImageIndex)
            {
                case 0:
                    picCanvasReferencia.Image = Properties.Resources.mandelbrot;
                    lblMensaje.Text = "Fractal de Mandelbrot";
                    break;
                case 1:
                    picCanvasReferencia.Image = Properties.Resources.sierpinski;
                    lblMensaje.Text = "Triángulo de Sierpinski";
                    break;
                case 2:
                    picCanvasReferencia.Image = Properties.Resources.julia_set;
                    lblMensaje.Text = "Conjunto de Julia";
                    break;
            }
        }

        private void btnFractal1_Click(object sender, EventArgs e)
        {
            alternarImagenPicCanvasReferencia(0);
            zoomFactor1 = 1.0; // Restablecer el zoom al valor inicial
            RedrawFractal1();
        }

        private void btnFractal2_Click(object sender, EventArgs e)
        {
            alternarImagenPicCanvasReferencia(1);
            zoomFactor2 = 1.0; // Restablecer el zoom al valor inicial
            RedrawFractal2();
        }

        private void btnFractal3_Click(object sender, EventArgs e)
        {
            alternarImagenPicCanvasReferencia(2);
            zoomFactor3 = 1.0; // Restablecer el zoom al valor inicial
            RedrawFractal3();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "Proyecto Final Computacion Grafica.pdf";

            try
            {
                Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo de ayuda. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
