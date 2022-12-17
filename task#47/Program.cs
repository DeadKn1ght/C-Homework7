// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble()*20 -10 ,1);
        }
    }
}

void PrintArray(double[,] arr)
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

System.Console.WriteLine("Input Number M :");
int numberM = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input Number N :");
int numberN = int.Parse(Console.ReadLine());
double[,] array = new double[numberM, numberN];
FillArray(array);
PrintArray(array);