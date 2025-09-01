class Plane
{
    public Plane(Vector3 vector)
    {
        Vector = vector;
    }
    public Vector3 Vector { get; }
    public bool Orientation { get; }
    public static Plane operator *(Plane p, Matrix3 m)
    {
        var v = p.Vector * ~m;
        return new Plane(v * (1 + ~v * m.Shift));
    }
    public int Compare(Point3 p)
    {
        var i = !p * !Vector;
        if (i < 1)
        {
            return -(Orientation ? 1 : -1);
        }
        if (i == 1)
        {
            return 0;
        }
        return (Orientation ? 1 : -1);
    }
}