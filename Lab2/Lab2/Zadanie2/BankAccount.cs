namespace Lab2;

public class BankAccount(decimal saldo, string wlasciciel)
{
    private decimal Saldo { get; set; } = saldo;

    private string Wlasciciel { get; } = wlasciciel;

    public void Wplata(decimal kwota)
    {
        Saldo += kwota;
    }

    public bool Wyplata(decimal kwota)
    {
        if (kwota > Saldo)
        {
            Console.WriteLine("Niewystarczające saldo na dokonanie wypłaty.");
            return false;
        }
        Saldo -= kwota;
        return true;
    }

    public void PokazKonto()
    {
        Console.WriteLine($"Właściciel: {Wlasciciel}, Saldo: {Saldo:C}");
    }
}