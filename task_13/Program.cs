// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (99 < num && num < 1000)
{
    System.Console.WriteLine(num % 10);
}
else if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (1000 < num && num < 10000)
{
    System.Console.WriteLine(num % 100 / 10);
}
else if (10000 < num && num < 100000)
{
    System.Console.WriteLine(num % 1000 / 100);
}
else if (100000 < num && num < 1000000)
{
    System.Console.WriteLine(num % 10000 / 1000);
}
else if (1000000 < num && num < 10000000)
{
    System.Console.WriteLine(num % 100000 / 10000);
} // и так далее


 //Правильное математическое решение 

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//         System.Console.WriteLine(num);
//     }
//     System.Console.WriteLine(num%10);
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }

// Вариант через массив

System.Console.WriteLine("Напишите Ваше число");
string? numbers = Console.ReadLine();
int n = numbers.Length; // когда я хочу в дальнейшем использовать переменную длинны массива, я же должен ей присвоить значение int?
if (n >= 3)
{
    System.Console.WriteLine(numbers[2]);
}
else if (n < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
