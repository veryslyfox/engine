struct Plane2
{
    public Plane2(Vector2 vector, double d)
    {
        Vector = vector;
        D = d;
    }
    public Vector2 Vector { get; }
    public double D { get; }
    public static Plane2 operator *(Plane2 p, Matrix2 m)
    {
        return new Plane2(p.Vector * ~m, p.D - p.Vector * m.Shift);
    }
    public bool Compare(Point2 p)
    {
        return !p * Vector < D;
    }
}