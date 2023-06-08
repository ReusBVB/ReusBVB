using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевернуть массив. ");
            int[] myArray = new int[10];
            int temp = 0, arrayLength = 0, i = 0;

            Console.WriteLine("Введите длинну масива:");
            arrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            for (i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Элемент {i + 1}:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arrayLength / 2; i++)
            {
                temp = myArray[i * 2 + 1];
                myArray[i * 2 + 1] = myArray[i * 2];
                myArray[i * 2] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Перевёрнутый массив:");
            for (i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(myArray[i] + "");
            }

            Console.ReadKey();
        }
    }
}
