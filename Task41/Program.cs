﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел M: ");
int m = Convert.ToInt32(Console.ReadLine());

int [] Fillarray (int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}

int [] arr = Fillarray(m);

int CountPositivEl (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {

            count++;
        }
    }
    return count;
}

int c = CountPositivEl (arr);
Console.WriteLine($"Количество чисел больше 0 -> {c}");





