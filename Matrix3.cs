struct Matrix3
{
    public Matrix3(double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz, Vector3 shift)
    {
        XX = xx;
        XY = xy;
        XZ = xz;
        YX = yx;
        YY = yy;
        YZ = yz;
        ZX = zx;
        ZY = zy;
        ZZ = zz;
        Shift = shift;
    }

    public double XX { get; }
    public double XY { get; }
    public double XZ { get; }
    public double YX { get; }
    public double YY { get; }
    public double YZ { get; }
    public double ZX { get; }
    public double ZY { get; }
    public double ZZ { get; }
    public Vector3 Shift { get; }
    public static Matrix3 operator ~(Matrix3 m)
    {
        return new(m.XX, m.XY, m.XZ, m.YX, m.YY, m.YZ, m.ZX, m.ZY, m.ZZ, new Vector3(0, 0, 0));
    }
}