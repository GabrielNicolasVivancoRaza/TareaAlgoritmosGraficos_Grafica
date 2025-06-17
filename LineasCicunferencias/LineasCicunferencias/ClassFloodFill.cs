using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineasCicunferencias
{
    internal class ClassFloodFill
    {
        public static void FloodFill(Bitmap bmpOriginal, int startX, int startY, Color targetColor, Color fillColor, PictureBox picCanvas)
        {
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            // Copiar el bitmap original para trabajar sobre una instancia segura
            Bitmap bmp = new Bitmap(bmpOriginal);
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(startX, startY));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();

                if (p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height)
                    continue;

                Color currentColor = bmp.GetPixel(p.X, p.Y);
                if (currentColor.ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, fillColor);

                picCanvas.Image = (Bitmap)bmp.Clone(); 
                Application.DoEvents(); 
                Thread.Sleep(1); 

                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X, p.Y + 1)); 
                stack.Push(new Point(p.X + 1, p.Y)); 
                stack.Push(new Point(p.X, p.Y - 1)); 
            }

            picCanvas.Image = bmp;
        }


    }
}
