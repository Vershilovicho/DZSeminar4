// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое цисло M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое цисло N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0 && a > 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));


}

int akk = Akkerman(m, n);
Console.WriteLine($"A ({m},{n}) = {akk}");


