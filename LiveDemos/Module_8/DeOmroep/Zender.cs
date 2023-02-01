
namespace DeOmroep;

delegate void Bericht(string message);

internal class Zender
{
    //private Bericht _subscribers;
    public event Bericht? Subscribers;
    //{
    //    add
    //    {
    //        _subscribers += value;
    //    }
    //    remove
    //    {
    //        _subscribers -= value;
    //    }
    //}

    public void BroadCast()
    {
        Console.WriteLine("De uitzending begint");
        Subscribers?.Invoke("Hallo luisteraars");
    }
}
