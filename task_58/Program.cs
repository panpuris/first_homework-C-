// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

int[,] MatrixResult(int[,] matr1, int[,] matr2)
{
    int[,] resultArray = new int[matr1.GetLength(1), matr2.GetLength(0)];
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        System.Console.WriteLine(" Нельзя перемножить ");
        return resultArray;
       
    }
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                resultArray[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return resultArray;
}



System.Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillMatrix(rows, columns);
int[,] matrix2 = FillMatrix(rows, columns);
int[,] matrix1Xmatrix2 = MatrixResult(matrix1, matrix2);
PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
PrintMatrix(matrix1Xmatrix2);



