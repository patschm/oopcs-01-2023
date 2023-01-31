namespace ZeFactory;

// De werknemer is de consumer van de inteface.
// Hij implementeert de inreface.
internal class Werknemer: Mens, IContract
{
    public virtual void DoetIets()
    {
        Console.WriteLine("tralalala");
    }

    public void Werkt()
    {
        DoetIets();
    }
}
