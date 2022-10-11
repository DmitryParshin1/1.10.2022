// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetValue(string text)
{
    Console.Write(text + " : ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double az, double bz, double result)
{
 string output = "|A(" + ax + ", " + ay + "); B(" + bx + ", " + by + "); C(" + az + ", " + bz + ")| = " +
                   Math.Round(result, 2);

        Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by, double az, double bz)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(x + y + z);
    return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");
double az = GetValue("az");
double bz = GetValue("bz");

double dis = GetDistance(ax, ay, bx, by, az, bz);
Print(ax, ay, bx, by, az, bz, dis);


