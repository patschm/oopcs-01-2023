namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expected = 3;
           Rekenmachine mc = new Rekenmachine();    
            int actual = mc.Subtract(1,2);

            Console.WriteLine(actual == expected? "OK":"NOK");
        }
    }
}