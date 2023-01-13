// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC1 = Convert.ToInt32(Console.ReadLine());

if (numberA1 > numberB1)
{
    System.Console.WriteLine($"Наибольшее число: {numberA1}");

}
else if (numberB1 > numberC1)
{
    System.Console.WriteLine($"Наибольшее число: {numberB1}");
}
else
{
    System.Console.WriteLine($"Наибольшее число: {numberC1}");
}
