// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void Array(int[,] number)
{
    //int[,] array = new int [number];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(1,10);
            Console.Write($" {number[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] NextArray(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int r = 0; r < A.GetLength(1); r++)
            {
                result[i, j] += A[i, r] * B[j, r];
            }
            Console.Write($" {result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

int[,] A = new int [2, 2];
Console.WriteLine(" первая матрица ");
Array(A);

int[,] B = new int [2, 2];
Console.WriteLine(" вторая матрица ");
Array(B);

Console.WriteLine(" Результат ");
NextArray(A, B);