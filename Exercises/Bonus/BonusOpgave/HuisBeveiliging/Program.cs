using DoomsdayPreppers;
using Heras;
using Infrac;
using Philips;

namespace HuisBeveiliging;

internal class Program
{
    static void Main(string[] args)
    {
        // Oprijlaan
        Hek hek= new Hek();
        Lamp tl= new Lamp();
        Valkuil kuil = new Valkuil();
        DetectieLus lus = new DetectieLus();

        lus.Connect(hek);
        lus.Connect(kuil); 
        lus.Connect(tl);

        // Hier komen de schurken!!!
        lus.Detect();


        // Dit keur ik niet goed.
        // Inclusief alle varianten hierop
        //hek.Open();
        //kuil.Open();
        //tl.Aan();
    }
}