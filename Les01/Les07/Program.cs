// Задача 10: Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int Method()
{
int result = 456;
Console.WriteLine($"наше число: {result}");
return result;
}
void Method2(int number)
{
    int result = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {result}!");
}

int wel = Method();
Method2(wel);