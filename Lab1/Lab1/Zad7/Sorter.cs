namespace Lab1.Zad7
{
    public class Sorter
    {
        private double[] Array { get; set; }
        public Sorter(int n)
        {
            Array = new double[n];
            for (var i = 0; i < n; i++)
            {
                Console.Write("Wprowadź liczbę: ");
                if (double.TryParse(Console.ReadLine(), out var value))
                {
                    Array[i] = value;
                }
                else
                {
                    Console.WriteLine("Wprowadzono nieprawidłową liczbę");
                    i--;
                }
            }
        }
        public double[] BubbleSort()
        {
            var arr = Array;
            for (var i = arr.Length; i > 0; i--)
                for (var j = 0; j < i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            return arr;
        }
        public double[] InsertionSort()
        {
            var arr = Array;
            for (var i = 1; i < arr.Length; ++i)
            {
                var key = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
