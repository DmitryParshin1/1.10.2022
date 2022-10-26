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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if(arr[i,k] < arr[i, k + 1])
                {
                    int sum = arr[i, k + 1];
                    arr[i, k + 1] = arr[i,k];
                    arr[i,k] = sum;
                    Console.Write($" {sum} ");
                }
            }
        }
    }
    return arr;
}
Console.WriteLine();

int[,] day = new int [3, 3];
day = Array(day);
Console.WriteLine($" {NextArray(day)} ");
