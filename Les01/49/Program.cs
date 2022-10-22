// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] Get(double[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().NextDouble() * 10;
        }
    }
    return number;
}

void Print(double[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]:N2} ");
        }
        Console.WriteLine();
    }
}

double[,] day = new double [5,5];
day = Get(day);

Console.Clear();
Console.WriteLine("вещественныt числа: \n");
Print(day);