struct Triangle2
{
    public Triangle2(Point2 a, Point2 b, Point2 c)
    {
        A = a;
        B = b;
        C = c;
        SignedArea = (A > B) | (A > C);
        Area = Abs(SignedArea);
        Normal = ~ScaledNormal;
    }
    Point2 P(Point2 a, Point2 b, double ap, double bp)
    {
        var ba = ap / (ap - bp);
        var ab = 1 - ba;
        return new(a.X * ab + b.X * ba, a.Y * ab + b.Y * ba);
    }
    public Triangle2 Cut1(Plane3 plane, double av, double bv, double cv)
    {
        return new Triangle2(A, P(A, B, av, bv), (Point3)(!A * (1 - t_ab) + !B * t_ab));
    }
    public Triangle2 Cut2(Plane3 plane, double av, double bv, double cv)
    {
        var t_ba = bv / (bv - av);
        var t_bc = bv / (bv - cv);
        return new Triangle2((Point3)(!B * (1 - t_ba) + !A * t_ba), B, (Point3)(!B * (1 - t_bc) + !C * t_bc));
    }
    public (Triangle2, Triangle2) Cut3(Plane3 plane, double av, double bv, double cv)
    {

    }
    public Triangle3 Cut4(Plane3 plane, double av, double bv, double cv)
    {
        var t_ca = cv / (cv - av);
        var t_cb = cv / (cv - av);
        return new Triangle3((Point3)(!C * (1 - t_ca) + !A * t_ca), (Point3)(!C * (1 - t_cb) + !B * t_cb), C);
    }
    public (Triangle3, Triangle3) Cut5(Plane3 plane, double av, double bv, double cv)
    {

    }
    public (Triangle3, Triangle3) Cut6(Plane3 plane, double av, double bv, double cv)
    {

    }
    public Point2 A { get; }
    public Point2 B { get; }
    public Point2 C { get; }
    public Vector3 ScaledNormal { get; }
    public double Area { get; }
    public double SignedArea { get; }
    public Vector3 Normal { get; }
}