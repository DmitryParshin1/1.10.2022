// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Get(int number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i,j] = new Random().Next(1,10);
            Console.Write($"{number[i,j]}");
        }
    }
    return number;
}
Console.WriteLine();

double[,] Arr(double qwerty)
{
    double[] num = new double[qwerty.GetLength(1)];
    for (int j = 0; j < qwerty.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < qwerty.GetLength(0); i++)
    {
        
        sum += qwerty[i,j];
    }
    num[j] = sum / qwerty.GetLength(1);
}
    return num;
}

int[,] day = new int [5,5];
Get(day);
Console.WriteLine($"Средне арифметическое {Arr(day)}");
