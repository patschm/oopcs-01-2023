
using System.Text;

namespace Overerving;

// TL erft van Lamp. Alle eigenschappen en gedrag krijg ik automagisch mee.
// Geen multiple inheritance
// Overerving gebuik je voor het structeren van families van objecten
// Stel je dan ook altijd de vraag "Is het een..."
internal class TL : Lamp
{
    public int StartTijd { get; set; }

    public override void Aan()
    {
        for(int x= 0; x < StartTijd; x++)
        {
            Console.WriteLine("Knipperdeknipper");
            Task.Delay(200).Wait();
            Console.Clear();
            Task.Delay(200).Wait();
        }
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"TL brandt met {Lumen}lm");
        Console.ResetColor();
    }
}
