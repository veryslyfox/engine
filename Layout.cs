class Layout
{
    public Layout(Triangle[] triangles)
    {
        Triangles = triangles;
    }
    public Triangle this[int index]
    {
        get => Triangles[index];
        set => Triangles[index] = value;
    }
    public Triangle[] Triangles { get; }
}