// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double CrossPoint(double k, double m, double b, double c)
{
    double x = (c - b) / (k - m);
    if (k == m)
    {
        Console.WriteLine("The lines are parallel");
    }
    else
    {
        x = (c - b) / (k - m);
        Console.WriteLine(x);
    }
    return x;
}



Console.WriteLine("Enter first numbers (press enter after each of them)");
double k = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second numbers (press enter after each of them)");
double m = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

CrossPoint(k, m, b, c);