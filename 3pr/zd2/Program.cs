Console.Write("Принадлежит ли точка координатам X;Y в заданной области? ");
int x, y;
Console.Write("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
y = int.Parse(Console.ReadLine());

if ((x >= 0 && y >= 0 && x * x + y * y <= 36) || (x >= 0 && y >= 0 && x <= 6 - y))
{
    Console.WriteLine("Точка принадлежит области.");
}
else
{
    Console.WriteLine("Точка не принадлежит области.");
}

Console.ReadKey();