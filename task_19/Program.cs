// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Введите пятизначное число для проверки: ");
string? paliNum = Console.ReadLine();
if (paliNum.Length == 5)
{
    if (paliNum[0] == paliNum[4] || paliNum[1] == paliNum[3])
    {
        System.Console.WriteLine($"Число {paliNum} является палиндромом");
    }

    else
    {
        System.Console.WriteLine($"Число {paliNum} не является палиндромом");
    }
}
if (paliNum.Length > 5 || paliNum.Length < 5)
{
    System.Console.WriteLine("Введите корректное число!!!");
}

// //На случай если нам будет необходимо распечатать цифру из строчного масива, необходимо пользоваться двойной конвертацией
// string? text = "123456";
// int num = Convert.ToInt32(Convert.ToString(text[4]));
// System.Console.WriteLine(num);