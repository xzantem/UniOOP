namespace Lab1
{
    internal static class Calculator
    {
        private static void Sum()
        {
            Console.Write("Podaj pierwszy składnik (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Podaj pierwszy składnik (b): ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Subtract()
        {
            Console.Write("Podaj odjemnik (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Podaj odjemną (b): ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Multiply()
        {
            Console.Write("Podaj pierwszy czynnik (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Podaj pierwszy czynnik (b): ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Divide()
        {
            Console.Write("Podaj dzielną (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Podaj dzielnik (b): ");
                if (double.TryParse(Console.ReadLine(), out var b) && b != 0)
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Power()
        {
            Console.Write("Podaj podstawę (a): ");
            if (double.TryParse(Console.ReadLine(), out var a) && a > 0)
            {
                Console.Write("Podaj wykładnik (b): ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Root()
        {
            Console.Write("Podaj liczbę pierwiastkowaną (a): ");
            if (double.TryParse(Console.ReadLine(), out var a) && a > 0)
            {
                Console.Write("Podaj stopień pierwiastka (b): ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.WriteLine($"{a} ^ (1 / {b}) = {Math.Pow(a, 1 / b)}");
                    return;
                }
                Console.WriteLine("Podano nieprawidłową liczbę");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Sin()
        {
            Console.Write("Podaj kąt (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine($"sin({a}*)) = {Math.Sin(Math.PI * a / 180)}");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
            
        }
        private static void Cos()
        {
            Console.Write("Podaj kąt (a): ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine($"cos({a}*)) = {Math.Cos(Math.PI * a / 180)}");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        private static void Tan()
        {
            Console.Write("Podaj kąt (a): ");
            if (double.TryParse(Console.ReadLine(), out var a) && a % 90 != 0)
            {
                Console.WriteLine($"tg({a}*)) = {Math.Tan(Math.PI * a / 180)}");
                return;
            }
            Console.WriteLine("Podano nieprawidłową liczbę");
        }
        public static void ShowMenu()
        {
            while(true)
            {
                Console.Write("Wybierz działanie programu (dodawanie: +, odejmowanie: -, mnożenie: *, dzielenie: /, potęgowanie: ^, pierwiastek: r, sinus: s, cosinus: c, tangens: t, zamknij program: x): ");
                var t = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                switch (t.KeyChar)
                {
                    case '+':
                        Sum();
                        break;
                    case '-':
                        Subtract();
                        break;
                    case '*':
                        Multiply();
                        break;
                    case '/':
                        Divide();
                        break;
                    case '^':
                        Power();
                        break;
                    case 'r':
                        Root();
                        break;
                    case 's':
                        Sin();
                        break;
                    case 'c':
                        Cos();
                        break;
                    case 't':
                        Tan();
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja");
                        break;
                    case 'x':
                        Environment.Exit(0);
                        return;
                }
            }
        }
    }
}