// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getValue(string text)
{
    Console.WriteLine(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int getRes(int number)
{
    int firstNumber = number % 10;
    int secondNumber = number / 10;
    int sum = firstNumber + secondNumber;
    Console.WriteLine(sum);
    return sum;
   }

Console.Clear();
int qwerty = getValue("Введиите число");
getRes(qwerty);

