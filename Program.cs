// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArray2DimRandom(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray2Dim(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int rowArray = new Random().Next(1,10);
int columnArray = new Random().Next(1, 10);
int[,] someArray = CreateArray2DimRandom(rowArray, columnArray);

Console.WriteLine("Введите х-координату элемента в массиве:");
int xEl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у-координату элемента в массиве:");
int yEl = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив {rowArray}x{columnArray}:");
PrintArray2Dim(someArray);

if (xEl > rowArray || yEl > columnArray) Console.WriteLine($"Элемента с координатами {xEl}x{yEl} в массиве нет");
else Console.WriteLine($"Элемент массива с координатами {xEl}x{yEl} = {someArray[xEl-1, yEl-1]}");