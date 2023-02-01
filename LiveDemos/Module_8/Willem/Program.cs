namespace Willem;

internal class Program
{
    static void Main(string[] args)
    {
        var wk = new WillemKlein();
        var sm = new SimonVdMeer();

        MathDel calc = sm.Add;
        calc += sm.Add;
        calc += sm.Subtract;
        calc -=  sm.Subtract;

        foreach(var del in calc.GetInvocationList())
        {
            Console.WriteLine($"{del.Method.Name}");
        }

        int result = calc(1, 2);

        Console.WriteLine($"Het resultaat is {result}");
       // wk.Bereken(sm.Subtract, 8, 9);
    }
}