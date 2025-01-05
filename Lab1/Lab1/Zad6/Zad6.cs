namespace Lab1.Zad6
{
    public static class Zad6
    {
        public static void Execute()
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                if (!double.TryParse(Console.ReadLine(), out var value)) continue;
                if (value > 0) break;
            }
        }
    }
}
