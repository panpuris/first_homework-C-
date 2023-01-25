// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string str)
{
    int number;
    string? text;
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

int Result(int nums)
{
    int sum = 0;
    for (int i = 0; i < nums; i++)
    {
        sum = sum+ nums%10;
        nums/=10;
    }
    return sum;
}

int num = InputNumber("Введите число : ");
int sum = Result(num);

System.Console.WriteLine(sum);

