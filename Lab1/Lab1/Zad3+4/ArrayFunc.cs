namespace Lab1
{
    public class ArrayFunc
    {
        private double[] Array { get; set; }
        public ArrayFunc()
        {
            Array = new double[10];
            for (var i = 0; i < 10; i++)
            {
                Console.Write("Wprowadź liczbę: ");
                if (double.TryParse(Console.ReadLine(), out var value))
                {
                    Array[i] = value;
                }
                else
                {
                    Console.WriteLine("Wprowadzono nieprawidłową liczbę: ");
                    i--;
                }
            }
        }
        private void Display()
        {
            Console.WriteLine($"Tablica: {string.Join(", ", Array)}");
        }
        private void DisplayReverse()
        {
            Console.WriteLine($"Tablica odwrócona: {string.Join(", ", Array.Reverse())}");
        }
        private void DisplayEven()
        {
            Console.WriteLine($"Tablica odwrócona: {string.Join(", ", Array.Where(x => x % 2 == 0))}");
        }
        private void DisplayOdd()
        {
            Console.WriteLine($"Tablica odwrócona: {string.Join(", ", Array.Where(x => x % 2 == 1))}");
        }
        private void DisplayAverage()
        {
            Console.WriteLine($"Średnia: {Array.Average()}");
        }
        private void DisplayMinimal()
        {
            Console.WriteLine($"Minimalna: {Array.Min()}");
        }
        private void DisplayMaximal()
        {
            Console.WriteLine($"Maksymalna: {Array.Max()}");
        }
        public void Menu()
        {
            do
            {
                Console.Write("Wybierz działanie programu (wyswietl: ->, wyświetl odwrotnie: <-, wyświetl parzyste: p, wyświetl nieparzyste: n, " +
                    "wyswietl maksimum: ↑, wyświetl minimum: ↓, wyświetl średnią: s, zamknij program: x): ");
                var t = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                switch (t.Key)
                {
                    case ConsoleKey.RightArrow:
                        Display();
                        break;
                    case ConsoleKey.LeftArrow:
                        DisplayReverse();
                        break;
                    case ConsoleKey.P:
                        DisplayEven();
                        break;
                    case ConsoleKey.N:
                        DisplayOdd();
                        break;
                    case ConsoleKey.UpArrow:
                        DisplayMaximal();
                        break;
                    case ConsoleKey.DownArrow:
                        DisplayMinimal();
                        break;
                    case ConsoleKey.S:
                        DisplayAverage();
                        break;
                    case ConsoleKey.X:
                        return;
                }
            } while (true);
        }
    }
}
