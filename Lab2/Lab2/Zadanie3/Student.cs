namespace Lab2;

public class Student(string imie, string nazwisko)
{
    public string Imie { get; } = imie;
    public string Nazwisko { get; } = nazwisko;
    private int[] Oceny { get; set; } = [];
    
    public double SredniaOcen => Oceny.Length > 0? Oceny.Average() : 0;

    public void DodajOcene(int ocena)
    {
        if (ocena is < 2 or > 5)
        {
            Console.WriteLine("Nieprawidłowa ocena. Ocena musi być liczbą z przedziału od 2 do 5.");
            return;
        }
        Oceny = Oceny.Append(ocena).ToArray();
    }
}