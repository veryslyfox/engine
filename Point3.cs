struct Point3
{
    public Point3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static explicit operator Vector3(Point3 p)
    {
        return new Vector3(p.X, p.Y, p.Z);
    }
    public static explicit operator Point3(Vector3 p)
    {
        return new Point3(p.X, p.Y, p.Z);
    }
    public static Point3 operator +(Point3 p, Vector3 v)
    {
        return new Point3(p.X + v.X, p.Y + v.Y, p.Z + v.Z);
    }
    public static Point3 operator -(Point3 p, Vector3 v)
    {
        return new Point3(p.X - v.X, p.Y - v.Y, p.Z - v.Z);
    }
    public static Vector3 operator >(Point3 a, Point3 b)
    {
        return new Vector3(b.X - a.X, b.Y - a.Y, b.Z - a.Z);
    }
    public static Vector3 operator <(Point3 a, Point3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    public static Vector3 operator !(Point3 p)
    {
        return new Vector3(p.X, p.Y, p.Z);
    }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
}