struct Triangle
{
    public Triangle(Point3 a, Point3 b, Point3 c)
    {
        A = a;
        B = b;
        C = c;
        ScaledNormal = (A > B) | (A > C);
        Area = ScaledNormal.Length / 2;
        Normal = ~ScaledNormal;
    }
    public Triangle Cut1(Plane plane, double av, double bv, double cv)
    {
        var t_ab = av / (av - bv);
        var t_ac = av / (av - cv);
        return new Triangle(A, (Point3)(!A * (1 - t_ab) + !B * t_ab), (Point3)(!A * (1 - t_ab) + !B * t_ab));
    }
    public Triangle Cut2(Plane plane, double av, double bv, double cv)
    {
        var t_ba = bv / (bv - av);
        var t_bc = bv / (bv - cv);
        return new Triangle((Point3)(!B * (1 - t_ba) + !A * t_ba), B, (Point3)(!B * (1 - t_bc) + !C * t_bc));
    }
    public (Triangle, Triangle) Cut3(Plane plane, double av, double bv, double cv)
    {
        
    }
    public Triangle Cut4(Plane plane, double av, double bv, double cv)
    {
        var t_ca = cv / (cv - av);
        var t_cb = cv / (cv - av);
        return new Triangle((Point3)(!C * (1 - t_ca) + !A * t_ca), (Point3)(!C * (1 - t_cb) + !B * t_cb), C);
    }
    public (Triangle, Triangle) Cut5(Plane plane, double av, double bv, double cv)
    {

    }
    public (Triangle, Triangle) Cut6(Plane plane, double av, double bv, double cv)
    {

    }
    public Point3 A { get; }
    public Point3 B { get; }
    public Point3 C { get; }
    public Vector3 ScaledNormal { get; }
    public double Area { get; }
    public Vector3 Normal { get; }
}