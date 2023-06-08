using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Нахождение последовательности Фибоначчи.  ");
            int n;

            while (true)
            {
                Console.Write("Введите длинну последовательности (N >= 2): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2)
                {
                    break;
                }
            }

            int[] sequence = new int[n];
            sequence[0] = 1;
            sequence[1] = 1;

            for (int i = 2; i < n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            Console.WriteLine("Последовательность Фибоначчи:");
            foreach (int number in sequence)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
