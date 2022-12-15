// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void ElemSearch(int[,] array, int elem)
{
    int[] elem_index = new int[2];
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == elem)
            {
                elem_index[0] = i;
                elem_index[1] = j;
                flag = true;
            }
            if (flag == true) break;
        }
        if (flag == true) break;    
    }
    if (flag == true)
        Console.Write("Индексы искомого значения : " + elem_index[0] + " " + elem_index[1]);
    else
        Console.WriteLine("Искомого элемента нет в массиве.");
}

try
{
    Console.WriteLine("Введите искомое значение.");
    int elem = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[5, 5];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ElemSearch(array, elem);
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимые данные.");
}