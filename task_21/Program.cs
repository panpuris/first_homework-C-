// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine( "Введите кординаты точки A: ");
int [] a_num = new int [3];
a_num [0] = Convert.ToInt32(Console.ReadLine());
a_num [1] = Convert.ToInt32(Console.ReadLine());
a_num [2] = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine( "Введите кординаты точки B: ");
int [] b_num = new int [3];
b_num [0] = Convert.ToInt32(Console.ReadLine());
b_num [1] = Convert.ToInt32(Console.ReadLine());
b_num [2] = Convert.ToInt32(Console.ReadLine());

double diss = Math.Sqrt (Math.Pow ( a_num [0] - b_num [0],2) + Math.Pow (a_num[1] - b_num [1],2) + Math.Pow (a_num [2] - b_num[2],2));

System.Console.WriteLine(Math.Round(diss,2));

