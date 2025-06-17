using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineasCicunferencias
{
    internal class ClassBresenhamCirculo
    {
        public static List<Point> GenerateCirclePoints(int radius)
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                // Genera los 8 puntos simétricos
                points.Add(new Point(x, y));
                points.Add(new Point(-x, y));
                points.Add(new Point(x, -y));
                points.Add(new Point(-x, -y));
                points.Add(new Point(y, x));
                points.Add(new Point(-y, x));
                points.Add(new Point(y, -x));
                points.Add(new Point(-y, -x));

                if (d < 0)
                    d = d + 4 * x + 6;
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            return points;
        }
    }
}
