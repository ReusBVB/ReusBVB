using System;

namespace _4pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение суммы вещественных чисел");
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 1;
            double k = 1;

            for (int i = 2; i <= n; i++)
            {
                k = sum / i + k;
                Console.WriteLine($"k = {k}");
            }

            Console.WriteLine($"Сумма: {k}");
            Console.ReadKey();
        }
    }
}