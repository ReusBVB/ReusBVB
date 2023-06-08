Console.WriteLine("Вычисление выражения");

Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());

double result;

if (a > b)
{
    result = a / b + 1;
}
else if (a < b)
{
    result = (a - b) / a;
}
else
{
    result = -2;
}

Console.WriteLine($"Вычисляем выражение N = {result}");

Console.ReadKey();