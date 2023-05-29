// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = Prompt("Введите значение k1 из уравнения y = k1 * x + b1: ");
double b1 = Prompt("Введите значение b1 из уравнения y = k1 * x + b1: ");
double k2 = Prompt("Введите значение k2 из уравнения y = k2 * x + b2: ");
double b2 = Prompt("Введите значение b2 из уравнения y = k2 * x + b2: ");
GetPointOfIntersection(k1, b1, k2, b2);


double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    double result = Convert.ToInt32(value);
    return result;
}

void GetPointOfIntersection(double k3, double b3, double k4, double b4)
{
    if (k3 == k4) Console.WriteLine("Прямые параллельны");
    else if (k3 == (-1 / k4)) Console.WriteLine("Прямые перпендикулярны");
    else
    {
        double x = (b4 - b3) / (k3 - k4);
        double y = k3 * x + b3;
        Console.WriteLine($"Прямые пересекаются в точке ({Math.Round(x, 3)}  {Math.Round(y, 3)})");

    }
}