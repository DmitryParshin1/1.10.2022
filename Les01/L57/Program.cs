// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] Array(int[,] number)
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
Console.WriteLine();


int[,] NextArray(int[,] arr)
{
    int A = arr.GetLength(0);
    int B = arr.GetLength(1);
    int[,] res = new int[A, B];
    for (int i = 0; i < A; i++)
    {
        for (int j = 0; j < B; j++)
        {
            for (int k = 0; k < A - 1; k++)
            {
                if(res[A,B] < arr[i + 1, B])
                {
                    int sum = arr[i + 1, B];
                    arr[i + 1, B] = res[A,B];
                    res[A,B] = sum;
                }
            }
        }
    }
    return res;
}

int[,] day = new int [3, 3];
day = Array(day);

Console.Clear();
Console.WriteLine();
NextArray(day);

