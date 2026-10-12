
List<Student> studenter = new List<Student>
{
    new Student { Namn = "Anna", Betyg = "A" },
    new Student { Namn = "Erik", Betyg = "B" },
    new Student { Namn = "Sara", Betyg = "A" },
    new Student { Namn = "Ali", Betyg = "C" },
    new Student { Namn = "Emma", Betyg = "B" },
    new Student { Namn = "Oskar", Betyg = "A" }
};

// Gruppera studenter efter betyg
var grupper = studenter.GroupBy(s => s.Betyg);

foreach (var grupp in grupper)
{
    Console.WriteLine($"Betyg {grupp.Key}: {grupp.Count()} studenter");

    foreach (var student in grupp)
    {
        Console.WriteLine($"- {student.Namn}");
    }
}

