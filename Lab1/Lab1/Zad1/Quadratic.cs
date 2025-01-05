namespace Lab1
{
    internal class Quadratic
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Quadratic()
        {
            Console.Write("Wprowadź liczbę (a): ");
            if (!double.TryParse(Console.ReadLine(), out var a) || a == 0) return;
            A = a;
            Console.Write("Wprowadź liczbę (b): ");
            if (!double.TryParse(Console.ReadLine(), out var b)) return;
            B = b;
            Console.Write("Wprowadź liczbę (c): ");
            if (double.TryParse(Console.ReadLine(), out var c))
            {
                C = c;
            }
        }

        private double Delta()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }

        public double[] Roots()
        {
            var delta = Delta();
            return delta switch
            {
                < 0 => [],
                0 => [-B / (2 * A)],
                _ => [(-B - Math.Sqrt(delta)) / (2 * A), (-B + Math.Sqrt(delta)) / (2 * A)]
            };
        }
    }
}
