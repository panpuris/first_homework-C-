// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
{

    if (count % 2 == 0)
    {

        System.Console.WriteLine(count);

    }
    count += 1;

}
System.Console.WriteLine("Введите число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
for (int count1 = 1; count1 <= num1; count1 += 1)
{
    if (count1 % 2 == 0)
    {
        System.Console.WriteLine(count1);
    }
}
