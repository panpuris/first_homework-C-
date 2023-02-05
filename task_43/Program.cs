// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2 && b1 != b2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    System.Console.WriteLine($"({y1};{y2})");
}





//Проба с методами...
double[] ZnachArray(string text)
{
    System.Console.WriteLine(text);
    double[] array = new double[4];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите значение: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}
double LineFunc(double[] arr)
{
    double x = (arr[2] - arr[0]) / (arr[1] - arr[3]);
    double y = arr[1] * x + arr[0];
    return y;
}


double[] arr = ZnachArray("Введите значения по очереди, b1 , k1 , b2 , k2 !");
PrintArray(arr);
System.Console.Write($"({LineFunc(arr)};{LineFunc(arr)})");





