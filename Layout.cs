using System.Collections.Generic;
class Layout
{
    public Layout(Triangle3[] triangles)
    {
        Triangles = triangles;
        ValidLength = Triangles.Length;
    }
    public Triangle3[] Triangles { get; }
    public int ValidLength { get; }
    public void Cut(Plane3 plane)
    {
        var index = 0;
        for (int i = 0; i < ValidLength; i++)
        {
            if (
            plane.Compare(Triangles[i].A) &
            plane.Compare(Triangles[i].B) &
            plane.Compare(Triangles[i].C))
            {
                Triangles[i] = Triangles[index];
            }
        }
    }
}