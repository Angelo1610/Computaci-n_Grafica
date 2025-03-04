using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace C__Proyecto_Final
{
    public class Fractal1
    {
        private const int MaxIterations = 7000;
        private const double Scale = 2; // Escala para el tamaño del fractal

        public Bitmap GenerateFractal(int width, int height, double zoom)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            double scaleZoom = Scale / zoom;
            double halfWidth = width / 2.0;
            double halfHeight = height / 2.0;
            double inverseWidth = 1.0 / width;
            double inverseHeight = 1.0 / height;

            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            int byteCount = bmpData.Stride * height;

            byte[] pixelBuffer = new byte[byteCount];

            Parallel.For(0, height, y =>
            {
                int rowOffset = y * bmpData.Stride;
                double cy = (y - halfHeight) * scaleZoom * inverseHeight;

                for (int x = 0; x < width; x++)
                {
                    double cx = (x - halfWidth) * scaleZoom * inverseWidth;
                    double zx = 0, zy = 0;
                    int iteration = 0;

                    while (zx * zx + zy * zy < 8.0 && iteration < MaxIterations)
                    {
                        double zx2 = zx * zx - zy * zy + cx;
                        zy = 2.0 * zx * zy + cy;
                        zx = zx2;
                        iteration++;
                    }

                    int offset = rowOffset + x * bytesPerPixel;

                    if (iteration < MaxIterations)
                    {
                        pixelBuffer[offset] = 0;     // B
                        pixelBuffer[offset + 1] = 0; // G
                        pixelBuffer[offset + 2] = 0; // R
                        pixelBuffer[offset + 3] = 255; // A
                    }
                    else
                    {
                        pixelBuffer[offset] = 255;     // B
                        pixelBuffer[offset + 1] = 0;   // G
                        pixelBuffer[offset + 2] = 255; // R
                        pixelBuffer[offset + 3] = 255; // A
                    }
                }
            });

            System.Runtime.InteropServices.Marshal.Copy(pixelBuffer, 0, bmpData.Scan0, byteCount);
            bitmap.UnlockBits(bmpData);

            return bitmap;
        }

    }
}