
List<int> nummer = new List<int> { 10, 20, 10, 30, 20, 40, 50, 30 };

List<int> unikaNummer = TaBortDubbletter(nummer);

Console.WriteLine("Original lista:");
Console.WriteLine(string.Join(", ", nummer));

Console.WriteLine("Lista utan dubbletter:");
Console.WriteLine(string.Join(", ", unikaNummer));


static List<int> TaBortDubbletter(List<int> lista)
{
    return lista.Distinct().ToList();
}

