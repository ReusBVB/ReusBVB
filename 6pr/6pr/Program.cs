
using System;

namespace ArraySign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Чередуются ли положительные и отрицательные числа в массиве. ");
            bool signChanged = false;
            int signChangedIndex = 0;

            Console.Write("Введите длинну массива (N): ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите значение A[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Sign(array[i]) != Math.Sign(array[i - 1]))
                {
                    signChanged = true;
                }
                else
                {
                    signChanged = false;
                    signChangedIndex = i;
                    Console.WriteLine(signChangedIndex);
                    break;
                }
            }

            Console.WriteLine($"Знак поменялся? {signChanged}");
            Console.ReadKey();
        }
    }
}
