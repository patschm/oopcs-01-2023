using Philips;

namespace TheVirtualWorld;


internal class Program
{
    static void Main(string[] args)
    {
        // Big bang.

        Philips.Lamp tl = new Philips.Lamp();
        tl.Lumen = 200;
        tl.Kleur = ConsoleColor.Magenta;
        tl.Aan();

        Lamp schemerlamp = new Lamp(2000000, ConsoleColor.Yellow);
        schemerlamp.Aan();


        Lamp kamerlamp = new Lamp { Kleur = ConsoleColor.Red, Lumen = 300 };

        //kamerlamp.lumen = 2000000000;
        //kamerlamp.SetLumen(10000);
        kamerlamp.Lumen = 10000;
        kamerlamp.Aan();
        //Lamp[] lampen = new Lamp[10];
        //lampen[0] = tl; 



        // Big Crunch
    }
}