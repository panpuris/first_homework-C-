// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

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

int FindNumbers(int[] chet)
{
    int numb = 0;
    for (int i = 0; i < chet.Length; i++)
    {
        if (chet[i] % 2 == 0) 
        {
            numb++;
            
        }
    
    }
    return numb;

}


int[] array = ArrayFill(4, 100, 1000);
PrintArray(array);
System.Console.WriteLine(FindNumbers(array));




/////Что упаковываем в метод поиска
// int numb = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         numb++;
//     }
// }
// System.Console.WriteLine(numb);