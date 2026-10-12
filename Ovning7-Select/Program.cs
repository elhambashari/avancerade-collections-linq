
List<Anstalld> anstallda = new List<Anstalld>
{
    new Anstalld { Namn = "Anna", Lon = 30000 },
    new Anstalld { Namn = "Erik", Lon = 35000 },
    new Anstalld { Namn = "Sara", Lon = 40000 },
    new Anstalld { Namn = "Ali", Lon = 28000 }
};

Console.WriteLine("Ursprungliga löner:");

foreach (var person in anstallda)
{
    Console.WriteLine($"{person.Namn}: {person.Lon} kr");
}

// Öka lönen med 10% med LINQ Select
var nyaLoner = anstallda
    .Select(person => new
    {
        Namn = person.Namn,
        NyLon = person.Lon * 1.10m
    })
    .ToList();

Console.WriteLine("\nLöner efter 10% ökning:");

foreach (var person in nyaLoner)
{
    Console.WriteLine($"{person.Namn}: {person.NyLon} kr");
}

