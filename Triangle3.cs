struct Triangle3
{
    public Triangle3(Point3 a, Point3 b, Point3 c)
    {
        A = a;
        B = b;
        C = c;
        Init();
    }
    public void Rotate(Matrix3 matrix)
    {
        A = A * matrix;
        B = B * matrix;
        C = C * matrix;
        Init();
    }
    void Init()
    {
        ScaledNormal = (A > B) | (A > C);
        Area = ScaledNormal.Length / 2;
        Normal = ~ScaledNormal;
    }
    public Point3 A { get; private set; }
    public Point3 B { get; private set; }
    public Point3 C { get; private set; }
    public Vector3 ScaledNormal { get; private set; }
    public double Area { get; private set; }
    public Vector3 Normal { get; private set; }
}