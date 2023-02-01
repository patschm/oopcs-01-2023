using System.Text;

namespace Swapper;

internal class Program
{
    public static int Aantal { get; private set; }

    static void Main(string[] args)
    {
        KipCaravan<long> k3 = new KipCaravan<long>();
        var k1 = Create<StringBuilder>();
        k1.Append("Haha");
        Console.WriteLine(k1);
        //KipCaravan a = new KipCaravan { Aantal = 20 };
        //KipCaravan b = new KipCaravan { Aantal = 200 };

        decimal a = 10;
        decimal b = 20;

        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    static void Swap<T>(ref T aa, ref T bb) //where T : class, new()
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }

    //static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref double aa, ref double bb)
    //{
    //    double tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}

    static T Create<T>() where T : new()
    {
        return new T();
    }
}