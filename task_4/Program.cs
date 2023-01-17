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
int maxBet = numberA1;
if (maxBet < numberB1) maxBet = numberB1;
if (maxBet < numberC1) maxBet = numberC1;

System.Console.WriteLine($"Наибольшее число: {maxBet}");

