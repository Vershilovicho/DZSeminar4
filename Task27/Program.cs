// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumNumbers}");

