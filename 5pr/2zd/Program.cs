using System;

namespace BookPages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Нахождение общего числа страниц во всех журналах. ");
            int totalPages = 0;
            int nextPageCount;

            do
            {
                Console.Write("Введите количество страниц следующего издания: ");
                nextPageCount = int.Parse(Console.ReadLine());

                if (nextPageCount > 16)
                {
                    totalPages += nextPageCount;
                }
            }
            while (nextPageCount != 0);

            Console.WriteLine($"Количество страниц: {totalPages}");
            Console.ReadKey();
        }
    }
}
