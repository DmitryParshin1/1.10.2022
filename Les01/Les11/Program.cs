// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int GetValue(string text)
{
    Console.Write(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;

}

string Get(int n)
{
    string res = String.Empty;
    for (int i = 1; i < n + 1; i++)
    {
        res = res + Convert.ToString(i * i * i) + " ";
    }
    return res;
}

int n = 5;
Console.WriteLine(Get(n));