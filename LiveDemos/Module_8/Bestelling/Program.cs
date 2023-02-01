namespace Bestelling;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick p = new Patrick();
        Martin m = new Martin();

        m.Execute(p.Instructies);
        m.Execute(Ontplof);

        Blah[] blahs= new Blah[10];
        blahs[0] = Ontplof;
        blahs[1] = p.Instructies;
    }

    static void Ontplof()
    {
        Console.WriteLine("Kabooom");
    }

    static Blah Tjah()
    {
        return Ontplof;

    }
}