using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace C__Proyecto_Final
{
    public class Fractal2
    {
        private PointF[] points;
        private Color[] colors;
        private Random random = new Random();
        private float r;

        public Fractal2(int width, int height, int n, double r)
        {
            InitPolygon(width, height, n);
            this.r = (float)r;  // Convierte el double a float
        }

        private void InitPolygon(int width, int height, int n)
        {
            float deltaAngle = 360f / n;
            float radius = width / 2f - 10f;  // Usa 'f' para literales float
            points = new PointF[n];
            colors = new Color[n];

            for (int i = 0; i < n; i++)
            {
                float angle = (180f + i * deltaAngle) * (float)Math.PI / 180f;
                Color color = ColorFromHSV((i * deltaAngle) / 360f, 0.8f, 1f);
                points[i] = new PointF(
                    (width / 2f) + (radius * (float)Math.Sin(angle)),
                    (height / 2f) + (radius * (float)Math.Cos(angle))
                );
                colors[i] = color;
            }
        }

        private Color ColorFromHSV(float h, float s, float v)
        {
            float r = 0, g = 0, b = 0;
            int i = (int)(h * 6f);
            float f = h * 6f - i;
            float p = v * (1f - s);
            float q = v * (1f - f * s);
            float t = v * (1f - (1f - f) * s);
            i %= 6;

            switch (i)
            {
                case 0: r = v; g = t; b = p; break;
                case 1: r = q; g = v; b = p; break;
                case 2: r = p; g = v; b = t; break;
                case 3: r = p; g = q; b = v; break;
                case 4: r = t; g = p; b = v; break;
                case 5: r = v; g = p; b = q; break;
            }
            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private int RandomPointIndex(PointF[] p)
        {
            int[] idx = { 0, 0, 0 };
            idx[2] = idx[1];
            idx[1] = idx[0];
            float dst1 = Math.Abs(idx[1] - idx[2]);

            while (true)
            {
                idx[0] = random.Next(0, p.Length);
                float dst = Math.Abs(idx[0] - idx[1]);
                if (dst1 == 0 && (dst == 1 || dst == p.Length - 1))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            return idx[0];
        }

        public Bitmap GenerateFractal(int width, int height, double zoomFactor)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            float scaleZoom = (float)(1 / zoomFactor); // Aplicar zoom inverso
            float halfWidth = width / 2f;
            float halfHeight = height / 2f;

            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            int byteCount = bmpData.Stride * height;

            byte[] pixelBuffer = new byte[byteCount];
            IntPtr ptr = bmpData.Scan0;

            // Establece el buffer de píxeles con datos predeterminados
            for (int i = 0; i < byteCount; i += bytesPerPixel)
            {
                pixelBuffer[i] = 0; // Blue
                pixelBuffer[i + 1] = 0; // Green
                pixelBuffer[i + 2] = 0; // Red
                pixelBuffer[i + 3] = 255; // Alpha
            }

            unsafe
            {
                fixed (byte* p = pixelBuffer)
                {
                    byte* row = p;

                    // Dibuja el fractal
                    PointF currentPoint = new PointF(width / 2f, height / 2f);
                    int prevIndex = random.Next(0, points.Length);

                    for (int i = 0; i < width * height * 3; i++)
                    {
                        int newIndex = RandomPointIndex(points);
                        prevIndex = newIndex;

                        PointF vertex = points[newIndex];
                        currentPoint.X += (vertex.X - currentPoint.X) * r;
                        currentPoint.Y += (vertex.Y - currentPoint.Y) * r;

                        // Calcular el punto de vista ajustado
                        int x = (int)((currentPoint.X - halfWidth) * scaleZoom + halfWidth);
                        int y = (int)((currentPoint.Y - halfHeight) * scaleZoom + halfHeight);

                        if (x >= 0 && x < width && y >= 0 && y < height)
                        {
                            int offset = y * bmpData.Stride + x * bytesPerPixel;

                            // Usar el buffer de píxeles para asignar el color
                            pixelBuffer[offset] = colors[newIndex].B;
                            pixelBuffer[offset + 1] = colors[newIndex].G;
                            pixelBuffer[offset + 2] = colors[newIndex].R;
                            pixelBuffer[offset + 3] = 255; // Alpha
                        }
                    }
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelBuffer, 0, ptr, byteCount);
            bitmap.UnlockBits(bmpData);

            return bitmap;
        }

    }
}