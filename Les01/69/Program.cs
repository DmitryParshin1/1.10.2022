﻿//69. Найти сумму элементов от M до N, N и M заданы

Console.WriteLine(" Введите число А:  ");
int NumberA = int.Parse(Console.ReadLine());

Console.WriteLine(" Введите число B:  ");
int NumberB = int.Parse(Console.ReadLine());

void NumberSum(int NumberA, int NumberB, int Sum)
{
    if(NumberA > NumberB)
    {
        Console.WriteLine($" Сумма чисел {Sum} ");
        return;
    }
    Sum = Sum + (NumberA++);
    NumberSum(NumberA, NumberB, Sum);
}

NumberSum(NumberA, NumberB, 0);


/*int SumRec(int n)
{
     if(n == 0) return 0;
    else return n + SumRec(n -1);
}

Console.WriteLine(SumRec(10));*/

