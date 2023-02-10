// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindMinRow(int[,] matrix)
{

    int[] arr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i, j];
        }
        System.Console.WriteLine(count); // для проверки 
        arr[i] = count;
        count = 0;
    }
    int minIndex = 0;
    int minSum = arr[0];
    for (int j = 0; j < arr.Length; j++)
    {


        if (arr[j] < minSum)
        {
            minSum = arr[j];
            minIndex = j;
        }

    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов {minIndex + 1}, сумма составляет {minSum}");



}

int[,] matrix = FillMatrix(4, 4);
PrintMatrix(matrix);
FindMinRow(matrix);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int count = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         count += matrix[i, j];

//     }
//     System.Console.WriteLine(count);
// }









