namespace EvoltieTheorieDerDelegates;

delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. .NET officieel gelanceerd. 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1,2);

        // 2005: Framework 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3, 4);

        // 2007. Framework 3.0 e.v.
        MathDel m4 =  (a, b) => a + b;

        // Procedures
        Action<int> a1 = Haha;
        a1(5);

        // Functions
        Func<int, int, int> f1 = Add;
        result = f1(8,9);
        Console.WriteLine(result);

        result = m4(4,5);

        Func<int, int, int> m5 = (a, b)=> a + b;

        result = m5(5, 6);

        Predicate

        Console.WriteLine($"Result = {result}");
    }

    private static int DoeIets()
    {
        return 42;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Haha(int x)
    {
        Console.WriteLine("Hoi " + x);
    }
}