using System.Collections.Generic;

class Layout
{
    public Layout(IEnumerable<Triangle3> triangles)
    {
        Triangles = triangles;
    }
    public IEnumerable<Triangle3> Triangles { get; }
    public Layout Cut(Plane3 plane)
    {
        
    }
}