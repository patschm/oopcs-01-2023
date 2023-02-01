
namespace Tekenen;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);
    }

    private static void DoeIets(Point bla)
    {
        bla.X = 100;
        bla.Y = 200;
    }
}