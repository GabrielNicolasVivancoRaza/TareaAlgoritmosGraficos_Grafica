﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineasCicunferencias
{
    internal class ClassBrsenham
    {
        public static List<Point> GenerateLinePoints(int x1, int y1, int x2, int y2)
        {
            List<Point> points = new List<Point>();

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x1, y1));

                if (x1 == x2 && y1 == y2)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }

            return points;
        }
    }
}
