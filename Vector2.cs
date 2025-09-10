struct Vector2
{
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static double operator *(Vector2 a, Vector2 b)
    {
        return a.X * b.X + a.Y * b.Y;
    }
    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);
    }
    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X - b.X, a.Y - b.Y);
    }
    public static Vector2 operator *(Vector2 v, Matrix2 m)
    {
        return new Vector2(v.X * m.XX + v.Y * m.XY, v.X * m.YX + v.Y * m.YY) + m.Shift;
    }
    public static Vector2 operator -(Vector2 v)
    {
        return new Vector2(-v.X, -v.Y);
    }
    public static Vector2 operator !(Vector2 v)
    {
        return v / v.SquaredLength;
    }
    public static Vector2 operator *(Vector2 v, double s)
    {
        return new Vector2(v.X * s, v.Y * s);
    }
    public static Vector2 operator /(Vector2 v, double s)
    {
        return new Vector2(v.X / s, v.Y / s);
    }
    public static Vector2 operator ~(Vector2 v)
    {
        return v / v.Length;
    }
    public static double Dot(Vector2 a, Vector2 b)
    {
        return a * b;
    }
    public double X { get; }
    public double Y { get; }
    public double Length { get => Sqrt(X * X + Y * Y); }
    public double SquaredLength { get => X * X + Y * Y; }
}