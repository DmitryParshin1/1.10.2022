// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] Matrix(int[,] arr)
{
    int A = arr.GetLength(0);
    int B = arr.GetLength(1);
    int[,] res = new int [A, B];
    for (int j = 0; j < A; j++)
    {
        for (int i = 0; i < B; i++)
        {
            res[A - 1 - i, j] = arr[i, j];
        }
    }
    return res;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //arr[i, j] = new Random().Next(1,10);
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ar1 = {{1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}};
var ar2 = Matrix(ar1);
Print(ar2);

