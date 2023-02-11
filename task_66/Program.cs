// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum (int m, int n)
{
    if (m==n)return m;
    return n + SumNum(m,n-1);
    
}
System.Console.WriteLine(SumNum(4,8));