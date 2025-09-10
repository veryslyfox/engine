class Plane3
{
    public Plane3(Vector3 vector)
    {
        Vector = vector;
        Inverse = !vector;
    }
    public Vector3 Vector { get; }
    Vector3 Inverse { get; }
    public bool Orientation { get; }
    public static Plane3 operator *(Plane3 p, Matrix3 m)
    {
        var v = p.Vector * ~m;
        return new Plane3(v * (1 + ~v * m.Shift));
    }
    public double Compare(Point3 p)
    {
        return (1 - (!p * Inverse));
    }
}