namespace Overerving;

internal class Program
{
    static void Main(string[] args)
    {
        // Generaliseren!!!
        Lamp t1 = new TL { Kleur = ConsoleColor.White, Lumen = 200, StartTijd = 2 };
        //t1.Aan();
        DoeIets(t1);

        LED t2 = new LED { Kleur = ConsoleColor.Yellow };
        //t2.Aan();
        DoeIets(t2);

        //TL tmp = t1 as TL;
        //Console.WriteLine(tmp.StartTijd);
     
    }
    static void DoeIets(Lamp t)
    {
        t.Aan();
    }
    
}