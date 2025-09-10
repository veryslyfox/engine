struct Vector3
{
    public Vector3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static double operator *(Vector3 a, Vector3 b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    public static Vector3 operator |(Vector3 a, Vector3 b)
    {
        return new Vector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
    }
    public static Vector3 operator *(Vector3 v, Matrix3 m)
    {
        return new Vector3(v.X * m.XX + v.Y * m.XY + v.Z * m.XZ, v.X * m.YX + v.Y * m.YY + v.Z * m.YZ, v.X * m.ZX + v.Y * m.ZY + v.Z * m.ZZ) + m.Shift;
    }
    public static Vector3 operator -(Vector3 v)
    {
        return new Vector3(-v.X, -v.Y, -v.Z);
    }
    public static Vector3 operator !(Vector3 v)
    {
        return v / v.SquaredLength;
    }
    public static Vector3 operator *(Vector3 v, double s)
    {
        return new Vector3(v.X * s, v.Y * s, v.Z * s);
    }
    public static Vector3 operator /(Vector3 v, double s)
    {
        return new Vector3(v.X / s, v.Y / s, v.Z / s);
    }
    public static Vector3 operator ~(Vector3 v)
    {
        return v / v.Length;
    }
    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        return a | b;
    }
    public static double Dot(Vector3 a, Vector3 b)
    {
        return a * b;
    }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
    public double Length { get => Sqrt(X * X + Y * Y + Z * Z); }
    public double SquaredLength { get => X * X + Y * Y + Z * Z; }
}