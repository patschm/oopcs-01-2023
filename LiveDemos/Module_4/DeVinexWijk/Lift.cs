

namespace DeVinexWijk;

internal class Lift
{
    public int CurrentFloor { get; set; }

    public void Call(int floor)
    {
        Console.WriteLine("Zzzzzzzzzzzzzzzz. Ben onderweg....");
        CurrentFloor = floor;
        //Console.Beep(4000, 1000);
    }

}
