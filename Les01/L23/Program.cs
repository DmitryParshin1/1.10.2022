/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

int[] Array(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
    number[i] = new Random().Next(-9, 9);
    Console.Write($" {number[i]} ");
    }
    return number;
}

int SecondArray(int[] sum, int A)
{
    int result = 0;
    if(A == 0)
    {
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i]>0) result += sum[i];        
    }
    }
    else
    {
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i]<0) result += sum[i];        
    }        
    }
    return result;
}

void printresult(int n, string b)
{
    Console.WriteLine(b + " " + n);
}

Console.Clear();
int[] day = new int [12];
Array(day);
Console.WriteLine();
printresult(SecondArray(day, 0), "Сумма положительных -");
printresult(SecondArray(day, 1), "Сумма отрицательных -");

