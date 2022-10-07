//Напишите метод, который принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


int Weekend(string text)
    {
      int number = 0;
      Console.WriteLine("Введите день недел от 1 до 7: ");
      int value = int.Parse(Console.ReadLine());
      return value;
    }

void WeekDay(int number)
{
    if ((number % 6 == 0) || (number % 7 == 0))
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Опять работать");
    }
}

Console.Clear();
int day = Weekend("Введите день недел от 1 до 7: ");
WeekDay(day);