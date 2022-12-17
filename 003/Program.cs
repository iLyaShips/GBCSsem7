// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}

void Average(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{(sum / arr.GetLength(0)).ToString("F" + 1),3} ");
    }
}

try
{
    Console.WriteLine("Введите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.Write("Среднее арифметическое каждого столбца: ");
    Average(array);
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимые данные.");
}
