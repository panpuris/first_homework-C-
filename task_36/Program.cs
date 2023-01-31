// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int FindNumbers(int[] nechetnoe)
{
    int numb = 0;
    for (int i = 0; i < nechetnoe.Length; i++)
    {
        if (i % 2 != 0)
        {
            numb += nechetnoe[i];
        }

    }
    return numb;

}
int[] array = ArrayFill(4, -100, 100);
PrintArray(array);
System.Console.WriteLine(FindNumbers(array));