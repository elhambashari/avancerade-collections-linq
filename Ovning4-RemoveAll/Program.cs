
List<int> nummer = new List<int>
{
    15, 8, 3, 20, 11, 6, 7, 14, 1, 9
};

Console.WriteLine("Original lista:");
Console.WriteLine(string.Join(", ", nummer));

// Ta bort alla jämna tal
nummer.RemoveAll(n => n % 2 == 0);

Console.WriteLine("Lista utan jämna tal:");
Console.WriteLine(string.Join(", ", nummer));

// Sortera med LINQ
List<int> sorteradLista = nummer.OrderBy(n => n).ToList();

Console.WriteLine("Sorterad lista:");
Console.WriteLine(string.Join(", ", sorteradLista));

