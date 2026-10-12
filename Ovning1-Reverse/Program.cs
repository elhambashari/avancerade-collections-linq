
List<int> nummer = new List<int> { 10, 20, 30, 40, 50 };

List<int> omvandLista = VandLista(nummer);

Console.WriteLine("Original lista:");
Console.WriteLine(string.Join(", ", nummer));

Console.WriteLine("Omvänd lista:");
Console.WriteLine(string.Join(", ", omvandLista));


static List<int> VandLista(List<int> lista)
{
    List<int> nyLista = new List<int>(lista);

    nyLista.Reverse();

    return nyLista;
}

