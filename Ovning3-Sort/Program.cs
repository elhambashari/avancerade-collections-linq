
List<string> ord = new List<string>
{
    "Banan",
    "Äpple",
    "Kiwi",
    "Jordgubbe",
    "Päron",
    "Apelsin"
};

Console.WriteLine("Original lista:");
Console.WriteLine(string.Join(", ", ord));

SorteraEfterLangd(ord);

Console.WriteLine("Sorterad lista efter längd:");
Console.WriteLine(string.Join(", ", ord));


static void SorteraEfterLangd(List<string> lista)
{
    lista.Sort((a, b) => a.Length.CompareTo(b.Length));
}

