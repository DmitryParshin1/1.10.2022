// Задача 10: Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int Method(string text)
{
    Console.Write(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

void Method2(int number)
{
    int result = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {result}!");
    }

int N = Method("введите число");
Method2(N);