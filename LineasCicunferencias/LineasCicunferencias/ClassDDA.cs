public class ClassDDA
{
    public static List<Point> GenerateLinePoints(int x1, int y1, int x2, int y2)
    {
        List<Point> points = new List<Point>();

        int dx = x2 - x1;
        int dy = y2 - y1;

        int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

        float xInc = dx / (float)steps;
        float yInc = dy / (float)steps;

        float x = x1, y = y1;

        for (int i = 0; i <= steps; i++)
        {
            points.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
            x += xInc;
            y += yInc;
        }

        return points;
    }
}
