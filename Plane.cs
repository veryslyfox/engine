class Plane
{
    public Plane(Vector3 vector)
    {
        Vector = vector;
        Length = vector.Length;
        Inverse = !vector;
    }
    public Vector3 Vector { get; }
    double Length { get; }
    Vector3 Inverse { get; }
    public bool Orientation { get; }
    public static Plane operator *(Plane p, Matrix3 m)
    {
        var v = p.Vector * ~m;
        return new Plane(v * (1 + ~v * m.Shift));
    }
    public double Compare(Point3 p)
    {
        return (1 - (!p * Inverse)) * Length;
    }
}