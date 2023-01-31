// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Random rand = new Random();
// double temp = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 3); 
// System.Console.WriteLine(temp);

double[] ArrayFill(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return array;
}


void PrintArray(double[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

double FindMinMaxNum(double[] randArray)
{
    double max = randArray[0];
    double min = randArray[0];

    for (int i = 0; i < randArray.Length; i++)
    {
        if (randArray[i] > max)
        {
            max = randArray[i];
            System.Console.WriteLine($"Максимальное значение {max}");
        }
        if (randArray[i] < min)
        {
            min = randArray[i];
            System.Console.WriteLine($"Минимальное значение {min}");
        }
    }
    double result = max - min;
    System.Console.WriteLine(Math.Round(result, 5));
    return result;
}



double[] array = ArrayFill(5, 1, 100);
PrintArray(array);
FindMinMaxNum(array);



// int[] ArrayFill(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
// }

// int FindMinMaxNum(int[] randArray)
// {
//     int max = randArray[0];
//     int min = randArray[0];

//     for (int i = 0; i < randArray.Length; i++)
//     {
//         if (randArray[i] > max)
//         {
//             max = randArray[i];
//             System.Console.WriteLine($"Максимальное{max}");
//         }
//         if (randArray[i] < min)
//         {
//             min = randArray[i];
//             System.Console.WriteLine($"Минимальное{min}");
//         }
//     }
//     int result = max - min;
//     System.Console.WriteLine(result);
//     return result;
// }



// int[] array = ArrayFill(5, 1, 100);
// PrintArray(array);
// FindMinMaxNum(array);




///Пробник метода
// int i = 0;
// int max = array[i];
// int min = array [i];
// for (i = 0;i<array.Length;i++)
// {
//     if (max>array[i])
//     {
//         max = array[i];
//         System.Console.WriteLine(max);
//     }
//     if (min<array[i])
//     {
//         min = array[i];
//         System.Console.WriteLine(min);
//     }
// }
// System.Console.WriteLine(max-min);

