// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] name = new int[5,5];
for (int i = 0; i < name.GetLength(0); i++)
{
    for (int j = 0; j < name.GetLength(1); j++)
    {
        name[i,j] = new Random().Next(1,10);
        Console.Write($" {name[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < name.GetLength(0); i++)
{
    for (int j = 0; j < name.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0)
        name[i, j] = name[i, j] + 1;
        Console.Write($" {name[i, j]} ");
    }
    Console.WriteLine();
}

