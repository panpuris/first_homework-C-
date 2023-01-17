// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    System.Console.WriteLine(number / 10 % 10);
}
else
{
    System.Console.WriteLine("Вы ввели неверное число, попробуйте еще раз!");
}