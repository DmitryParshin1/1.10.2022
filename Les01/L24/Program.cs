/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да  */

int[] Array(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
    number[i] = new Random().Next(0, 10);
    Console.Write($" {number[i]} ");
    }
    return number;
}

int GetValue(string text)
{
    Console.WriteLine(text + "  ");
    int value = int.Parse(Console.ReadLine());
    return value;
}



bool Number(int[] array, int A)
{
    bool result = false;
{
        for (int i = 0; i < array.Length; i++)
        {
        if(array[i] == A) result = true;
        }
    }
    return result;
}

void print(string a)
{
    Console.WriteLine(a);
}


int[] day = new int [7];
Console.WriteLine();
Array(day);

int N = GetValue(" Введите число ");
if(Number(day, N)) print("Данный элемент есть");
else print("Данного элемента нет");
