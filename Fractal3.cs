using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Proyecto_Final
{
    public class Fractal3
    {
        private double zoom;
        private int maxIterations;
        private double cX;
        private double cY;
        private int width;
        private int height;

        public Fractal3(int width, int height, double initialZoom, int initialMaxIterations)
        {
            this.width = width;
            this.height = height;
            this.zoom = initialZoom;
            this.maxIterations = initialMaxIterations;
            this.cX = -0.7; // Parte real del parámetro c
            this.cY = 0.27015; // Parte imaginaria del parámetro c
        }

        public void SetZoom(double newZoom)
        {
            zoom = newZoom;
        }

        public Bitmap GenerateJuliaSet()
        {
            Bitmap bitmap = new Bitmap(width, height);
            Color[] colors = GenerateColorGradient(maxIterations);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Ajusta las coordenadas con el factor de zoom
                    double zx = 1.5 * (x - width / 2.0) / (0.5 * zoom * width);
                    double zy = (y - height / 2.0) / (0.5 * zoom * height);
                    int i = 0;

                    while (zx * zx + zy * zy < 4 && i < maxIterations)
                    {
                        double tmp = zx * zx - zy * zy + cX;
                        zy = 2.0 * zx * zy + cY;
                        zx = tmp;
                        i++;
                    }

                    bitmap.SetPixel(x, y, colors[i]);
                }
            }

            AddTextOverlay(bitmap);
            return bitmap;
        }

        private Color[] GenerateColorGradient(int maxiter)
        {
            Color[] colors = new Color[maxiter + 1];
            for (int c = 0; c <= maxiter; c++)
            {
                int red = Math.Min((c >> 5) * 36, 255);
                int green = Math.Min((c >> 3 & 7) * 36, 255);
                int blue = Math.Min((c & 3) * 85, 255);
                colors[c] = Color.FromArgb(red, green, blue);
            }
            return colors;
        }

        private void AddTextOverlay(Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                RectangleF rectf = new RectangleF(10, 10, 300, 100);
                g.Flush();
            }
        }
    }
}