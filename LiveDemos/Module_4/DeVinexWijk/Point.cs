
namespace DeVinexWijk;

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Mwah!!
    public  Point Add(Point a, Point b)
    {
        return new Point { X = a.X + b.X, Y = a.Y + b.Y };
    }
   // public static Point Add(Point a, Point b)
    public static Point operator+(Point a, Point b)
    {
        return new Point { X = a.X + b.X, Y = a.Y + b.Y };
    }
}
