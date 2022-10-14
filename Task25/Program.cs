// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int exp1 = 1;
    for (int i = 1; i <= num2; i++)
        {
            exp1 = exp1 * num1;
        }
    return exp1;
}

if (numberB > 0)
{
    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} -> {exponentiation}");
}
else
    {
        Console.WriteLine("Число В не натуральное");
    }
