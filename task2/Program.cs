/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите следующее число диапазона N:");
int N = int.Parse(Console.ReadLine());
int sum = GetSumOfNumbersBetweenAB(M, N);
Console.WriteLine($"Сумма чисел в промежутке от M до N равна {sum}");


int GetSumOfNumbersBetweenAB(int M, int N)
{
    int sum = 0;
    if (N < M)
    {
        return sum;
    }
    else
    {
        sum = sum + M;
        M++;
    }
    return sum + GetSumOfNumbersBetweenAB(M,N);
}