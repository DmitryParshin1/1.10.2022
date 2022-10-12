// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int red = getNumber("Введите числа: ");
if(Palindrom(red))
{
    Console.WriteLine($"Данное число {red} является полидромом");
}
else
{
    Console.WriteLine($"Данное число {red} не является полидромом");
}

int getNumber(string text)
{
 Console.Write(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool Palindrom(int number)
{
    int TempNumber = number / 10;
    int Reverse = number % 10;
    do
    {
        Reverse = Reverse * 10 + TempNumber % 10;
        TempNumber = TempNumber / 10;
    }
    while(TempNumber != TempNumber % 10);
    Reverse = Reverse * 10 + TempNumber % 10;
    return Reverse == number;
}