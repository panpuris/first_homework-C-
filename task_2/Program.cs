// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    System.Console.WriteLine($"Наибольшее число: {numberA}");
    System.Console.WriteLine($"Наименьшее число: {numberB}");
}
else
{
    System.Console.WriteLine($"Наибольшее число: {numberB}");
    System.Console.WriteLine($"Наименьшее число: {numberA}");
}

// // На случай если необходимо было вывести не цифры, а номер вводимого числа
// if (numberA > numberB)
// {
//     System.Console.WriteLine($"Наибольшее число: Первое");
//     System.Console.WriteLine($"Наименьшее число: Второе");
// }
// else
// {
//     System.Console.WriteLine($"Наибольшее число: Второе");
//     System.Console.WriteLine($"Наименьшее число: Первое");
// }