class Plane3
{
    public Plane3(Vector3 vector, double d)
    {
        Vector = vector;
        D = d;
    }
    public Vector3 Vector { get; }
    public double D { get; }
    public static Plane3 operator *(Plane3 p, Matrix3 m)
    {
        return new Plane3(p.Vector * ~m, p.D - p.Vector * m.Shift);
    }
    public bool Compare(Point3 p)
    {
        return !p * Vector < D;
    }
}