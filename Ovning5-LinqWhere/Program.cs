
List<Produkt> produkter = new List<Produkt>
{
    new Produkt { Namn = "Mjölk", Pris = 20 },
    new Produkt { Namn = "Bröd", Pris = 35 },
    new Produkt { Namn = "Ost", Pris = 85 },
    new Produkt { Namn = "Kaffe", Pris = 70 },
    new Produkt { Namn = "Smör", Pris = 55 },
    new Produkt { Namn = "Ägg", Pris = 40 }
};

Console.WriteLine("Alla produkter:");

foreach (Produkt produkt in produkter)
{
    Console.WriteLine($"{produkt.Namn}: {produkt.Pris} kr");
}

// Filtrera och sortera med LINQ
List<Produkt> dyraProdukter = produkter
    .Where(p => p.Pris > 50)
    .OrderByDescending(p => p.Pris)
    .ToList();

Console.WriteLine("\nProdukter över 50 kr:");

foreach (Produkt produkt in dyraProdukter)
{
    Console.WriteLine($"{produkt.Namn}: {produkt.Pris} kr");
}

