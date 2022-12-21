//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. (т.е нужно решить
//задачу без использования Math.Pow) 
//3, 5 -> 243 (3⁵) 
//2, 4 -> 16

Console.WriteLine ("Введите первое чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе чиcло");
int b = Convert.ToInt32 (Console.ReadLine ());
int s=1;
for ( int i=1;i<=b;i++)
    s *= a;
Console.WriteLine(s);