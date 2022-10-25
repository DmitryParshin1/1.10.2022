/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

double[,] Array(double[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(1,10);
            Console.Write($" {number[i, j]} ");
        }
        Console.WriteLine();
    }
    return number;
}

double[] NextArray(double[,] size)
{
    double[] num = new double[size.GetLength(1)];
    for (int j = 0; j < size.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < size.GetLength(1); i++)
        {
            sum += size[i, j];
        }
        num[j] = sum / size.GetLength(1);
    }
    return num;
}

Console.Clear();

double[,] day = new double [5, 5];
Array(day);
Console.WriteLine($" Среднее арифметическое: [{String.Join(", ", NextArray(day))}]");