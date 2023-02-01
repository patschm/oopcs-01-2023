namespace DeOmroep;

internal class OntvangstMethodes
{
    public static void ViaKabel(string bericht)
    {
        Console.WriteLine($"Via de kabel ontvangen: {bericht}");
    }
    public static void ViaSMS(string bericht)
    {
        Console.WriteLine($"Via de SMS ontvangen: {bericht}");
    }
    public static void ViaEther(string bericht)
    {
        Console.WriteLine($"Via de ether ontvangen: {bericht}");
    }
    public static void ViaPostduif(string bericht)
    {
        Console.WriteLine($"Via de postduif ontvangen: {bericht}");
    }
    public static void ViaTamTam(string bericht)
    {
        Console.WriteLine($"Via de tam tam ontvangen: {bericht}");
    }
}
