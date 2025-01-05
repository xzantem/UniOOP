namespace Lab2;

public class Licz(double initial)
{
    private double _value = initial;

    public void Dodaj(int liczba)
    {
        _value += liczba;
    }

    public void Odejmij(int liczba)
    {
        _value -= liczba;
    }

    public void PokazStan()
    {
        Console.WriteLine($"Stan liczby: {_value}");
    }
}