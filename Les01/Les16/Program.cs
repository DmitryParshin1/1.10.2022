// Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//без math.pow

int get(string text)
{
    Console.WriteLine(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int numbers(int firstNumber, int secondNumber)
{
int result = 1;
for (int i = 0; i < secondNumber; i++)
{
    result = result * firstNumber;
}
return result;
}

void arr(int firstNumber, int secondNumber, int result)
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> {result}");
}

int firstNumber = get("Введите число");
int secondNumber = get("Введите степень");
arr(firstNumber, secondNumber, numbers(firstNumber, secondNumber));

