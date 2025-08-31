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
    public Range Active;
    public Layout Cut(Plane plane)
    {
        var index = 0;
        for (int i = Active.Start.Value; i < Active.End.Value; i++)
        {
            return    
        }
    }
}