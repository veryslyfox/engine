struct Matrix2
{
    public Matrix2(double xx, double xy, double yx, double yy, Vector2 shift)
    {
        XX = xx;
        XY = xy;
        YX = yx;
        YY = yy;
        Shift = shift;
    }

    public double XX { get; }
    public double XY { get; }
    public double YX { get; }
    public double YY { get; }
    public Vector2 Shift { get; }
    public static Matrix2 operator ~(Matrix2 m)
    {
        return new(m.XX, m.XY, m.YX, m.YY, new Vector2(0, 0));
    }
}