namespace ZeFactory;

// ACME is de provider van de interface
internal class ACME
{
    private IContract[] werknemers = new IContract[10];

    public void Hire(IContract wn)
    {
        for(int i = 0; i < werknemers.Length; i++) 
        { 
            if (werknemers[i] == null) 
            {
                werknemers[i] = wn;
                return;
            }
        }
    }

    public void Stoomfluit()
    {
        Console.WriteLine("ACME starts producing");
        Console.Beep(1000, 500);
        foreach (var iemand in werknemers)
        {
            iemand?.Werkt();
        }
    }
}
