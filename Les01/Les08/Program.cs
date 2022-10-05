//Задача 13: Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int Method(string text)
{
    Console.Write(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}
void Method2(int number)
{
    if (number % 100 == number)
    {
        Console.WriteLine($"В нашем числе {number} нет третьей цифры");
    }
    else 
    {
        int digit = number % 10;
        while (true)
        {
            if (number % 1000 == number)
            {
                Console.WriteLine($"Третья цифра - {digit}");
                break;
            }
            else
            {
               number /= 10;
            }
        }
    }
}
    int N = Method("введите число");
    Method2(N);