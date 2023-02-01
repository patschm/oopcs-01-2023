

namespace Bestelling;

// Blauwdruk van een functie
delegate void Blah();

// Blauwdruk van een object
internal class Martin
{
    public void Execute(Blah functie)
    {
        Console.WriteLine("Martin voert het volgense uit");
        functie();
    }
}
