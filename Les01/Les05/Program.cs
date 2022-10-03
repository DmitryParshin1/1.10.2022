// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Method()
{
int result = new Random().Next(10,100);
Console.WriteLine($"наше число: {result}");
return result;
}
void Method2(int number)
{
    int digit1 = number%10;
    int digit2 = number/10;

    if (digit1 > digit2)
    {
        Console.WriteLine($"наибольшая цифра - {digit1}");
    }
    else 
    {
        Console.WriteLine($"наибольшая цифра - {digit2}");
    }
}

int wel = Method();
Method2(wel);