

namespace ZeFactory;

internal class Tom : Werknemer  
{
    public void DraaitShag()
    {
        Console.WriteLine("Tom draait sjekkies in elkaar");
    }
    public override void DoetIets()
    {
        DraaitShag();
    }
}
