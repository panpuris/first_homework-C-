// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Решение с методами и проверкой
int Rank(int numberOne, int numberTwo)
{
    int result = numberOne;
    for (int i = 1; i<numberTwo; i++)
    {
        result = result*numberOne;
    }
    return result;
}

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
    }
    return number;
}

int numbA = InputNumber ("Введите число A : ");
int numbB = InputNumber ("Введите число B : ");

System.Console.WriteLine(Rank(numbA,numbB));


//Решение без методов с проверкой

System.Console.WriteLine("Введите число A : ");
string? numA = Console.ReadLine();
bool result1 = int.TryParse(numA, out var number1);

System.Console.WriteLine("Введите число B : ");
string? numB = Console.ReadLine();
bool result2 = int.TryParse(numB, out var number2);

if (result1 == true && result2==true)
{
    System.Console.WriteLine(Math.Pow(number1,number2));
}
else
{
    System.Console.WriteLine("Введите корректные числа!!!");
}

// Решение без методов и без проверки

System.Console.WriteLine("Введите число A : ");
int numbersA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B : ");
int numbersB = Convert.ToInt32(Console.ReadLine());

int result = numbersA;
for (int i = 1; i<numbersB; i++)
{
    result=result*numbersA;
}
System.Console.WriteLine(result);

