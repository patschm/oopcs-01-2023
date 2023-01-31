namespace DeVinexWijk;

internal class Etage
{
    private static Lift elevator = new Lift();

    public int Nummer { get; set; }

    public void CallElevator()
    {
        elevator.Call(Nummer);
    }
    public void ElevatorStatus()
    {
        //Console.WriteLine($"Kom naar de {this.Nummer}e verdieping");
        Console.WriteLine($"Lift staat op de {elevator.CurrentFloor} verdieping");
    }
}
