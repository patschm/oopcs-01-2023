

namespace Overerving;

internal class LED: Lamp
{
    // override het virtual gedrag met het specifieke gedrag (OPTIONEEL)
    public override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"LED brandt met {Lumen}lm");
        Console.ResetColor();
    }
}
