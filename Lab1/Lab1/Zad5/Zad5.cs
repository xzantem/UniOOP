namespace Lab1
{
    public static class Zad5
    {
        public static void Execute()
        {
            for (var i = 20; i >= 0; i--)
            {
                if (i is 2 or 6 or 9 or 15 or 19) continue;
                Console.Write($"{i} ");
            }
        }
    }
}
