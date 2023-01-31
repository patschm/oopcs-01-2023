namespace Overerving;

abstract class Lamp
{
    private uint lumen = 100;

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
    public ConsoleColor Kleur { get;  set; }

    // Activeer polymorfisme voor het Aan-gedrag
    //public virtual void Aan()
    public abstract void Aan();
    //{
    //    Console.BackgroundColor = Kleur;
    //    Console.WriteLine($"Lamp brandt met {Lumen}lm");
    //    Console.ResetColor();
    //}
}