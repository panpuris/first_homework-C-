// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 100);
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
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FindNumber(int[,] matr)
{
    System.Console.WriteLine("Введите индексы искомого элемента: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows < matr.GetLength(0) && columns < matr.GetLength(1))
    {
        System.Console.WriteLine(matr[rows, columns]);
    }
    else
    {
        System.Console.WriteLine("Элемента с такими индексами в массиве нет! ");
    }

}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
System.Console.WriteLine();
PrintMatrix(matrix);
FindNumber(matrix);







