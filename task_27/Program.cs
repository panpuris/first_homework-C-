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
// {
//     // полурабочее решение 
//     // int sum = 0;
//     // for (int i = 0; i < nums; i++)
//     // {
//     //     sum = sum + nums % 10;
//     //     nums /= 10;
//     // }
//     // return sum;

// }
{
int sum = 0;
while (nums > 0)
{
sum = sum + nums % 10;
nums /= 10;

}
return sum;
}

int num = InputNumber("Введите число : ");
int sum = Result(num);

System.Console.WriteLine(sum);


// //На случай если нам будет необходимо распечатать цифру из строчного масива, необходимо пользоваться двойной конвертацией
// string? text = "123456";
// int num = Convert.ToInt32(Convert.ToString(text[4]));
// System.Console.WriteLine(num);
System.Console.WriteLine("Введите число");
string? text = Console.ReadLine();
int numBers = Convert.ToInt32(Convert.ToString(text!.Length));
int result = 0;
for (int i = 0; i < numBers; i++)
{
    result = result + Convert.ToInt32(Convert.ToString(text[i]));
}

System.Console.WriteLine(result);