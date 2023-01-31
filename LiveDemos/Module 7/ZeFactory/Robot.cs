namespace ZeFactory;

// Je erft van een class en je IMPLEMNETEERT een interface
internal class Robot: IContract
{
    public void Werkt()
    {
        Console.WriteLine("De robot maakt bommetjes");
    }
}
