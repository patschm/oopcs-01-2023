namespace Philips;

class Lamp
{
    // Eigenschappen
    // Sla je op in fields
    private uint lumen = 100;
    //private ConsoleColor kleur;

    // Ouderwetste access methods.
    // Niet gebruiken. (C++ met zelfstudie)
    public uint GetLumen()
    {
        return lumen;
    }
    public void SetLumen(uint lm)
    {
        if (lm >= 0 && lm < 2000)
        {
            lumen = lm;
        }
    }
    // Een dotnetter doet het alsvolgt
    // Properties
    public uint Lumen
    {
        get
        {
            return lumen;
        }
        set 
        {
            if (value >= 0 && value < 2000)
            {
                lumen = value;
            }
        }  
    }
    // Auto generating properties
    public ConsoleColor Kleur { get;  set; }
    
    // Gedrag
    // Gedrag definieer je in methods.
    // Veredelde functies of procedures.
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"Lamp brandt met {Lumen}lm");
        Console.ResetColor();
    }

    // Constructors
    // Zijn bedoeld om FIELDS!!!! van een initiele waarde te vooorzien.
    public Lamp(uint lm, ConsoleColor color)
    {
        Lumen = lm;
        Kleur= color;
    }
    public Lamp()
    {
        Console.WriteLine("Default");
    }
}