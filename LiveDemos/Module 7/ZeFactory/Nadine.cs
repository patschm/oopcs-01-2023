namespace ZeFactory;

internal class Nadine: Werknemer
{
    public void MaaktBommetjes()
    {
        Console.WriteLine("Nadine knutselt een bom in elkaar");
    }
    public override void DoetIets()
    {
        MaaktBommetjes();
    }
}
