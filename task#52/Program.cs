// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"[ {arr[i, j]} ] ");
        }
        System.Console.WriteLine();
    }
}

void FindAverageColumns(int [,]arr)
{
    double summColumn = 0;
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           summColumn += arr[j,i];
        }
        double avg = Math.Round(summColumn/(arr.GetLength(1)),1);
        System.Console.Write($"[{avg}] ");
        summColumn = 0;
    }
}


System.Console.WriteLine("Input Length of your array, rows :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your array, columns :");
int numberN = int.Parse(Console.ReadLine());
int[,] array = new int[numberM, numberN];
System.Console.WriteLine("Your array is :");
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Your array average of columns is :");
FindAverageColumns(array);