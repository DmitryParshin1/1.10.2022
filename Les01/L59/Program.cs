//  В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] Array(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(1, 10);
        }

    }
    return number;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] Formula(int[,] array, int sum)
{
    int[] max = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        max[i] = sum;
        sum = 0;
    }
    return max;
}

int Index(int[] A, int B)
{
    int min = 0;
    min = A[0];
    for (int i = 0; i < A.Length; i++)
    {
        if(A[i] < min)
        {
            A[i] = min;
            B = i;
            //Console.WriteLine($" {B} ");
        }
    }
    Console.WriteLine($" {B} ");
    return min;
}

Console.Clear();
int[,] day = new int[6, 5];
Array(day);
PrintArray(day);
Console.WriteLine();

int sum = 0;
int min = 0;
int[] day2 = Formula(day, sum);
Console.WriteLine(" Номер строки с минимальным значением ");
Index(day2, min);
