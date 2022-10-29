// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] FillArray(int[,] array, int min = 0, int max = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(min, max + 1);
        }
    }
    return array;
}

int[,] SortArray(int[,] array)
{
    bool condition = true;
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        do
        {
            condition = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    condition = true;
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        } while (condition);
    }
    return array;
}


void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Clear();
int[,] matrixOld = new int[6, 5];
matrixOld = FillArray(matrixOld, max:9);
PrintArray(matrixOld, "Начальная матрица: ");
SortArray(matrixOld);
PrintArray(matrixOld, "Отсортированная матрица: ");
