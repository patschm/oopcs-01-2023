using System.Text;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? lastname = null;

            int age = 10;
            string name = "Jan";

            bool ok = age > 10 & age < 20;

            Console.WriteLine($"{name} ({age++})");
            Console.WriteLine(age is int);

            short x = (short)age;
            long y = age;
            //var z = name as StringBuilder;

            age += 15;

            Console.WriteLine(age > 15 ? "ok":"nok");

            int? year = 3;

            Console.WriteLine(year??100);

            Console.WriteLine(lastname!.Length);

            unsafe
            {

            }
        }
    }
}