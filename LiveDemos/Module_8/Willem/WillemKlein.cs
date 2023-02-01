namespace Willem;

delegate int MathDel(int a, int b);

internal class WillemKlein
{
    public void Bereken(MathDel functie, int x, int y)
    {
        Console.WriteLine("Willem zet zijn tanden in het probleem.....");

        int result = functie(x, y);
        // TODO

        Console.WriteLine($"Willem kraait het antwoord is: {result}");
    }
}
