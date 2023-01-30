namespace MoreInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dict = new Dictionary<string, List<Func<int, string>>>();

            var result = Add(1,d:20);
            Console.WriteLine(result);
            result = Add( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(result);

            int x;
            //int xx = x;
           // DoeIets(ref x);
           DoeIets(out x);
            Console.WriteLine(x);

        }

        static void DoeIets(out int xx)
        {
            xx = 20;
        }
        //static void DoeIets(ref int xx)
        //{
        //    xx = 20;
        //}

        static int Add(int a, int b)
        {
            return a + b;
        }
        //static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        static int Add(int a, int b = 3, int c = 5, int d = 10)
        {
            return a + b + c + d;
        }
        static int Add(params int[] values)
        {
            return values.Sum();
        }
    }
}