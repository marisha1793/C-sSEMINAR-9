﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
GetSequenceFromNTo1(N);

void GetSequenceFromNTo1(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.WriteLine(N);
    N--;
    GetSequenceFromNTo1(N);
}
