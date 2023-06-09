﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {



        }



    }




//}
//Практическая часть к экзамену:
//☺

////1
////Даны натуральные числа n и k. Составить программу вычисления выражения 1k 
//+2k + ...+nk.
//Разработать меню программы. Пункты меню: ввод данных, обработка, просмотр 
//результатов, выход.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 0, k = 0, sum = 0;
//        bool isExit = false;

//        while (!isExit)
//        {
//            Console.WriteLine("Меню программы:");
//            Console.WriteLine("1 - Ввод данных");
//            Console.WriteLine("2 - Обработка");
//            Console.WriteLine("3 - Просмотр результатов");
//            Console.WriteLine("4 - Выход");

//            Console.Write("Выберите пункт меню: ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.Write("Введите значение n: ");
//                    n = int.Parse(Console.ReadLine());

//                    Console.Write("Введите значение k: ");
//                    k = int.Parse(Console.ReadLine());
//                    break;

//                case 2:
//                    sum = 0;
//                    for (int i = 1; i <= n; i++)
//                    {
//                        sum += (int)Math.Pow(i, k);
//                    }
//                    Console.WriteLine("Обработка завершена.");
//                    break;

//                case 3:
//                    Console.WriteLine($"Результат: {sum}");
//                    break;

//                case 4:
//                    isExit = true;
//                    break;

//                default:
//                    Console.WriteLine("Ошибка! Неверный пункт меню.");
//                    break;
//            }

//            Console.WriteLine();
//        }
//    }
//}

////2
////Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные 
//и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести 
//порядковый номер первого элемента, нарушающего закономерность.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // исходный массив
//        int flag = arr[0] % 2; // флаг, который показывает, четное или нечетное число должно следовать
//        int i = 1;
//        while (i < arr.Length && arr[i] % 2 != flag)
//        {
//            i++;
//        }
//        if (i == arr.Length)
//        {
//            Console.WriteLine(0); // если чередуются, то выводим 0
//        }
//        else
//        {
//            Console.WriteLine(i); // если не чередуются, то выводим порядковый номер первого элемента, нарушающего закономерность
//        }
//    }
//}

////3
////Создать матрицу вещественных элементов А(n,n) и выполнить сортировку 
//элементов, расположенных под главной диагональю методом «пузырька». 
//Отсортированную последовательность вывести на экран.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 4; // размерность матрицы
//        double[,] A = new double[n, n]; // создаем матрицу вещественных элементов А(n,n)
//        Random rnd = new Random();
//        for (int i = 0; i < n; i++) // заполняем матрицу случайными значениями
//        {
//            for (int j = 0; j < n; j++)
//            {
//                A[i, j] = rnd.NextDouble() * 10;
//                Console.Write("{0:F2}t", A[i, j]); // выводим элементы матрицы на экран
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        // сортировка элементов, расположенных под главной диагональю методом «пузырька»
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - 1 - i; j++)
//            {
//                if (A[j + 1, j] < A[j, j + 1])
//                {
//                    double temp = A[j + 1, j];
//                    A[j + 1, j] = A[j, j + 1];
//                    A[j, j + 1] = temp;
//                }
//            }
//        }

//        // вывод отсортированной последовательности на экран
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < i; j++)
//            {
//                Console.Write("{0:F2}t", A[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

////4
////Дана квадратная матрица A[N, N]. Записать на место отрицательных элементов 
//матрицы нули, а на место положительных — единицы. Вывести на печать 
//нижнюю треугольную матрицу в общепринятом виде.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int N = 4; // размерность матрицы
//        int[,] A = new int[N, N]; // создаем матрицу A[N, N]
//        Random rnd = new Random();
//        for (int i = 0; i < N; i++) // заполняем матрицу случайными значениями
//        {
//            for (int j = 0; j < N; j++)
//            {
//                A[i, j] = rnd.Next(-10, 11); // случайное число от -10 до 10
//                Console.Write("{0}t", A[i, j]); // выводим элементы матрицы на экран
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        // заменяем отрицательные элементы матрицы на нули, а положительные - на единицы
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                if (A[i, j] < 0)
//                {
//                    A[i, j] = 0;
//                }
//                else if (A[i, j] > 0)
//                {
//                    A[i, j] = 1;
//                }
//            }
//        }

//        // выводим на печать нижнюю треугольную матрицу в общепринятом виде
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                if (i >= j)
//                {
//                    Console.Write("{0}t", A[i, j]);
//                }
//                else
//                {
//                    Console.Write("t");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}

////5
////С клавиатуры вводятся строки S, S1, S2. Заменить в строке S все вхождения 
//строки S1 на строку S2.

//Console.WriteLine("Введите строку S:");
//string S = Console.ReadLine();
//Console.WriteLine("Введите строку S1:");
//string S1 = Console.ReadLine();
//Console.WriteLine("Введите строку S2:");
//string S2 = Console.ReadLine();

//string result = S.Replace(S1, S2);
//Console.WriteLine("Результат замены: " + result);

////6
////Исходная информация содержится в файле. Определить, сколько слов текста 
//имеют длину 1,2,3,…, 10 и более 10 символов. Вывести эти слова в 
//последовательности возрастания их длины. Слова очередной длины вывести с 
//новой строки.

//using System;
//using System.Collections.Generic;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // Считываем содержимое файла в строку
//        string text = File.ReadAllText("input.txt");

//        // Разбиваем строку на слова и переводим в нижний регистр
//        string[] words = text.Split(new[] { ' ', 't', 'n', 'r' }, StringSplitOptions.RemoveEmptyEntries);
//        for (int i = 0; i < words.Length; i++)
//        {
//            words[i] = words[i].ToLower();
//        }

//        // Создаем словарь для подсчета количества слов каждой длины
//        Dictionary<int, int> wordLengths = new Dictionary<int, int>();
//        for (int i = 1; i <= 10; i++)
//        {
//            wordLengths[i] = 0;
//        }
//        wordLengths[11] = 0;

//        // Подсчитываем количество слов каждой длины
//        foreach (string word in words)
//        {
//            int length = word.Length;
//            if (length <= 10)
//            {
//                wordLengths[length]++;
//            }
//            else
//            {
//                wordLengths[11]++;
//            }
//        }

//        // Выводим слова по длинам в порядке возрастания
//        for (int i = 1; i <= 11; i++)
//        {
//            Console.WriteLine("{0} символов: {1}", i, wordLengths[i]);
//        }
//    }
//}

////7
////В программе обработку данных оформить в качестве метода. Дана символьная 
//строка и символ. Слово - последовательность символов между пробелами, не 
//содержащая пробелы внутри себя. Определить количество слов в строке,
//оканчивающихся на заданный символ.

//using System;

//class Program
//{
//    static void Main()
//    {
//        string str = "Hello world! This is a sample string.";
//        char ch = 'd';

//        int count = CountWordsEndingWith(str, ch);

//        Console.WriteLine($"Количество слов, оканчивающихся на символ '{ch}': {count}");
//    }

//    static int CountWordsEndingWith(string str, char ch)
//    {
//        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        int count = 0;

//        foreach (string word in words)
//        {
//            if (word.EndsWith(ch.ToString()))
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}

////8
////Разработать программу, реализующую работу со структурой Аптека. В 
//программе необходимо создать базу данных (массив структур) из N записей (N 
//– определяется при работе программы), выполнить просмотр и поиск записи по 
//заданному критерию (вводится при работе программы). Поля структуры: 
//название лекарства, дата изготовления, срок годности.

//using System;

//struct Medicine
//{
//    public string Name;
//    public DateTime ManufactureDate;
//    public DateTime ExpirationDate;
//}

//class Pharmacy
//{
//    private Medicine[] Database;

//    public void CreateDatabase()
//    {
//        Console.Write("Введите количество записей: ");
//        int n = int.Parse(Console.ReadLine());
//        Database = new Medicine[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Введите название лекарства {i + 1}: ");
//            string name = Console.ReadLine();
//            Console.Write($"Введите дату изготовления лекарства {i + 1} (ГГГГ-ММ-ДД): ");
//            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
//            Console.Write($"Введите срок годности лекарства {i + 1} (в месяцах): ");
//            int expirationMonths = int.Parse(Console.ReadLine());
//            DateTime expirationDate = manufactureDate.AddMonths(expirationMonths);
//            Database[i] = new Medicine
//            {
//                Name = name,
//                ManufactureDate = manufactureDate,
//                ExpirationDate = expirationDate
//            };
//        }
//    }

//    public void ViewDatabase()
//    {
//        Console.WriteLine("Название лекарстваtДата изготовленияtСрок годностиt");
//        foreach (Medicine medicine in Database)
//        {
//            Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
//        }
//    }

//    public void SearchByCriteria()
//    {
//        Console.Write("Введите критерий поиска (1 - название лекарства, 2 - дата изготовления, 3 - срок годности): ");
//        int criteria = int.Parse(Console.ReadLine());
//        switch (criteria)
//        {
//            case 1:
//                Console.Write("Введите название лекарства: ");
//                string name = Console.ReadLine();
//                foreach (Medicine medicine in Database)
//                {
//                    if (medicine.Name == name)
//                    {
//                        Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
//                    }
//                }
//                break;
//            case 2:
//                Console.Write("Введите дату изготовления (ГГГГ-ММ-ДД): ");
//                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
//                foreach (Medicine medicine in Database)
//                {
//                    if (medicine.ManufactureDate == manufactureDate)
//                    {
//                        Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
//                    }
//                }
//                break;
//            case 3:
//                Console.Write("Введите срок годности (в месяцах): ");
//                int expirationMonths = int.Parse(Console.ReadLine());
//                DateTime expirationDate = DateTime.Now.AddMonths(expirationMonths);
//                foreach (Medicine medicine in Database)
//                {
//                    if (medicine.ExpirationDate >= expirationDate)
//                    {
//                        Console.WriteLine($"{medicine.Name}tt{medicine.ManufactureDate:yyyy-MM-dd}tt{medicine.ExpirationDate:yyyy-MM-dd}t");
//                    }
//                }
//                break;
//            default:
//                Console.WriteLine("Некорректный критерий поиска.");
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Pharmacy pharmacy = new Pharmacy();
//        bool exit = false;
//        while (!exit)
//        {
//            Console.WriteLine("Меню:");
//            Console.WriteLine("1. Создать базу данных");
//            Console.WriteLine("2. Просмотреть базу данных");
//            Console.WriteLine("3. Поиск по базе данных");
//            Console.WriteLine("4. Вы ход");
//            Console.Write("Выберите действие: ");
//            int choice = int.Parse(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    pharmacy.CreateDatabase();
//                    break;
//                case 2:
//                    pharmacy.ViewDatabase();
//                    break;
//                case 3:
//                    pharmacy.SearchByCriteria();
//                    break;
//                case 4:
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Некорректный выбор.");
//                    break;
//            }
//        }
//    }
//}

////9
////Разработать программу, реализующую работу с линейным списком. В 
//программе необходимо создать базу данных (список) из N записей (N –
//определяется при работе программы), выполнить просмотр, поиск записи по 
//заданному критерию. Картинная галерея. Ведётся учёт экспонатов галереи: 
//наименование картины, художник, цена.

//using System;

//class Painting
//{
//    public string Name;
//    public string Artist;
//    public decimal Price;
//    public Painting Next;
//}

//class Gallery
//{
//    private Painting Head;

//    public void AddPainting()
//    {
//        Console.Write("Введите название картины: ");
//        string name = Console.ReadLine();
//        Console.Write("Введите имя художника: ");
//        string artist = Console.ReadLine();
//        Console.Write("Введите цену: ");
//        decimal price = decimal.Parse(Console.ReadLine());
//        Painting painting = new Painting
//        {
//            Name = name,
//            Artist = artist,
//            Price = price
//        };
//        painting.Next = Head;
//        Head = painting;
//    }

//    public void ViewPaintings()
//    {
//        Console.WriteLine("Название картиныtХудожникtЦена");
//        Painting painting = Head;
//        while (painting != null)
//        {
//            Console.WriteLine($"{painting.Name}tt{painting.Artist}tt{painting.Price}");
//            painting = painting.Next;
//        }
//    }

//    public void SearchByCriteria()
//    {
//        Console.Write("Введите критерий поиска (1 - название картины, 2 - художник, 3 - цена): ");
//        int criteria = int.Parse(Console.ReadLine());
//        switch (criteria)
//        {
//            case 1:
//                Console.Write("Введите название картины: ");
//                string name = Console.ReadLine();
//                Painting painting = Head;
//                while (painting != null)
//                {
//                    if (painting.Name == name)
//                    {
//                        Console.WriteLine($"{painting.Name}tt{painting.Artist}tt{painting.Price}");
//                    }
//                    painting = painting.Next;
//                }
//                break;
//            case 2:
//                Console.Write("Введите имя художника: ");
//                string artist = Console.ReadLine();
//                painting = Head;
//                while (painting != null)
//                {
//                    if (painting.Artist == artist)
//                    {
//                        Console.WriteLine($"{painting.Name}tt{painting.Artist}tt{painting.Price}");
//                    }
//                    painting = painting.Next;
//                }
//                break;
//            case 3:
//                Console.Write("Введите цену: ");
//                decimal price = decimal.Parse(Console.ReadLine());
//                painting = Head;
//                while (painting != null)
//                {
//                    if (painting.Price == price)
//                    {
//                        Console.WriteLine($"{painting.Name}tt{painting.Artist}tt{painting.Price}");
//                    }
//                    painting = painting.Next;
//                }
//                break;
//            default:
//                Console.WriteLine("Некорректный критерий поиска.");
//                break;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Gallery gallery = new Gallery();
//        bool exit = false;
//        while (!exit)
//        {
//            Console.WriteLine("Меню:");
//            Console.WriteLine("1. Добавить картину");
//            Console.WriteLine("2. Просмотреть картину");
//            Console.WriteLine("3. Поиск по галерее");
//            Console.WriteLine("4. Выход");
//            Console.Write("Выберите действие: ");
//            int choice = int.Parse(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    gallery.AddPainting();
//                    break;
//                case 2:
//                    gallery.ViewPaintings();
//                    break;
//                case 3:
//                    gallery.SearchByCriteria();
//                    break;
//                case 4:
//                    exit = true;
//                    break;
//                default:
//                    Console.iteLine("Некорректный выбор.");
//                    break;
//            }
//        }
//    }
//}

////10
////Разработать класс для определения одномерных массивов строк 
//фиксированной длины. В классе определить методы создания массива,
//просмотра и поиска.

//public class FixedLengthStringArray
//{
//    private string[] array;

//    public FixedLengthStringArray(int length)
//    {
//        array = new string[length];
//    }

//    public void FillArray()
//    {
//        Console.WriteLine($"Введите {array.Length} строк:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = Console.ReadLine();
//        }
//    }

//    public void DisplayArray()
//    {
//        Console.WriteLine("Массив строк:");
//        foreach (string s in array)
//        {
//            Console.WriteLine(s);
//        }
//    }

//    public void SearchArray(string searchString)
//    {
//        bool found = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] == searchString)
//            {
//                Console.WriteLine($"Строка найдена в ячейке {i}");
//                found = true;
//            }
//        }
//        if (!found)
//        {
//            Console.WriteLine("Строка не найдена");
//        }
//    }
//}