// 49. Показать двумерный массив размером m×n заполненный вещественными числами

void Get(double[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i,j] = new Random().Next(1,10);
            Console.WriteLine($"{number[i,j]}");
        }
    }
}

double arr(double[,] qwerty)
{
    for (int i = 0; i < qwerty.GetLength(0); i++)
    {
        for (int j = 0; j < qwerty.GetLength(1); j++)
        {
            qwerty[i,j] = qwerty[i,j]/100;
        }
    }
    return qwerty;
}

double[,] day = new double [5,5];
Get(day);
Console.WriteLine($"вещественныt числа {arr(day)}");