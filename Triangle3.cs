struct Triangle3
{
    public Triangle3(Point3 a, Point3 b, Point3 c)
    {
        A = a;
        B = b;
        C = c;
        ScaledNormal = (A > B) | (A > C);
        Area = ScaledNormal.Length / 2;
        Normal = ~ScaledNormal;
    }
    public Point3 A { get; }
    public Point3 B { get; }
    public Point3 C { get; }
    public Vector3 ScaledNormal { get; }
    public double Area { get; }
    public Vector3 Normal { get; }
}