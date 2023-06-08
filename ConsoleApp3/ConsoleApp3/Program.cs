using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("Введите значение a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d < 0) { Console.WriteLine("Корней нет"); }
            else if (d == 0)
            {
                double x = (-b) / 2 * a;
                Console.WriteLine("x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            Console.WriteLine("Для завершения нажми Enter");
            Console.Read();
        }
    }
}
