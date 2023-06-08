using System;

namespace EvenNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вывод отрицательных чётных чисел в обратном порядке в промежутке от A до B. ");
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = b; i >= a; i--)
            {
                if (i < 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}