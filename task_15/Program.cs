// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число: ");
int weekDayNum = Convert.ToInt32(Console.ReadLine());
if (0 < weekDayNum && weekDayNum < 6)
{
    System.Console.WriteLine("Сейчас будни, работаем дальше");
}
else if (5 < weekDayNum && weekDayNum < 8)
{
    System.Console.WriteLine("Отлично сейчас выходные, можно расслабиться!");
}
else
{
    System.Console.WriteLine("Такого дня не существует!");
}