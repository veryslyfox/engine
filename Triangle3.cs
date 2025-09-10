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
    
    public Triangle3 Cut1(Plane3 plane, double av, double bv, double cv)
    {
        var t_ab = av / (av - bv);
        var t_ac = av / (av - cv);
        return new Triangle3(A, (Point3)(!A * (1 - t_ab) + !B * t_ab), (Point3)(!A * (1 - t_ab) + !B * t_ab));
    }
    public Triangle3 Cut2(Plane3 plane, double av, double bv, double cv)
    {
        var t_ba = bv / (bv - av);
        var t_bc = bv / (bv - cv);
        return new Triangle3((Point3)(!B * (1 - t_ba) + !A * t_ba), B, (Point3)(!B * (1 - t_bc) + !C * t_bc));
    }
    public (Triangle3, Triangle3) Cut3(Plane3 plane, double av, double bv, double cv)
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
    public Point3 A { get; }
    public Point3 B { get; }
    public Point3 C { get; }
    public Vector3 ScaledNormal { get; }
    public double Area { get; }
    public Vector3 Normal { get; }
}