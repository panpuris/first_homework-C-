// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ArrayFill(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int FindNumb(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

System.Console.WriteLine("Введите колличество чисел в массиве : ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = ArrayFill(num, -100, 101);
PrintArray(arr);
System.Console.WriteLine(FindNumb(arr));


// int result = 0;
// for (int i = 0; i<arr.Length;i++)
// {
//     if (arr[i] > 0)
//     {
//         result++;
//     }
// }
// System.Console.WriteLine(result);