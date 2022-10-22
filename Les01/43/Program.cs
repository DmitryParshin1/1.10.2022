// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double GetValue(string text)
{
    Console.WriteLine(text + "  ");
    double value = int.Parse(Console.ReadLine());
    return value;
}

string Print(double b1, double b2, double k1, double k2)
{
    if(k1==k2)
    {
         string output = (" Прямые не пересекутся ");
         return output;
    }
    else
    {
        double x = (b1-b2)/(k1-k2);
        double y = k1 * x + b1;
        string output = ($" ({ x };{ y }) ");
        return output;
    }
}

double b1 = GetValue(" b1 ");
double b2 = GetValue(" b2 ");
double k1 = GetValue(" k1 ");
double k2 = GetValue(" k2 ");

Console.WriteLine($" Пересечение в {Print( b1 , b2 , k1 , k2 )} ");
