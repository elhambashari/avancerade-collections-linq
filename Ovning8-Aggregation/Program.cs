
List<int> nummer = new List<int>
{
    10, 25, 30, 15, 50, 20
};

Console.WriteLine("Lista med nummer:");
Console.WriteLine(string.Join(", ", nummer));

// Beräkna summan
int summa = nummer.Sum();

// Beräkna medelvärdet
double medelvarde = nummer.Average();

// Hitta största talet
int max = nummer.Max();

// Hitta minsta talet
int min = nummer.Min();

// Visa resultat
Console.WriteLine($"Summa: {summa}");
Console.WriteLine($"Medelvärde: {medelvarde:F2}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");

