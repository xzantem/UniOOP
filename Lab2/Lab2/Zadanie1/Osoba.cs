namespace Lab2
{
    public class Osoba
    {
        private string Imie { get ; }
        
        private string Nazwisko { get; }
        
        private int Wiek { get; }

        public Osoba()
        {
            while (true)
            {
                Console.Write("Wpisz imię (co najmniej 2 znaki): ");
                var imiePodane = Console.ReadLine();

                if (imiePodane is { Length: >= 2 })
                {
                    Imie = imiePodane;
                    break;
                }
                Console.WriteLine("Podane imię jest za krótkie");
            }
            while (true)
            {
                Console.Write("Wpisz nazwisko (co najmniej 2 znaki): ");
                var nazwiskoPodane = Console.ReadLine();

                if (nazwiskoPodane is { Length: >= 2 })
                {
                    Nazwisko = nazwiskoPodane;
                    break;
                }

                Console.WriteLine("Podane nazwisko jest za krótkie");
            }
            while (true)
            {
                try
                {
                    Console.Write("Wpisz wiek (co najmniej 2 znaki): ");
                    var wiekPodany = int.Parse(Console.ReadLine() ?? string.Empty);

                    if (wiekPodany > 0)
                    {
                        Wiek = wiekPodany;
                        break;
                    }

                    Console.WriteLine("Podany wiek nie jest dodatni");
                }
                catch
                {
                    Console.WriteLine("Podano nieprawidłowy wiek");
                }
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Osoba: {Imie} {Nazwisko}, {Wiek} lat");
        }
    }
}
