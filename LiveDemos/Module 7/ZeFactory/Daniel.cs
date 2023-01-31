namespace ZeFactory;

internal class Daniel : Werknemer
{
    public void KanIets()
    {
        Console.WriteLine("Daniel timmert een spijker in een plank en trekt hem er weer uit want de spijker is krom");
    }
    public override void DoetIets()
    {
        KanIets();
    }
}
