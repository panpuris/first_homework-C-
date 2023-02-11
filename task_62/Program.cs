// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// System.Console.WriteLine("Введите размерность квадратного массива: ");
// int elementsInArray = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[elementsInArray,elementsInArray];
// FillArraySpiral(matrix, elementsInArray);
// PrintArray(matrix);



// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 System.Console.Write("0" + array[i, j] + " ");
//             }
//             else System.Console.Write(array[i, j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Метод Руслана
int[,] FillMatrixtoSpiral(int row, int col)
{
    int[,] array = new int[row, col];

    int Up = 0;    // Сужение сверху
    int Down = 0;  // Сужение снизу
    int Left = 0;  // Сужение слева
    int Right = 0; // Сужение справа

    // Переменные счетчики используемые в расчетах
    int k = 1; // Счетчик, который присваивает значение элемнетам массива
    int i = 0; // Координары строки
    int j = 0; // Координаты столбца

    while (k <= row * col)
    {
        array[i, j] = k;

        // Проверка возможности движения вправо
        if (i == Up && j < col - Right - 1)
            ++j; // производится движение по столбцу вправо

        // Проверка возможности движения вниз
        else if (j == col - Right - 1 && i < row - Down - 1)
            ++i; // производится движение по строкам вниз

        // Проверка возможности движения влево
        else if (i == row - Down - 1 && j > Left)
            --j; // производится движение по столбцу влево

        // Проверка возможности движения вверх
        else
            --i; // производится движение по строкам вверх

        // Сужение диапазона, если окружность заполнена
        if ((i == Up + 1) && (j == Left) && (Left != col - Right - 1))
        {
            ++Up;
            ++Down;
            ++Right;
            ++Left;
        }
        ++k; // Счетчик увеличен на 1
        // Цикл начинается заново
    }
    return array;
}

// Блок вывода элементов двумерного массива
void PrintArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); ++x)
    {
        for (int y = 0; y < array.GetLength(1); ++y)
        {
            System.Console.Write(array[x, y] + "\t");
        }
        System.Console.WriteLine();
    }
}

// Основной блок программы
int[,] SpiralArray = FillMatrixtoSpiral(4, 4);
PrintArray(SpiralArray);