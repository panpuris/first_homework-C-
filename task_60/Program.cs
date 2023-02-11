// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] FillMatrix3D(int x, int y, int z)
{
    // int count = 10; способ на случай если рандом рандом не подействует и добавит одинаковые числа
    Random rand = new Random();
    int[,,] matr = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {

                // matr[i, j, k] = count; но будет поочередное возрастание с шагом 

                matr[i, j, k] = rand.Next(10, 100);
                System.Console.WriteLine(matr[i, j, k]);
                // count += 5; указанным здесь
            }

        }
    }

    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
        }

    }

}

int[,,] array3D = FillMatrix3D(2, 2, 2);
PrintMatrix(array3D);


