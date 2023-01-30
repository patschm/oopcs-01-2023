namespace Funcprocs;

internal class Program
{
    static void Main(string[] args)
    {
        ShowWelcome();
        int age = YourAge();
        ShowAge(age);
        SayGoodbye(age);
    }

    static void SayGoodbye(int age)
    {
        if (age > 60)
        {
            Console.WriteLine("Bye bye old person");
        }
        else
        {
            Console.WriteLine("Bye!!");
        }
    }

    static void ShowAge(int leeftijd)
    {
        Console.WriteLine($"Your age is: {leeftijd}");
    }

    // Procedure
    static void ShowWelcome()
    {
        Console.WriteLine("Welcome stranger of unspecified age");
    }

    // Function
    static int YourAge()
    {
        do
        {
            Console.WriteLine("What's your age?");
            string? sAge = Console.ReadLine();
            if (int.TryParse(sAge, out int age))
            {
                return age;
            }
        }
        while (true);
    }
}