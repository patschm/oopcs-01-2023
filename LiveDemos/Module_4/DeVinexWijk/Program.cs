namespace DeVinexWijk;

internal class Program
{
    static void Main(string[] args)
    {
        //FlatDemo();
        PointDemo();

    }

    private static void PointDemo()
    {
        Point p1 = new Point { X=10, Y=20 };
        Point p2 = new Point { X=100, Y=200 };

        Point p3 = p1 + p2;

        Console.WriteLine($"({p3.X}, {p3.Y})");
    }

    static void FlatDemo()
    {
        // Etage.elevator.Call(1000);


        Etage[] flat = new Etage[40];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { Nummer = i };
        }

        flat[27].CallElevator();

        foreach (var et in flat)
        {
            et.ElevatorStatus();
        }
    }
}