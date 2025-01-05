namespace Lab2;

public class Sumator(params double[] liczby)
{
    private double[] Liczby { get; set; } = liczby;

    public double Suma()
    {
        return Liczby.Sum();
    }
    public double SumaPodziel2()
    {
        return Liczby.Where(liczba => liczba % 2 == 0).Sum();
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }

    public void WypiszElementy()
    {
        var str = string.Join(", ", Liczby);
        Console.WriteLine($"Elementy: {str}");
    }

    public void WypiszPomiedzy(int lowIndex, int highIndex)
    {
        var str = string.Join(", ", Liczby
            .Where((_, index) => index >= lowIndex && index <= highIndex));
        Console.WriteLine($"Elementy pomiędzy indeksem {lowIndex} a {highIndex}: {str}");
    }
}