using System.Collections.Generic;

class Layout
{
    public Layout(IEnumerable<Triangle> triangles)
    {
        Triangles = triangles;
    }
    public IEnumerable<Triangle> Triangles { get; }
    //TODO: Rewrite it with ranges
    public Layout Cut(Plane plane)
    {
        
    }
}