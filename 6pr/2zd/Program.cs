using System;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение максимального кол-ва одинаковых чисел");
            int maxCount = 0;
            int count = 0;
            int[] myArray = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите число {i + 1}:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }

                count = 0;
            }

            Console.WriteLine($"Максимальное кол-во повторяющихся чисел {maxCount}");
            Console.ReadKey();
        }
    }
}