

namespace ZeFactory;

internal class Bokito : IContract, IBlijdorp
{
    public void DoetIets()
    {
        Console.WriteLine("Bokito draait sjekkies");
    }

    void IBlijdorp.Werkt()
    {
        Console.WriteLine("Ramt dames in elkaar");
    }

    public void Werkt()
    {
       DoetIets();
    }
}
