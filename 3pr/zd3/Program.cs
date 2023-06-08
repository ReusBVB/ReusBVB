Console.WriteLine("Выберите единицу измерения:");
Console.WriteLine("1 - Килограмм");
Console.WriteLine("2 - Миллиграмм");
Console.WriteLine("3 - Грамм");
Console.WriteLine("4 - Тонна");
Console.WriteLine("5 - Центнер");

int x = int.Parse(Console.ReadLine());

Console.Write("Введите массу объекта: ");
int y = int.Parse(Console.ReadLine());

string unit = "";

switch (x)
{
    case 1:
        unit = "килограмм";
        break;
    case 2:
        unit = "миллиграмм";
        y *= 1000000;
        break;
    case 3:
        unit = "грамм";
        y *= 1000;
        break;
    case 4:
        unit = "тонн";
        y /= 1000;
        break;
    case 5:
        unit = "центнер";
        y *= 100;
        break;
}

Console.WriteLine($"{unit} {y}");
Console.ReadKey();


