namespace Bonus;

class Dummy
{
    public string First { get; set; }
    public string Last { get; set; }
}

internal class Program
{
    static bool FirstNameStartsWithAnF(Person p)
    {
        return p!.FirstName!.StartsWith("F");
    }
    static bool FirstNameStartsWithAnG(Person p)
    {
        return p!.FirstName!.StartsWith("G");
    }

    static void Main(string[] args)
    {
        List<Person> people = CreateList();
        char[] letters = { 'A', 'B', 'C' };

        //string letter = Console.ReadLine();
        // Linq
        //var results = people.Where(p=>letters.Contains(p.FirstName.First()));
        var results = people
            .Where(p => letters.Contains(p.FirstName.First()))
            .OrderByDescending(p => p.LastName)
            .Select(p => new  { First = p.FirstName, Last = p.LastName });

        var q2 = from p in people 
                 where letters.Contains(p.FirstName.First()) 
                 orderby p.LastName descending 
                 select new { First = p.FirstName, Last = p.LastName } ;

        foreach (var person in q2)
        {
            Console.WriteLine($"{person.First} {person.Last}");
            //Console.WriteLine(person);
        }
    }

    private static List<Person> CreateList()
    {
        return new Bogus.Faker<Person>()
            .RuleFor(p => p.Id, f => f.IndexFaker)
            .RuleFor(p => p.Age, f => f.Random.Number(0, 123))
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .Generate(1000)
            .ToList();
    }
}