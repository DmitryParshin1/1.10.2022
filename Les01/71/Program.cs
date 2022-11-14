/*
Задача 71: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/


Console.WriteLine(" Введите число N ");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine(" Введите число M ");
int numberM = int.Parse(Console.ReadLine());

int Ackermann(int numberM, int numberN)
{
    if(numberM == 0) return numberN + 1;
    else 
    if ((numberM > 0) && (numberN == 0)) 
    return Ackermann(numberM - 1, 1);

    else 
   //if ((numberM > 0) && (numberN > 0)) 
    return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
}


Console.WriteLine($"Аккерман для чисел m = {numberM}, n = {numberN}  --- A(m,n) = {Ackermann(numberM, numberN)}");
