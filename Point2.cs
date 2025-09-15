struct Point2
{
    public Point2(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static explicit operator Vector2(Point2 p)
    {
        return new Vector2(p.X, p.Y);
    }
    public static explicit operator Point2(Vector2 p)
    {
        return new Point2(p.X, p.Y);
    }
    public static Point2 operator +(Point2 p, Vector2 v)
    {
        return new Point2(p.X + v.X, p.Y + v.Y);
    }
    public static Point2 operator -(Point2 p, Vector2 v)
    {
        return new Point2(p.X - v.X, p.Y - v.Y);
    }
    public static Vector2 operator >(Point2 a, Point2 b)
    {
        return new Vector2(b.X - a.X, b.Y - a.Y);
    }
    public static Vector2 operator <(Point2 a, Point2 b)
    {
        return new Vector2(a.X - b.X, a.Y - b.Y);
    }
    public static Vector2 operator !(Point2 p)
    {
        return new Vector2(p.X, p.Y);
    }
    public static Point2 operator *(Point2 p, Matrix2 m)
    {
        return new Point2(p.X * m.XX + p.Y * m.XY, p.X * m.YX + p.Y * m.YY) + m.Shift;
    }
    public double X { get; }
    public double Y { get; }
}