// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Rank(int numberOne, int numberTwo)
{
    int result = numberOne;
    for (int i = 1; i<numberTwo; i++)
    {
        result = result*numberOne;
    }
    return result;
}



System.Console.WriteLine("Введите число A : ");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B : ");
int numB = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(numA,numB);
// System.Console.WriteLine();
// System.Console.WriteLine(result);

// через цикл for
// int result = numA;
// for (int i = 1; i<numB; i++)
// {
//     result=result*numA;
// }

//через цикл while
// int i = 1;
// while (i<numB)
// {
//     result = result*numA;
//     i++;
// }
System.Console.WriteLine(Rank(numA,numB));

