Console.WriteLine("Start");

int a = -9;
int b = -3;

int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Максимальное число - " + max);
Console.WriteLine("Минимальное число - " + min);


Console.WriteLine("End");