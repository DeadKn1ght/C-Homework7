// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindElement(int[,] arr, int numbX, int numbY)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == numbX && j == numbY)
            {
                System.Console.Write($"Value of element is : [ {arr[i, j]} ] ");
            }

        }
        if ((numbX >= arr.GetLength(0)) || (numbY >= arr.GetLength(1)))
        {
            System.Console.WriteLine($"Arrays does not have element with index : [{numbX},{numbY}]");
            break;
        }
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

System.Console.WriteLine("Input position(index) of array element ,that you fill find :");
int numberX = int.Parse(Console.ReadLine());
int numberY = int.Parse(Console.ReadLine());
FindElement(array, numberX, numberY);

