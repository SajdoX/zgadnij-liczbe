
Random r = new Random();

int liczba = r.Next(1, 11);
bool wygrana = false;

Console.WriteLine(liczba);
Console.WriteLine("Zgadnij liczbę.");

while (!wygrana)
{
    int wprowadz = int.Parse(Console.ReadLine());
    
    if (wprowadz == liczba)
    {
        Console.WriteLine("Wygrałeś!!!");
        wygrana = true;
    }

    if (wprowadz < liczba)
    {
        Console.WriteLine("Wprowadzona liczba jest mniejsza od wylosowanej.");
    }
    else if (wprowadz > liczba)
    {
        Console.WriteLine("Wprowadzona liczba jest większa od wylosowanej.");
    }
}