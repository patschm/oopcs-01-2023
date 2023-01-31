namespace ZeFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Tom tom = new Tom();
        Nadine nadine = new Nadine();
        Daniel daniel= new Daniel();
        Bokito bok = new Bokito();
        Robot rob = new Robot();
        ACME acm = new ACME();

        acm.Hire(rob);
        acm.Hire(bok);
        acm.Hire(daniel);   
        acm.Stoomfluit();
    }
}