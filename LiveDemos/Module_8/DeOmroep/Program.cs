namespace DeOmroep;

internal class Program
{
    static void Main(string[] args)
    {
        Zender veronica= new Zender();
        veronica.Subscribers += OntvangstMethodes.ViaPostduif;
        veronica.Subscribers += OntvangstMethodes.ViaSMS;
        veronica.Subscribers += OntvangstMethodes.ViaEther;
        veronica.Subscribers += OntvangstMethodes.ViaKabel;
        veronica.Subscribers += OntvangstMethodes.ViaTamTam;
        veronica.Subscribers += OntvangstMethodes.ViaPostduif;
        veronica.Subscribers += OntvangstMethodes.ViaSMS;
        veronica.Subscribers += OntvangstMethodes.ViaEther;
        veronica.Subscribers += OntvangstMethodes.ViaKabel;
        veronica.Subscribers += OntvangstMethodes.ViaTamTam;
        veronica.Subscribers += OntvangstMethodes.ViaPostduif;
        veronica.Subscribers += OntvangstMethodes.ViaSMS;
        veronica.Subscribers += OntvangstMethodes.ViaEther;
        veronica.Subscribers += OntvangstMethodes.ViaKabel;
        veronica.Subscribers += OntvangstMethodes.ViaTamTam;
        veronica.Subscribers += OntvangstMethodes.ViaPostduif;

        veronica.BroadCast();

        //veronica.subscribers("Heya klojo's");

    }
}