struct Triangle2
{
    public Triangle2(Point2 a, Point2 b, Point2 c)
    {
        A = a;
        B = b;
        C = c;
        SignedArea = ((A > B) | (A > C)) / 2;
        Area = Abs(SignedArea);
        Normal = ~ScaledNormal;
    }
    Point2 P(Point2 a, Point2 b, double ap, double bp)
    {
        var ba = ap / (ap - bp);
        var ab = 1 - ba;
        return new(a.X * ab + b.X * ba, a.Y * ab + b.Y * ba);
    }
    public Triangle2 Cut1(double av, double bv, double cv)
    {
        return new Triangle2(A, P(A, B, av, bv), P(A, C, av, cv));
    }
    public Triangle2 Cut2(double av, double bv, double cv)
    {
        return new Triangle2(P(B, A, bv, av), B, P(B, C, bv, cv));
    }
    public (Triangle2, Triangle2) Cut3(double av, double bv, double cv)
    {
        return (new Triangle2(A, B, P(A, C, av, cv)), new Triangle2(A, B, P(B, C, av, cv)));
    }
    public Triangle2 Cut4(double av, double bv, double cv)
    {
        return new Triangle2(P(C, A, cv, av), P(C, B, cv, bv), C);
    }
    public (Triangle2, Triangle2) Cut5(double av, double bv, double cv)
    {
        return (new Triangle2(A, P(A, B, av, cv), C), new Triangle2(A, P(B, C, av, cv), C));
    }
    public (Triangle2, Triangle2) Cut6(double av, double bv, double cv)
    {
        return (new Triangle2(P(A, C, av, cv), B, C), new Triangle2(P(A, B, av, bv), B, C));
    }
    public Point2 A { get; }
    public Point2 B { get; }
    public Point2 C { get; }
    public Vector3 ScaledNormal { get; }
    public double Area { get; }
    public double SignedArea { get; }
    public Vector3 Normal { get; }
}