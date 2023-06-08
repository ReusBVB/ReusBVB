//using static System.Collections.Specialized.BitVector32;

//Console.WriteLine("Введите значение а");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a > 0)
//{
//    a++;
//    Console.WriteLine(a);
//}
//else if (a < 0)
//{
//    a -= 2;
//    Console.WriteLine(a);
//}
//else
//{
//    a = 10;
//    Console.WriteLine(a);
//}
//Сортировка пузырьком(Bubble sort)

//Сортировка пузырьком - это простой алгоритм сортировки, который проходит по массиву несколько раз, сравнивая пары соседних элементов и меняя их местами, если они стоят в неправильном порядке.

//static void BubbleSort(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}

//2.Сортировка выбором(Selection sort)

//Сортировка выбором - это алгоритм сортировки, который находит наименьший элемент в массиве и помещает его в начало, затем находит следующий наименьший элемент и помещает его на второе место, и так далее, пока массив не будет отсортирован.

//static void SelectionSort(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        int minIndex = i;
//        for (int j = i + 1; j < n; j++)
//        {
//            if (arr[j] < arr[minIndex])
//            {
//                minIndex = j;
//            }
//        }
//        int temp = arr[i];
//        arr[i] = arr[minIndex];
//        arr[minIndex] = temp;
//    }
//}

//3.Сортировка вставками(Insertion sort)

//Сортировка вставками - это алгоритм сортировки, который проходит по массиву и вставляет каждый элемент в отсортированную часть массива в соответствующее место.

//static void InsertionSort(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 1; i < n; i++)
//    {
//        int key = arr[i];
//        int j = i - 1;
//        while (j >= 0 && arr[j] > key)
//        {
//            arr[j + 1] = arr[j];
//            j--;
//        }
//        arr[j + 1] = key;
//    }
//}

//4.Быстрая сортировка(Quick sort)

//Быстрая сортировка - это алгоритм сортировки, который выбирает опорный элемент в массиве, перемещает все элементы, меньшие опорного, влево от него, а все элементы, большие опорного, вправо от него, затем рекурсивно применяет этот процесс к левой и правой частям массива.

//static void QuickSort(int[] arr, int low, int high)
//{
//    if (low < high)
//    {
//        int pivotIndex = Partition(arr, low, high);
//        QuickSort(arr, low, pivotIndex - 1);
//        QuickSort(arr, pivotIndex + 1, high);
//    }
//}

//static int Partition(int[] arr, int low, int high)
//{
//    int pivot = arr[high];
//    int i = low - 1;
//    for (int j = low; j < high; j++)
//    {
//        if (arr[j] < pivot)
//        {
//            i++;
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }
//    int temp1 = arr[i + 1];
//    arr[i + 1] = arr[high];
//    arr[high] = temp1;
//    return i + 1;
//}

//Надеюсь, что эти примеры сортировок будут полезны для вас!





