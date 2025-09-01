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
        var result = new List<Triangle>();
        foreach (var item in Triangles)
        {
            var a = (plane.Compare(item.A) + 1) / 2;
            var b = (plane.Compare(item.B) + 1) / 2;
            var c = (plane.Compare(item.C) + 1) / 2;
            switch (4 * a + 2 * b + c)
            {
                case 0:
                    continue;
                case 1:
                case 2:
                case 3:
                    result.Add(item.Cut(plane));
                    break;
                case 4:
                case 5:
                case 6:
                    var r = item.CutT(plane);
                    result.Add(r.Item1);
                    result.Add(r.Item2);
                    break;
                case 7:
                    result.Add(item);
                    break;
            }
        }
        return new(result);
    }
}