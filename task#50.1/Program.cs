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

bool FindElement(int[,] arr, int numbX)
{   
    bool flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == numbX)
            {
                System.Console.Write($"Position(index) of array element(s) ,that you fill find is : [{i},{j}] ");
                System.Console.WriteLine();
                flag = true;
            }
        }
   }
   return flag;
}

System.Console.WriteLine("Input Length of your array, rows :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Length of your array, columns :");
int numberN = int.Parse(Console.ReadLine());
int[,] array = new int[numberM, numberN];
System.Console.WriteLine("Your array is :");
FillArray(array);
PrintArray(array);

System.Console.WriteLine("Input value of array element ,that you fill find :");
int numberX = int.Parse(Console.ReadLine());
bool found = FindElement(array, numberX);
if(found == false)
    System.Console.WriteLine($"Arrays does not have element with value : [{numberX}]");

