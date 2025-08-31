class Plane
{
    public Plane(Vector3 vector)
    {
        Vector = vector;
    }
    public Vector3 Vector { get; }
    public static Plane operator *(Plane p, Matrix3 m)
    {
        var v = p.Vector * ~m;
        return new Plane(v * (1 + ~v * m.Shift));
    }
    public ComparsionResult Compare(Point3 p)
    {
        var i = !p * !Vector;
        if (i < 1)
        {
            return ComparsionResult.Lower;
        }
        if (i == 1)
        {
            return ComparsionResult.On;
        }
        return ComparsionResult.Higher;
    }
}