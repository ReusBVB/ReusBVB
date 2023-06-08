using System;

namespace BacteriaCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На сколько размножились бактерии");
            int bacteriaCount = 1;
            uint minutes;

            Console.WriteLine("Введите количество минут");
            minutes = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= minutes; i++)
            {
                bacteriaCount *= 2;
            }

            Console.WriteLine($"Количество бактерий: {bacteriaCount}");
            Console.ReadKey();
        }
    }
}
