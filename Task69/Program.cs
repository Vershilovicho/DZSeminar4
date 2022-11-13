// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberb = Convert.ToInt32(Console.ReadLine());

int Power (int a, int b)
{
if (b == 0) return 1;
else return a * Power (a, b-1);
}

int res = Power(numbera, numberb);
Console.WriteLine(res);
