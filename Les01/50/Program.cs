/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] Array(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(1,100);
            Console.Write($" {number[i, j]} ");
        }
        Console.WriteLine();
    }
    return number;
}
Console.WriteLine();

int[,] SecondArray = new int [5, 5];
Array(SecondArray);

Console.Write(" Введите строку ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите столбец ");
int j = Convert.ToInt32(Console.ReadLine());

if(i > SecondArray.GetLength(0) || j > SecondArray.GetLength(1))
{
    Console.WriteLine(" Элемента нет");
}
else
{
    Console.WriteLine($" Элемент находится {i} строке {j} столбце {SecondArray[i-1, j-1]}");
}
