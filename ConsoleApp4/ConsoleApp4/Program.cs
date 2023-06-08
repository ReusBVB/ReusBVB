using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Введите стартовый капитал");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = x + (x / 100 + 3) + (x / 100 + 8);
            Console.WriteLine(y);


        }


    }






}