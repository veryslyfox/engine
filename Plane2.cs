class Plane2
{
    public Plane2(Vector2 vector)
    {
        Vector = vector;
        Inverse = !vector;
    }
    public Vector2 Vector { get; }
    Vector2 Inverse { get; }
    public bool Orientation { get; }
    public static Plane2 operator *(Plane2 p, Matrix2 m)
    {
        var v = p.Vector * ~m;
        return new Plane2(v * (1 + ~v * m.Shift));
    }
    public double Compare(Point2 p)
    {
        return (1 - (!p * Inverse));
    }
}