// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine(" Введите число ");
int number = int.Parse(Console.ReadLine());

while (number != 0)
{
    int x = 0;
    x = ((number % 2) + x);
    number = number / 2;
    Console.WriteLine(number);
}


