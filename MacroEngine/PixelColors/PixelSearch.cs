using MacroEngine.External;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.PixelColors
{
    public class PixelSearch
    {
        public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = NativeImports.GetDC(IntPtr.Zero);
            uint pixel = NativeImports.GetPixel(hdc, x, y);
            NativeImports.ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        public static Point[] Search(Rectangle rect, Color color)
        {
            Bitmap RegionIn_Bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            ArrayList points = new ArrayList();

            int xOffset = Screen.AllScreens[0].Bounds.Left;
            int yOffset = Screen.AllScreens[0].Bounds.Top;

            BitmapData RegionIn_BitmapData = RegionIn_Bitmap.LockBits(new Rectangle(0, 0, RegionIn_Bitmap.Width, RegionIn_Bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int[] f_color = new int[3] { color.B, color.G, color.R };

            using (Graphics GFX = Graphics.FromImage(RegionIn_Bitmap))
            {
                GFX.CopyFromScreen(rect.X + xOffset, rect.Y + yOffset, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }

            unsafe
            {
                for (int y = 0; y < RegionIn_BitmapData.Height; y++)
                {
                    byte* row = (byte*)RegionIn_BitmapData.Scan0 + (y * RegionIn_BitmapData.Stride);
                    for (int x = 0; x < RegionIn_BitmapData.Width; x++)
                    {
                        if (row[x * 3] >= (f_color[0]) & row[x * 3] <= (f_color[0]))
                            if (row[(x * 3) + 1] >= (f_color[1]) & row[(x * 3) + 1] <= (f_color[1]))
                                if (row[(x * 3) + 2] >= (f_color[2]) & row[(x * 3) + 2] <= (f_color[2]))
                                    points.Add(new Point(x + rect.X, y + rect.Y));
                    }
                }
            }
            RegionIn_Bitmap.Dispose();
            return (Point[])points.ToArray(typeof(Point));
        }
    }
}